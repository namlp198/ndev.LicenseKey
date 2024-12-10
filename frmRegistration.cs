using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ndev.LicenseKey
{
    [DesignerGenerated]
    public class frmRegistration : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        private IContainer components;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        [AccessedThroughProperty("txtHardwareID")]
        private TextBox _txtHardwareID;

        [AccessedThroughProperty("txtLicenseKey")]
        private TextBox _txtLicenseKey;

        [AccessedThroughProperty("btnRegister")]
        private Button _btnRegister;

        [AccessedThroughProperty("btnExit")]
        private Button _btnExit;

        private clsRegistration registration;

        private string hardwareID;

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return _Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            set
            {
                _Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return _Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            set
            {
                _Label2 = value;
            }
        }

        internal virtual TextBox txtHardwareID
        {
            [DebuggerNonUserCode]
            get
            {
                return _txtHardwareID;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            set
            {
                _txtHardwareID = value;
            }
        }

        internal virtual TextBox txtLicenseKey
        {
            [DebuggerNonUserCode]
            get
            {
                return _txtLicenseKey;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            set
            {
                _txtLicenseKey = value;
            }
        }

        internal virtual Button btnRegister
        {
            [DebuggerNonUserCode]
            get
            {
                return _btnRegister;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            set
            {
                EventHandler value2 = btnRegister_Click;
                if (_btnRegister != null)
                {
                    _btnRegister.Click -= value2;
                }

                _btnRegister = value;
                if (_btnRegister != null)
                {
                    _btnRegister.Click += value2;
                }
            }
        }

        internal virtual Button btnExit
        {
            [DebuggerNonUserCode]
            get
            {
                return _btnExit;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            set
            {
                EventHandler value2 = btnExit_Click;
                if (_btnExit != null)
                {
                    _btnExit.Click -= value2;
                }

                _btnExit = value;
                if (_btnExit != null)
                {
                    _btnExit.Click += value2;
                }
            }
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            checked
            {
                lock (__ENCList)
                {
                    if (__ENCList.Count == __ENCList.Capacity)
                    {
                        int num = 0;
                        int num2 = __ENCList.Count - 1;
                        int num3 = 0;
                        while (true)
                        {
                            int num4 = num3;
                            int num5 = num2;
                            if (num4 > num5)
                            {
                                break;
                            }

                            WeakReference weakReference = __ENCList[num3];
                            if (weakReference.IsAlive)
                            {
                                if (num3 != num)
                                {
                                    __ENCList[num] = __ENCList[num3];
                                }

                                num++;
                            }

                            num3++;
                        }

                        __ENCList.RemoveRange(num, __ENCList.Count - num);
                        __ENCList.Capacity = __ENCList.Count;
                    }

                    __ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
                }
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if ((disposing && components != null) ? true : false)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtHardwareID = new System.Windows.Forms.TextBox();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            System.Windows.Forms.Label label = this.Label1;
            System.Drawing.Point location = new System.Drawing.Point(56, 35);
            label.Location = location;
            this.Label1.Name = "Label1";
            System.Windows.Forms.Label label2 = this.Label1;
            System.Drawing.Size size = new System.Drawing.Size(103, 20);
            label2.Size = size;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hardware ID:";
            this.Label2.AutoSize = true;
            System.Windows.Forms.Label label3 = this.Label2;
            location = new System.Drawing.Point(56, 92);
            label3.Location = location;
            this.Label2.Name = "Label2";
            System.Windows.Forms.Label label4 = this.Label2;
            size = new System.Drawing.Size(98, 20);
            label4.Size = size;
            this.Label2.TabIndex = 1;
            this.Label2.Text = "License Key:";
            System.Windows.Forms.TextBox textBox = this.txtHardwareID;
            location = new System.Drawing.Point(173, 33);
            textBox.Location = location;
            this.txtHardwareID.Name = "txtHardwareID";
            System.Windows.Forms.TextBox textBox2 = this.txtHardwareID;
            size = new System.Drawing.Size(520, 26);
            textBox2.Size = size;
            this.txtHardwareID.TabIndex = 2;
            System.Windows.Forms.TextBox textBox3 = this.txtLicenseKey;
            location = new System.Drawing.Point(173, 90);
            textBox3.Location = location;
            this.txtLicenseKey.Name = "txtLicenseKey";
            System.Windows.Forms.TextBox textBox4 = this.txtLicenseKey;
            size = new System.Drawing.Size(520, 26);
            textBox4.Size = size;
            this.txtLicenseKey.TabIndex = 3;
            System.Windows.Forms.Button button = this.btnRegister;
            location = new System.Drawing.Point(173, 153);
            button.Location = location;
            this.btnRegister.Name = "btnRegister";
            System.Windows.Forms.Button button2 = this.btnRegister;
            size = new System.Drawing.Size(150, 36);
            button2.Size = size;
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            System.Windows.Forms.Button button3 = this.btnExit;
            location = new System.Drawing.Point(474, 153);
            button3.Location = location;
            this.btnExit.Name = "btnExit";
            System.Windows.Forms.Button button4 = this.btnExit;
            size = new System.Drawing.Size(111, 36);
            button4.Size = size;
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            size = new System.Drawing.Size(757, 234);
            this.ClientSize = size;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.txtHardwareID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Margin = margin;
            this.Name = "frmRegistration";
            this.Text = "Registration KGKJetPrinter Library";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public frmRegistration(ref clsRegistration pRegistration)
        {
            base.Load += frmRegistration_Load;
            __ENCAddToList(this);
            InitializeComponent();
            registration = pRegistration;
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            hardwareID = registration.createHardwareID();
            if (Information.IsNothing(hardwareID))
            {
                Interaction.MsgBox("Can not get Hardware ID");
                Close();
            }
            else
            {
                txtHardwareID.Text = ConvertHardwareIDToDisplay(hardwareID);
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

        private string ConvertToLicenseKey(string LicenseKeyDisplay)
        {
            if (Operators.CompareString(LicenseKeyDisplay, "", TextCompare: false) == 0)
            {
                return LicenseKeyDisplay;
            }

            string text = Strings.Replace(LicenseKeyDisplay, "-", "");
            return text.ToLower();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string s = ConvertToLicenseKey(txtLicenseKey.Text);
            RegistryKey registryKey = MyProject.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
            RegistryKey registryKey2 = registryKey.CreateSubKey("qhsoft");
            registryKey2.SetValue("LK", Encoding.ASCII.GetBytes(s), RegistryValueKind.Binary);
            registryKey2.SetValue("FRD", Encoding.ASCII.GetBytes(DateAndTime.Now.ToString("ddyyyyMM")), RegistryValueKind.Binary);
            if (registration.checkRegistered())
            {
                Interaction.MsgBox("Register Successful");
                registration.checkRegistered();
                Close();
            }
            else
            {
                Interaction.MsgBox("License Key is Invalid");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
