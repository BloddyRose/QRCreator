﻿
namespace QRCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.styleManager = new MetroSet_UI.Components.StyleManager();
            this.ExitBox = new MetroSet_UI.Controls.MetroSetControlBox();
            this.PageControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.TextPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.boxSaveText = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.pictureBoxText = new System.Windows.Forms.PictureBox();
            this.btnGenerateText = new MetroSet_UI.Controls.MetroSetButton();
            this.inputBoxText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.WIFIPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pictureBoxWifi = new System.Windows.Forms.PictureBox();
            this.boxSaveWifi = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.btnGenerateWifi = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.WifiAuths = new MetroSet_UI.Controls.MetroSetComboBox();
            this.passwordWifi = new MetroSet_UI.Controls.MetroSetTextBox();
            this.nameboxWifi = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.UrlPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pictureBoxUrl = new System.Windows.Forms.PictureBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.inputUrl = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnUrlGenerate = new MetroSet_UI.Controls.MetroSetButton();
            this.PageControl.SuspendLayout();
            this.TextPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxText)).BeginInit();
            this.WIFIPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWifi)).BeginInit();
            this.UrlPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.CustomTheme = "C:\\Users\\Administrator\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager.MetroForm = this;
            this.styleManager.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager.ThemeAuthor = "Narwin";
            this.styleManager.ThemeName = "MetroDark";
            // 
            // ExitBox
            // 
            this.ExitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBox.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExitBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.ExitBox.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.ExitBox.DisabledForeColor = System.Drawing.Color.Silver;
            this.ExitBox.IsDerivedStyle = true;
            this.ExitBox.Location = new System.Drawing.Point(724, -2);
            this.ExitBox.MaximizeBox = false;
            this.ExitBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ExitBox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.ExitBox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.ExitBox.MinimizeBox = true;
            this.ExitBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ExitBox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.ExitBox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(100, 25);
            this.ExitBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.ExitBox.StyleManager = this.styleManager;
            this.ExitBox.TabIndex = 0;
            this.ExitBox.Text = "metroSetControlBox1";
            this.ExitBox.ThemeAuthor = "Narwin";
            this.ExitBox.ThemeName = "MetroDark";
            // 
            // PageControl
            // 
            this.PageControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.PageControl.AnimateTime = 200;
            this.PageControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PageControl.Controls.Add(this.TextPage);
            this.PageControl.Controls.Add(this.WIFIPage);
            this.PageControl.Controls.Add(this.UrlPage);
            this.PageControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageControl.IsDerivedStyle = true;
            this.PageControl.ItemSize = new System.Drawing.Size(100, 38);
            this.PageControl.Location = new System.Drawing.Point(15, 73);
            this.PageControl.Name = "PageControl";
            this.PageControl.SelectedIndex = 2;
            this.PageControl.SelectedTextColor = System.Drawing.Color.White;
            this.PageControl.Size = new System.Drawing.Size(809, 426);
            this.PageControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PageControl.Speed = 100;
            this.PageControl.Style = MetroSet_UI.Enums.Style.Dark;
            this.PageControl.StyleManager = this.styleManager;
            this.PageControl.TabIndex = 1;
            this.PageControl.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.PageControl.ThemeAuthor = "Narwin";
            this.PageControl.ThemeName = "MetroDark";
            this.PageControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.PageControl.UseAnimation = false;
            // 
            // TextPage
            // 
            this.TextPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextPage.Controls.Add(this.metroSetLabel1);
            this.TextPage.Controls.Add(this.boxSaveText);
            this.TextPage.Controls.Add(this.pictureBoxText);
            this.TextPage.Controls.Add(this.btnGenerateText);
            this.TextPage.Controls.Add(this.inputBoxText);
            this.TextPage.Font = null;
            this.TextPage.ImageIndex = 0;
            this.TextPage.ImageKey = null;
            this.TextPage.IsDerivedStyle = true;
            this.TextPage.Location = new System.Drawing.Point(4, 42);
            this.TextPage.Name = "TextPage";
            this.TextPage.Size = new System.Drawing.Size(801, 380);
            this.TextPage.Style = MetroSet_UI.Enums.Style.Dark;
            this.TextPage.StyleManager = this.styleManager;
            this.TextPage.TabIndex = 0;
            this.TextPage.Text = "Text";
            this.TextPage.ThemeAuthor = "Narwin";
            this.TextPage.ThemeName = "MetroDark";
            this.TextPage.ToolTipText = null;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(786, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 4;
            this.metroSetLabel1.Text = "Type here the text you want and press generate (check the box to save image)";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // boxSaveText
            // 
            this.boxSaveText.BackColor = System.Drawing.Color.Transparent;
            this.boxSaveText.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.boxSaveText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.boxSaveText.Checked = false;
            this.boxSaveText.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.boxSaveText.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.boxSaveText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxSaveText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.boxSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxSaveText.IsDerivedStyle = true;
            this.boxSaveText.Location = new System.Drawing.Point(599, 182);
            this.boxSaveText.Name = "boxSaveText";
            this.boxSaveText.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.boxSaveText.Size = new System.Drawing.Size(109, 16);
            this.boxSaveText.Style = MetroSet_UI.Enums.Style.Dark;
            this.boxSaveText.StyleManager = null;
            this.boxSaveText.TabIndex = 3;
            this.boxSaveText.Text = "Save image";
            this.boxSaveText.ThemeAuthor = "Narwin";
            this.boxSaveText.ThemeName = "MetroDark";
            this.boxSaveText.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.boxSaveText_CheckedChanged);
            // 
            // pictureBoxText
            // 
            this.pictureBoxText.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxText.Location = new System.Drawing.Point(3, 175);
            this.pictureBoxText.Name = "pictureBoxText";
            this.pictureBoxText.Size = new System.Drawing.Size(286, 205);
            this.pictureBoxText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxText.TabIndex = 2;
            this.pictureBoxText.TabStop = false;
            // 
            // btnGenerateText
            // 
            this.btnGenerateText.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateText.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnGenerateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGenerateText.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnGenerateText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnGenerateText.HoverTextColor = System.Drawing.Color.White;
            this.btnGenerateText.IsDerivedStyle = true;
            this.btnGenerateText.Location = new System.Drawing.Point(714, 175);
            this.btnGenerateText.Name = "btnGenerateText";
            this.btnGenerateText.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateText.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateText.NormalTextColor = System.Drawing.Color.White;
            this.btnGenerateText.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnGenerateText.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnGenerateText.PressTextColor = System.Drawing.Color.White;
            this.btnGenerateText.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateText.Style = MetroSet_UI.Enums.Style.Dark;
            this.btnGenerateText.StyleManager = null;
            this.btnGenerateText.TabIndex = 1;
            this.btnGenerateText.Text = "Generate";
            this.btnGenerateText.ThemeAuthor = "Narwin";
            this.btnGenerateText.ThemeName = "MetroDark";
            this.btnGenerateText.Click += new System.EventHandler(this.btnGenerateText_Click);
            // 
            // inputBoxText
            // 
            this.inputBoxText.AutoCompleteCustomSource = null;
            this.inputBoxText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputBoxText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputBoxText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.inputBoxText.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.inputBoxText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputBoxText.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputBoxText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.inputBoxText.Image = null;
            this.inputBoxText.IsDerivedStyle = true;
            this.inputBoxText.Lines = null;
            this.inputBoxText.Location = new System.Drawing.Point(3, 39);
            this.inputBoxText.MaxLength = 32767;
            this.inputBoxText.Multiline = true;
            this.inputBoxText.Name = "inputBoxText";
            this.inputBoxText.ReadOnly = false;
            this.inputBoxText.Size = new System.Drawing.Size(786, 130);
            this.inputBoxText.Style = MetroSet_UI.Enums.Style.Dark;
            this.inputBoxText.StyleManager = null;
            this.inputBoxText.TabIndex = 0;
            this.inputBoxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputBoxText.ThemeAuthor = "Narwin";
            this.inputBoxText.ThemeName = "MetroDark";
            this.inputBoxText.UseSystemPasswordChar = false;
            this.inputBoxText.WatermarkText = "";
            // 
            // WIFIPage
            // 
            this.WIFIPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.WIFIPage.Controls.Add(this.pictureBoxWifi);
            this.WIFIPage.Controls.Add(this.boxSaveWifi);
            this.WIFIPage.Controls.Add(this.btnGenerateWifi);
            this.WIFIPage.Controls.Add(this.metroSetLabel4);
            this.WIFIPage.Controls.Add(this.WifiAuths);
            this.WIFIPage.Controls.Add(this.passwordWifi);
            this.WIFIPage.Controls.Add(this.nameboxWifi);
            this.WIFIPage.Controls.Add(this.metroSetLabel3);
            this.WIFIPage.Controls.Add(this.metroSetLabel2);
            this.WIFIPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.WIFIPage.Font = null;
            this.WIFIPage.ImageIndex = 0;
            this.WIFIPage.ImageKey = null;
            this.WIFIPage.IsDerivedStyle = true;
            this.WIFIPage.Location = new System.Drawing.Point(4, 42);
            this.WIFIPage.Name = "WIFIPage";
            this.WIFIPage.Size = new System.Drawing.Size(801, 380);
            this.WIFIPage.Style = MetroSet_UI.Enums.Style.Dark;
            this.WIFIPage.StyleManager = this.styleManager;
            this.WIFIPage.TabIndex = 1;
            this.WIFIPage.Text = "Wifi QR Code";
            this.WIFIPage.ThemeAuthor = "Narwin";
            this.WIFIPage.ThemeName = "MetroDark";
            this.WIFIPage.ToolTipText = null;
            // 
            // pictureBoxWifi
            // 
            this.pictureBoxWifi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWifi.Location = new System.Drawing.Point(3, 194);
            this.pictureBoxWifi.Name = "pictureBoxWifi";
            this.pictureBoxWifi.Size = new System.Drawing.Size(219, 178);
            this.pictureBoxWifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWifi.TabIndex = 8;
            this.pictureBoxWifi.TabStop = false;
            // 
            // boxSaveWifi
            // 
            this.boxSaveWifi.BackColor = System.Drawing.Color.Transparent;
            this.boxSaveWifi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.boxSaveWifi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.boxSaveWifi.Checked = false;
            this.boxSaveWifi.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.boxSaveWifi.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.boxSaveWifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxSaveWifi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.boxSaveWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxSaveWifi.IsDerivedStyle = true;
            this.boxSaveWifi.Location = new System.Drawing.Point(283, 172);
            this.boxSaveWifi.Name = "boxSaveWifi";
            this.boxSaveWifi.SignStyle = MetroSet_UI.Enums.SignStyle.Shape;
            this.boxSaveWifi.Size = new System.Drawing.Size(110, 16);
            this.boxSaveWifi.Style = MetroSet_UI.Enums.Style.Dark;
            this.boxSaveWifi.StyleManager = null;
            this.boxSaveWifi.TabIndex = 7;
            this.boxSaveWifi.Text = "Save image";
            this.boxSaveWifi.ThemeAuthor = "Narwin";
            this.boxSaveWifi.ThemeName = "MetroDark";
            this.boxSaveWifi.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.boxSaveWifi_CheckedChanged);
            // 
            // btnGenerateWifi
            // 
            this.btnGenerateWifi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateWifi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateWifi.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnGenerateWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGenerateWifi.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnGenerateWifi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnGenerateWifi.HoverTextColor = System.Drawing.Color.White;
            this.btnGenerateWifi.IsDerivedStyle = true;
            this.btnGenerateWifi.Location = new System.Drawing.Point(714, 165);
            this.btnGenerateWifi.Name = "btnGenerateWifi";
            this.btnGenerateWifi.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateWifi.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGenerateWifi.NormalTextColor = System.Drawing.Color.White;
            this.btnGenerateWifi.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnGenerateWifi.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnGenerateWifi.PressTextColor = System.Drawing.Color.White;
            this.btnGenerateWifi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateWifi.Style = MetroSet_UI.Enums.Style.Light;
            this.btnGenerateWifi.StyleManager = null;
            this.btnGenerateWifi.TabIndex = 6;
            this.btnGenerateWifi.Text = "Generate";
            this.btnGenerateWifi.ThemeAuthor = "Narwin";
            this.btnGenerateWifi.ThemeName = "MetroLite";
            this.btnGenerateWifi.Click += new System.EventHandler(this.btnGenerateWifi_Click);
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(3, 136);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(219, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 5;
            this.metroSetLabel4.Text = "Select authentication type";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // WifiAuths
            // 
            this.WifiAuths.AllowDrop = true;
            this.WifiAuths.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.WifiAuths.BackColor = System.Drawing.Color.Transparent;
            this.WifiAuths.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.WifiAuths.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.WifiAuths.CausesValidation = false;
            this.WifiAuths.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.WifiAuths.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WifiAuths.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WifiAuths.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.WifiAuths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WifiAuths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WifiAuths.FormattingEnabled = true;
            this.WifiAuths.IsDerivedStyle = true;
            this.WifiAuths.ItemHeight = 20;
            this.WifiAuths.Location = new System.Drawing.Point(3, 162);
            this.WifiAuths.Name = "WifiAuths";
            this.WifiAuths.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.WifiAuths.SelectedItemForeColor = System.Drawing.Color.White;
            this.WifiAuths.Size = new System.Drawing.Size(121, 26);
            this.WifiAuths.Style = MetroSet_UI.Enums.Style.Dark;
            this.WifiAuths.StyleManager = null;
            this.WifiAuths.TabIndex = 4;
            this.WifiAuths.ThemeAuthor = "Narwin";
            this.WifiAuths.ThemeName = "MetroDark";
            this.WifiAuths.SelectedIndexChanged += new System.EventHandler(this.metroSetComboBox1_SelectedIndexChanged);
            // 
            // passwordWifi
            // 
            this.passwordWifi.AutoCompleteCustomSource = null;
            this.passwordWifi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordWifi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordWifi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordWifi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordWifi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordWifi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordWifi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.passwordWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordWifi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.passwordWifi.Image = null;
            this.passwordWifi.IsDerivedStyle = true;
            this.passwordWifi.Lines = null;
            this.passwordWifi.Location = new System.Drawing.Point(3, 103);
            this.passwordWifi.MaxLength = 32767;
            this.passwordWifi.Multiline = false;
            this.passwordWifi.Name = "passwordWifi";
            this.passwordWifi.ReadOnly = false;
            this.passwordWifi.Size = new System.Drawing.Size(786, 30);
            this.passwordWifi.Style = MetroSet_UI.Enums.Style.Light;
            this.passwordWifi.StyleManager = null;
            this.passwordWifi.TabIndex = 3;
            this.passwordWifi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordWifi.ThemeAuthor = "Narwin";
            this.passwordWifi.ThemeName = "MetroLite";
            this.passwordWifi.UseSystemPasswordChar = false;
            this.passwordWifi.WatermarkText = "";
            // 
            // nameboxWifi
            // 
            this.nameboxWifi.AutoCompleteCustomSource = null;
            this.nameboxWifi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameboxWifi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameboxWifi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.nameboxWifi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameboxWifi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nameboxWifi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.nameboxWifi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.nameboxWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameboxWifi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.nameboxWifi.Image = null;
            this.nameboxWifi.IsDerivedStyle = true;
            this.nameboxWifi.Lines = null;
            this.nameboxWifi.Location = new System.Drawing.Point(3, 35);
            this.nameboxWifi.MaxLength = 32767;
            this.nameboxWifi.Multiline = false;
            this.nameboxWifi.Name = "nameboxWifi";
            this.nameboxWifi.ReadOnly = false;
            this.nameboxWifi.Size = new System.Drawing.Size(786, 30);
            this.nameboxWifi.Style = MetroSet_UI.Enums.Style.Light;
            this.nameboxWifi.StyleManager = null;
            this.nameboxWifi.TabIndex = 2;
            this.nameboxWifi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameboxWifi.ThemeAuthor = "Narwin";
            this.nameboxWifi.ThemeName = "MetroLite";
            this.nameboxWifi.UseSystemPasswordChar = false;
            this.nameboxWifi.WatermarkText = "";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(3, 77);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(219, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 1;
            this.metroSetLabel3.Text = "Enter your password here:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(3, 9);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(219, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 0;
            this.metroSetLabel2.Text = "Enter your wi-fi name here:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // UrlPage
            // 
            this.UrlPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UrlPage.Controls.Add(this.pictureBoxUrl);
            this.UrlPage.Controls.Add(this.metroSetLabel5);
            this.UrlPage.Controls.Add(this.inputUrl);
            this.UrlPage.Controls.Add(this.btnUrlGenerate);
            this.UrlPage.Font = null;
            this.UrlPage.ImageIndex = 0;
            this.UrlPage.ImageKey = null;
            this.UrlPage.IsDerivedStyle = true;
            this.UrlPage.Location = new System.Drawing.Point(4, 42);
            this.UrlPage.Name = "UrlPage";
            this.UrlPage.Size = new System.Drawing.Size(801, 380);
            this.UrlPage.Style = MetroSet_UI.Enums.Style.Dark;
            this.UrlPage.StyleManager = null;
            this.UrlPage.TabIndex = 2;
            this.UrlPage.Text = "URL";
            this.UrlPage.ThemeAuthor = "Narwin";
            this.UrlPage.ThemeName = "MetroDark";
            this.UrlPage.ToolTipText = null;
            // 
            // pictureBoxUrl
            // 
            this.pictureBoxUrl.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUrl.Location = new System.Drawing.Point(3, 98);
            this.pictureBoxUrl.Name = "pictureBoxUrl";
            this.pictureBoxUrl.Size = new System.Drawing.Size(315, 274);
            this.pictureBoxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUrl.TabIndex = 3;
            this.pictureBoxUrl.TabStop = false;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(3, 7);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(233, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 2;
            this.metroSetLabel5.Text = "Enter here your link you want";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // inputUrl
            // 
            this.inputUrl.AutoCompleteCustomSource = null;
            this.inputUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.inputUrl.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputUrl.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.inputUrl.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.inputUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputUrl.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.inputUrl.Image = null;
            this.inputUrl.IsDerivedStyle = true;
            this.inputUrl.Lines = null;
            this.inputUrl.Location = new System.Drawing.Point(-4, 33);
            this.inputUrl.MaxLength = 32767;
            this.inputUrl.Multiline = false;
            this.inputUrl.Name = "inputUrl";
            this.inputUrl.ReadOnly = false;
            this.inputUrl.Size = new System.Drawing.Size(786, 30);
            this.inputUrl.Style = MetroSet_UI.Enums.Style.Light;
            this.inputUrl.StyleManager = null;
            this.inputUrl.TabIndex = 1;
            this.inputUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputUrl.ThemeAuthor = "Narwin";
            this.inputUrl.ThemeName = "MetroLite";
            this.inputUrl.UseSystemPasswordChar = false;
            this.inputUrl.WatermarkText = "";
            // 
            // btnUrlGenerate
            // 
            this.btnUrlGenerate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUrlGenerate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUrlGenerate.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnUrlGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUrlGenerate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnUrlGenerate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnUrlGenerate.HoverTextColor = System.Drawing.Color.White;
            this.btnUrlGenerate.IsDerivedStyle = true;
            this.btnUrlGenerate.Location = new System.Drawing.Point(705, 69);
            this.btnUrlGenerate.Name = "btnUrlGenerate";
            this.btnUrlGenerate.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUrlGenerate.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUrlGenerate.NormalTextColor = System.Drawing.Color.White;
            this.btnUrlGenerate.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnUrlGenerate.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnUrlGenerate.PressTextColor = System.Drawing.Color.White;
            this.btnUrlGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnUrlGenerate.Style = MetroSet_UI.Enums.Style.Light;
            this.btnUrlGenerate.StyleManager = null;
            this.btnUrlGenerate.TabIndex = 0;
            this.btnUrlGenerate.Text = "Generate";
            this.btnUrlGenerate.ThemeAuthor = "Narwin";
            this.btnUrlGenerate.ThemeName = "MetroLite";
            this.btnUrlGenerate.Click += new System.EventHandler(this.btnUrlGenerate_Click);
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(823, 502);
            this.Controls.Add(this.PageControl);
            this.Controls.Add(this.ExitBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(823, 502);
            this.MinimumSize = new System.Drawing.Size(823, 502);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager;
            this.Text = "QR Creator";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PageControl.ResumeLayout(false);
            this.TextPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxText)).EndInit();
            this.WIFIPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWifi)).EndInit();
            this.UrlPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Components.StyleManager styleManager;
        private MetroSet_UI.Controls.MetroSetTabControl PageControl;
        private MetroSet_UI.Child.MetroSetSetTabPage TextPage;
        private MetroSet_UI.Child.MetroSetSetTabPage WIFIPage;
        private MetroSet_UI.Controls.MetroSetControlBox ExitBox;
        private System.Windows.Forms.PictureBox pictureBoxText;
        private MetroSet_UI.Controls.MetroSetButton btnGenerateText;
        private MetroSet_UI.Controls.MetroSetTextBox inputBoxText;
        private MetroSet_UI.Controls.MetroSetCheckBox boxSaveText;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox passwordWifi;
        private MetroSet_UI.Controls.MetroSetTextBox nameboxWifi;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetComboBox WifiAuths;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetCheckBox boxSaveWifi;
        private MetroSet_UI.Controls.MetroSetButton btnGenerateWifi;
        private System.Windows.Forms.PictureBox pictureBoxWifi;
        private MetroSet_UI.Child.MetroSetSetTabPage UrlPage;
        private System.Windows.Forms.PictureBox pictureBoxUrl;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetTextBox inputUrl;
        private MetroSet_UI.Controls.MetroSetButton btnUrlGenerate;
    }
}