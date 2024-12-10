using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics.SymbolStore;

namespace ndev.LicenseKey
{
    public sealed class clsRegistration
    {
        private bool registered;

        private bool m_bIsGenerateLicKey;
        public bool GetRegistered => registered;

        public clsRegistration()
        {
            registered = false;
            if (!checkRegistered())
            {
                clsRegistration pRegistration = this;
                frmRegistration frmRegistration2 = new frmRegistration(ref pRegistration);
                frmRegistration2.ShowDialog();
            }
        }
        public clsRegistration(bool isGenerateLicKey)
        {
            m_bIsGenerateLicKey = isGenerateLicKey;
        }

        private byte[] encryptMD5Data(string data)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            return mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(data));
        }

        private string md5(string data)
        {
            return BitConverter.ToString(encryptMD5Data(data)).Replace("-", "").ToLower();
        }

        private byte[] encryptSHA1Data(string data)
        {
            SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            return sHA1CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(data));
        }

        private string sha1(string data)
        {
            return BitConverter.ToString(encryptSHA1Data(data)).Replace("-", "").ToLower();
        }

        private string getDiskDriveSerialNumber()
        {
            string result = null;
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            try
            {
                using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
                {
                    if (managementObjectEnumerator.MoveNext())
                    {
                        ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
                        result = managementObject["SerialNumber"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }

            return result;
        }

        private string getLicenseKey()
        {
            object objectValue = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\qhsoft", "LK", null));
            if (objectValue == null)
            {
                return null;
            }

            return Encoding.ASCII.GetString((byte[])objectValue);
        }
        public string GenLicKey(string hardwareID)
        {
            return generateLicenseKey(hardwareID);
        }
        private string generateLicenseKey(string hardwareID)
        {
            string expression = sha1(hardwareID + "ndevlock");
            expression = Strings.StrReverse(expression);
            return sha1(expression);
        }

        public string createHardwareID()
        {
            string diskDriveSerialNumber = getDiskDriveSerialNumber();
            if (Information.IsNothing(diskDriveSerialNumber))
            {
                return null;
            }

            diskDriveSerialNumber = Strings.StrReverse(diskDriveSerialNumber) + DateAndTime.Now.ToString("ddyyyyMM");
            return md5(diskDriveSerialNumber);
        }

        public string GetHardwareID()
        {
            string diskDriveSerialNumber = getDiskDriveSerialNumber();
            if (Information.IsNothing(diskDriveSerialNumber))
            {
                return null;
            }

            object objectValue = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\qhsoft", "FRD", null));
            if (objectValue == null)
            {
                return null;
            }

            diskDriveSerialNumber = Strings.StrReverse(diskDriveSerialNumber) + Encoding.ASCII.GetString((byte[])objectValue);
            return md5(diskDriveSerialNumber);
        }

        public bool checkRegistered()
        {
            string hardwareID = GetHardwareID();
            if (Information.IsNothing(hardwareID))
            {
                registered = false;
                return false;
            }

            string left = generateLicenseKey(hardwareID);
            string licenseKey = getLicenseKey();
            if (licenseKey == null)
            {
                registered = false;
                return false;
            }

            if (Operators.CompareString(left, licenseKey, TextCompare: false) == 0)
            {
                registered = true;
                return true;
            }

            registered = false;
            return false;
        }
    }
}
