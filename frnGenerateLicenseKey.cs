using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndev.LicenseKey
{
    public partial class frmGenerateLicenseKey : Form
    {
        private string hardwareID;
        private clsRegistration registration;
        public frmGenerateLicenseKey()
        {
            registration = new clsRegistration(isGenerateLicKey: true);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = registration.GenLicKey(hardwareID);

            textBoxLicenseKey.Text = key;
        }

        private void frnGenerateLicenseKey_Load(object sender, EventArgs e)
        {
            hardwareID = registration.createHardwareID();
            if (Information.IsNothing(hardwareID))
            {
                Interaction.MsgBox("Can not get Hardware ID");
                Close();
            }
            else
            {
                labelHardwareID.Text = ConvertHardwareIDToDisplay(hardwareID);
            }
        }
        private string ConvertHardwareIDToDisplay(string hardwareID)
        {
            string text = Strings.Mid(hardwareID, 1, 4);
            string text2 = Strings.Mid(hardwareID, 5, 4);
            string text3 = Strings.Mid(hardwareID, 9, 4);
            string text4 = Strings.Mid(hardwareID, 13, 4);
            string text5 = Strings.Mid(hardwareID, 17, 4);
            string text6 = Strings.Mid(hardwareID, 21, 4);
            string text7 = Strings.Mid(hardwareID, 25, 4);
            string text8 = Strings.Mid(hardwareID, 29, 4);
            string text9 = text + "-" + text2 + "-" + text3 + "-" + text4 + "-" + text5 + "-" + text6 + "-" + text7 + "-" + text8;
            return text9.ToUpper();
        }
    }
}
