using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using QRCoder;
using System.IO;
using static QRCoder.PayloadGenerator;

namespace QRCreator
{
    public partial class MainForm : MetroSet_UI.Forms.MetroSetForm
    {
        // some globals vars
        private bool save_image_text = false;
        private bool save_image_wifi = false;

        private string auth_name = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }
        #region TextPage

        private void btnGenerateText_Click(object sender, EventArgs e)
        {
            // Checking if input is not null
            if (!string.IsNullOrWhiteSpace(inputBoxText.Text))
            {
                GenerateQRFromText(inputBoxText.Text);
            }
            else
            {
                MetroSetMessageBox.Show(this, "Field cannot be empty!", "Error");
            }
        }

        private void GenerateQRFromText(string text)
        {
            try
            {
                // Creating the elements here 
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                // If user checks the check box saves the image with default name
                if (save_image_text == true)
                {
                    using (FolderBrowserDialog f = new FolderBrowserDialog())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            qrCodeImage.Save(Path.Combine(f.SelectedPath, "qr-code-text.png"));
                        }
                    }
                }

                // show image
                pictureBoxText.Image = qrCodeImage;

                // free ram
                qrGenerator.Dispose();
                qrCodeData.Dispose();
                qrCode.Dispose();
            }
            //If ex is catched displat 
            //TODO : Custom Mess 
            // Not more showing the message but an fix for this error
            catch (Exception e)
            {
                MetroSetMessageBox.Show(this, "An error : " + e.Message, "QR Creator");
            }
            
        }

        private void boxSaveText_CheckedChanged(object sender)
        {
            // Checking check box state
            if (boxSaveText.Checked == true)
            {
                save_image_text = true;
            }
            else
            {
                save_image_text = false;
            }
        }
        #endregion

        #region WifiPage
        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Getting the combo box selected value 

            int selectedIndex = WifiAuths.SelectedIndex;
            WifiAuths.SelectedItem.ToString();
            auth_name = WifiAuths.Items[selectedIndex].ToString();
            if (auth_name == "nopass")
            {
                passwordWifi.Text = "";
                passwordWifi.ReadOnly = true;
            }
            else
            {
                passwordWifi.ReadOnly = false;
            }
        }

        private void boxSaveWifi_CheckedChanged(object sender)
        {
            // Also getting check box status
            if (boxSaveWifi.Checked == true)
            {
                save_image_wifi = true;
            }
            else
            {
                save_image_wifi = false;
            }
        }

        private void btnGenerateWifi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameboxWifi.Text))
            {
                nameboxWifi.Focus();
            }
            // IF the password field is empty is has an error beacause of the nopass 
            // else if (string.IsNullOrWhiteSpace(passwordWifi.Text))
            //{
            //    passwordWifi.Focus();
            //}
            else
            {
                GenerateQRForWifi(nameboxWifi.Text, passwordWifi.Text, auth_name);
            }
        }

        private void GenerateQRForWifi(string name, string password,  string auth)
        {
            try
            {
                using (FolderBrowserDialog f = new FolderBrowserDialog())
                {
                    // if this is empty then this will not execute : 
                    // TODO : Check the pass only on WPA or WEP
                    if (auth == "nopass")
                    {
                        WiFi generator = new WiFi(name, password, WiFi.Authentication.nopass);
                        string payload = generator.ToString();

                        QRCodeGenerator qrGenerator = new QRCodeGenerator();
                        QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                        QRCode qrCode = new QRCode(qrCodeData);
                        var qrCodeAsBitmap = qrCode.GetGraphic(20);

                        if (save_image_wifi == true)
                        {
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                qrCodeAsBitmap.Save(Path.Combine(f.SelectedPath, "qr-code-wifi-no-pass.png"));
                            }
                        }

                        pictureBoxWifi.Image = qrCodeAsBitmap;

                        //free ram
                        qrGenerator.Dispose();
                        qrCodeData.Dispose();
                        qrCode.Dispose();
                        Clear();
                    }
                    else if (auth == "WPA")
                    {
                        WiFi generator = new WiFi(name, password, WiFi.Authentication.WPA);
                        string payload = generator.ToString();

                        QRCodeGenerator qrGenerator = new QRCodeGenerator();
                        QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                        QRCode qrCode = new QRCode(qrCodeData);
                        var qrCodeAsBitmap = qrCode.GetGraphic(20);

                        if (save_image_wifi == true)
                        {
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                qrCodeAsBitmap.Save(Path.Combine(f.SelectedPath, "qr-code-wifi-pass.png"));
                            }
                        }
                        pictureBoxWifi.Image = qrCodeAsBitmap;
                        qrGenerator.Dispose();
                        qrCodeData.Dispose();
                        qrCode.Dispose();
                        Clear();

                    }
                    else if (auth == "WEP")
                    {
                        WiFi generator = new WiFi(name, password, WiFi.Authentication.WEP);
                        string payload = generator.ToString();

                        QRCodeGenerator qrGenerator = new QRCodeGenerator();
                        QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                        QRCode qrCode = new QRCode(qrCodeData);
                        var qrCodeAsBitmap = qrCode.GetGraphic(20);

                        if (save_image_wifi == true)
                        {
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                qrCodeAsBitmap.Save(Path.Combine(f.SelectedPath, "qr-code-wifi-pass.png"));
                            }
                        }

                        pictureBoxWifi.Image = qrCodeAsBitmap;

                        qrGenerator.Dispose();
                        qrCodeData.Dispose();
                        qrCode.Dispose();
                        Clear();

                    }
                }
            }
            catch (Exception e)
            {
                MetroSetMessageBox.Show(this, "An error : " + e.Message, "QR Creator");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Adding items to the form 
            WifiAuths.Items.Add("nopass");
            WifiAuths.Items.Add("WPA");
            WifiAuths.Items.Add("WEP");

            WifiAuths.SelectedIndex = 0;
        }

        private void Clear()
        {
            // Used to clean user info but no so great maybe implemented on a button 
            // TODO > Implement on button and remove from (free ram) 
            nameboxWifi.Text = "";
            passwordWifi.Text = "";
        }
        #endregion
    }
}
