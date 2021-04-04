using MetroSet_UI.Forms;
using QRCoder;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QRCreator
{
    public partial class MainForm : MetroSet_UI.Forms.MetroSetForm
    {
        // some globals vars
        private bool save_image_text = false;
        private bool save_image_wifi = false;
        private bool save_image_url = false;
        private bool save_image_book = false;

        // some versions vars
        private string local_ver = "1.1"; // Modified when a new update will be released
        private string online_ver = string.Empty;
        private string file = "version";
        private string online_url = "https://pastebin.com/raw/tLB8hMvT"; // TODO : Configure pastebin...
        private string download_url = string.Empty;

        


        // combobox value 
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

        private void GenerateQRForWifi(string name, string password, string auth)
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
                        Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);

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
                        Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);

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
                        Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);

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

            SetLocalVersion(local_ver);
            CompareVersions();
        }

        private void Clear()
        {
            // Used to clean user info but no so great maybe implemented on a button 
            // TODO > Implement on button and remove from (free ram) 
            nameboxWifi.Text = "";
            passwordWifi.Text = "";
        }
        #endregion

        #region UrlPage
        private void btnUrlGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputUrl.Text))
            {
                MetroSetMessageBox.Show(this, "The field not should be empty!", "QR Creator");
                inputUrl.Focus();
            }
            else if (!(inputUrl.Text.Contains("http") || inputUrl.Text.Contains("https")))
            {
                MetroSetMessageBox.Show(this, "The field should contain a link that has http or https", "QR Creator");
                inputUrl.Focus();
                pictureBoxUrl.Image = null;
            }
            else
            {
                GenerateQRForUrl(inputUrl.Text);
            }
        }

        private void GenerateQRForUrl(string url)
        {
            try
            {
                Url generator = new Url(url);
                string payload = generator.ToString();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);

                if (save_image_url == true)
                {
                    using (FolderBrowserDialog f = new FolderBrowserDialog())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            qrCodeAsBitmap.Save(Path.Combine(f.SelectedPath, "qr-code-url.png"));
                        }
                    }
                }

                pictureBoxUrl.Image = qrCodeAsBitmap;

                qrCode.Dispose();
                qrCodeData.Dispose();
                qrGenerator.Dispose();
            }
            catch (Exception e)
            {
                MetroSetMessageBox.Show(this, "An error : " + e.Message, "QR Creator");
            }
        }

        private void metroSetCheckBox1_CheckedChanged(object sender)
        {
            if (metroSetCheckBox1.Checked == true)
            {
                save_image_url = true;
            }
            else
            {
                save_image_url = false;
            }
        }
        #endregion

        #region BookMarkPage
        private void BookGenerate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(bookName.Text) || string.IsNullOrWhiteSpace(bookUrl.Text)))
            {
                MetroSetMessageBox.Show(this, "The fields not should be empty!", "QR Creator");
            }
            else if (!(bookUrl.Text.Contains("http") || bookUrl.Text.Contains("https")))
            {
                MetroSetMessageBox.Show(this, "The field should contain a link that has http or https", "QR Creator");
                bookUrl.Focus();
                bookPicture.Image = null;
            }
            else
            {
                GenerateQRForBookMark(bookName.Text, bookUrl.Text);
            }
        }

        private void GenerateQRForBookMark(string name, string url)
        {
            Bookmark generator = new Bookmark(url, name);
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);

            if (save_image_book == true)
            {
                using (FolderBrowserDialog f = new FolderBrowserDialog())
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        qrCodeAsBitmap.Save(Path.Combine(f.SelectedPath, "qr-code-bookmark.png"));
                    }
                }
            }

            bookPicture.Image = qrCodeAsBitmap;

            qrGenerator.Dispose();
            qrCode.Dispose();
            qrCodeData.Dispose();
        }

        private void metroSetCheckBox2_CheckedChanged(object sender)
        {
            if (metroSetCheckBox2.Checked == true)
            {
                save_image_book = true;
            }
            else
            {
                save_image_book = false;
            }
        }
        #endregion

        #region Updater Functions
        private void ReadVersionFromOnline()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                   string data =  web.DownloadString(online_url);
                   UpdateModel um = UpdateModel.FromJson(data);

                   online_ver = um.Version;
                   download_url =  um.DownloadUrl.AbsoluteUri;
                }
            }
            catch (Exception e)
            {

                MetroSetMessageBox.Show(this, "Error catched : " + e.Message, "Error");
            }
        }

        private void SetLocalVersion(string version)
        {
            string file_path = Path.Combine(Application.StartupPath, file);
            try
            {
                if (File.Exists(file))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        sw.Write(version);
                    }
                }
                else
                {
                    File.Create(file_path);
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        sw.Write(version);
                    }
                }

            }
            catch (Exception e)
            {

                MetroSetMessageBox.Show(this, "Error catched : " + e.Message, "Error");
            }
        }

        private string ReadLocalVersion()
        {
            try
            {
                if (File.Exists(file))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        return sr.ReadLine();
                    }
                }

                File.Create(file);
                return string.Empty;
            }
            catch (Exception e)
            {
                MetroSetMessageBox.Show(this, "Error catched : " + e.Message, "Error");
            }
            return string.Empty;
        }
        private void CompareVersions()
        {
            local_ver = ReadLocalVersion();
            ReadVersionFromOnline();

            if (local_ver == online_ver)
            {
                labelMess.Text = $"Version : {local_ver}";
                labelLink.Hide();
            }
            else if (local_ver != online_ver)
            { 
                // Message to use that is a new version
                labelMess.Text = "A new update has been found : " + online_ver;
                labelLink.Show();
                labelLink.LinkClicked += LabelLink_LinkClicked;
            }
        }

        private void LabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(download_url);
        }
        #endregion

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.com/donate?hosted_button_id=PSNGWDTK6FHME";

            System.Diagnostics.Process.Start(url);
        }
    }
}
