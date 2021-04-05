﻿
namespace AmongUsModUpdater
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.homeButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.otherRolesBanner = new System.Windows.Forms.PictureBox();
            this.buttonHomeStart = new CustomButton.CustomButton();
            this.buttoneHomeUpdate = new CustomButton.CustomButton();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonWorkerCancel = new System.Windows.Forms.Button();
            this.labelProcessedDrives = new System.Windows.Forms.Label();
            this.progressBarSearch = new System.Windows.Forms.ProgressBar();
            this.settingsButtonAutomated = new CustomButton.CustomButton();
            this.settingButtonManual = new CustomButton.CustomButton();
            this.labelSettingsHeader = new System.Windows.Forms.Label();
            this.labelSettingsBackup = new System.Windows.Forms.Label();
            this.settingsToggleBackup = new CustomToggle.CustomToggle();
            this.settingsGamePathTextBox = new CustomTextBox.CustomTextBox();
            this.labelSettingsPath = new System.Windows.Forms.Label();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCopyrightHeader = new System.Windows.Forms.Label();
            this.linkLabelResourcesGit = new System.Windows.Forms.LinkLabel();
            this.labelResourcesGit = new System.Windows.Forms.Label();
            this.labelResourcesHeader = new System.Windows.Forms.Label();
            this.labelVersionHeader = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMenuActive = new System.Windows.Forms.Panel();
            this.manualLocationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherRolesBanner)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(0, 60);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(158, 75);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(0, 135);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(158, 75);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(0, 210);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(158, 75);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.otherRolesBanner);
            this.panelHome.Controls.Add(this.buttonHomeStart);
            this.panelHome.Controls.Add(this.buttoneHomeUpdate);
            this.panelHome.Controls.Add(this.downloadProgress);
            this.panelHome.Location = new System.Drawing.Point(172, 60);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(528, 372);
            this.panelHome.TabIndex = 8;
            this.panelHome.Visible = false;
            this.panelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // otherRolesBanner
            // 
            this.otherRolesBanner.Image = ((System.Drawing.Image)(resources.GetObject("otherRolesBanner.Image")));
            this.otherRolesBanner.Location = new System.Drawing.Point(32, 0);
            this.otherRolesBanner.Margin = new System.Windows.Forms.Padding(2);
            this.otherRolesBanner.Name = "otherRolesBanner";
            this.otherRolesBanner.Size = new System.Drawing.Size(470, 77);
            this.otherRolesBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.otherRolesBanner.TabIndex = 7;
            this.otherRolesBanner.TabStop = false;
            this.otherRolesBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.otherRolesBanner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            this.otherRolesBanner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseUp);
            // 
            // buttonHomeStart
            // 
            this.buttonHomeStart.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeStart.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomeStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonHomeStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHomeStart.ForeColor = System.Drawing.Color.White;
            this.buttonHomeStart.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeStart.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeStart.Location = new System.Drawing.Point(176, 103);
            this.buttonHomeStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHomeStart.Name = "buttonHomeStart";
            this.buttonHomeStart.Radius = 10;
            this.buttonHomeStart.Size = new System.Drawing.Size(176, 71);
            this.buttonHomeStart.Stroke = false;
            this.buttonHomeStart.StrokeColor = System.Drawing.Color.Gray;
            this.buttonHomeStart.TabIndex = 6;
            this.buttonHomeStart.Text = "Start";
            this.buttonHomeStart.Transparency = false;
            this.buttonHomeStart.Visible = false;
            this.buttonHomeStart.Click += new System.EventHandler(this.buttonHomeStart_Click);
            // 
            // buttoneHomeUpdate
            // 
            this.buttoneHomeUpdate.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttoneHomeUpdate.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttoneHomeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttoneHomeUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttoneHomeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoneHomeUpdate.ForeColor = System.Drawing.Color.White;
            this.buttoneHomeUpdate.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttoneHomeUpdate.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttoneHomeUpdate.Location = new System.Drawing.Point(176, 102);
            this.buttoneHomeUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttoneHomeUpdate.Name = "buttoneHomeUpdate";
            this.buttoneHomeUpdate.Radius = 10;
            this.buttoneHomeUpdate.Size = new System.Drawing.Size(176, 72);
            this.buttoneHomeUpdate.Stroke = false;
            this.buttoneHomeUpdate.StrokeColor = System.Drawing.Color.Gray;
            this.buttoneHomeUpdate.TabIndex = 5;
            this.buttoneHomeUpdate.Text = "Update";
            this.buttoneHomeUpdate.Transparency = false;
            this.buttoneHomeUpdate.Visible = false;
            this.buttoneHomeUpdate.Click += new System.EventHandler(this.buttoneHomeUpdate_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(69, 190);
            this.downloadProgress.Margin = new System.Windows.Forms.Padding(10);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(398, 23);
            this.downloadProgress.TabIndex = 4;
            this.downloadProgress.Visible = false;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.buttonWorkerCancel);
            this.panelSettings.Controls.Add(this.labelProcessedDrives);
            this.panelSettings.Controls.Add(this.progressBarSearch);
            this.panelSettings.Controls.Add(this.settingsButtonAutomated);
            this.panelSettings.Controls.Add(this.settingButtonManual);
            this.panelSettings.Controls.Add(this.labelSettingsHeader);
            this.panelSettings.Controls.Add(this.labelSettingsBackup);
            this.panelSettings.Controls.Add(this.settingsToggleBackup);
            this.panelSettings.Controls.Add(this.settingsGamePathTextBox);
            this.panelSettings.Controls.Add(this.labelSettingsPath);
            this.panelSettings.Location = new System.Drawing.Point(172, 60);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(528, 372);
            this.panelSettings.TabIndex = 9;
            this.panelSettings.Visible = false;
            this.panelSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // buttonWorkerCancel
            // 
            this.buttonWorkerCancel.FlatAppearance.BorderSize = 0;
            this.buttonWorkerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkerCancel.ForeColor = System.Drawing.Color.Silver;
            this.buttonWorkerCancel.Location = new System.Drawing.Point(386, 226);
            this.buttonWorkerCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWorkerCancel.Name = "buttonWorkerCancel";
            this.buttonWorkerCancel.Size = new System.Drawing.Size(27, 23);
            this.buttonWorkerCancel.TabIndex = 11;
            this.buttonWorkerCancel.Text = "X";
            this.buttonWorkerCancel.UseVisualStyleBackColor = true;
            this.buttonWorkerCancel.Visible = false;
            this.buttonWorkerCancel.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // labelProcessedDrives
            // 
            this.labelProcessedDrives.AutoSize = true;
            this.labelProcessedDrives.Location = new System.Drawing.Point(32, 252);
            this.labelProcessedDrives.Name = "labelProcessedDrives";
            this.labelProcessedDrives.Size = new System.Drawing.Size(95, 15);
            this.labelProcessedDrives.TabIndex = 9;
            this.labelProcessedDrives.Text = "Processed Drives";
            this.labelProcessedDrives.Visible = false;
            // 
            // progressBarSearch
            // 
            this.progressBarSearch.Location = new System.Drawing.Point(32, 226);
            this.progressBarSearch.Name = "progressBarSearch";
            this.progressBarSearch.Size = new System.Drawing.Size(349, 23);
            this.progressBarSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarSearch.TabIndex = 8;
            this.progressBarSearch.Visible = false;
            // 
            // settingsButtonAutomated
            // 
            this.settingsButtonAutomated.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsButtonAutomated.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsButtonAutomated.BackColor = System.Drawing.Color.Transparent;
            this.settingsButtonAutomated.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingsButtonAutomated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButtonAutomated.ForeColor = System.Drawing.Color.White;
            this.settingsButtonAutomated.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsButtonAutomated.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsButtonAutomated.Location = new System.Drawing.Point(214, 109);
            this.settingsButtonAutomated.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButtonAutomated.Name = "settingsButtonAutomated";
            this.settingsButtonAutomated.Radius = 10;
            this.settingsButtonAutomated.Size = new System.Drawing.Size(139, 29);
            this.settingsButtonAutomated.Stroke = false;
            this.settingsButtonAutomated.StrokeColor = System.Drawing.Color.Gray;
            this.settingsButtonAutomated.TabIndex = 7;
            this.settingsButtonAutomated.Text = "Automated search";
            this.settingsButtonAutomated.Transparency = false;
            this.settingsButtonAutomated.Click += new System.EventHandler(this.settingsButtonAutomated_Click);
            // 
            // settingButtonManual
            // 
            this.settingButtonManual.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingButtonManual.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingButtonManual.BackColor = System.Drawing.Color.Transparent;
            this.settingButtonManual.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingButtonManual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingButtonManual.ForeColor = System.Drawing.Color.White;
            this.settingButtonManual.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingButtonManual.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingButtonManual.Location = new System.Drawing.Point(34, 109);
            this.settingButtonManual.Margin = new System.Windows.Forms.Padding(2);
            this.settingButtonManual.Name = "settingButtonManual";
            this.settingButtonManual.Radius = 10;
            this.settingButtonManual.Size = new System.Drawing.Size(139, 29);
            this.settingButtonManual.Stroke = false;
            this.settingButtonManual.StrokeColor = System.Drawing.Color.Gray;
            this.settingButtonManual.TabIndex = 6;
            this.settingButtonManual.Text = "Manual search";
            this.settingButtonManual.Transparency = false;
            this.settingButtonManual.Click += new System.EventHandler(this.settingButtonManual_Click);
            // 
            // labelSettingsHeader
            // 
            this.labelSettingsHeader.AutoSize = true;
            this.labelSettingsHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSettingsHeader.Location = new System.Drawing.Point(32, 28);
            this.labelSettingsHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsHeader.Name = "labelSettingsHeader";
            this.labelSettingsHeader.Size = new System.Drawing.Size(178, 19);
            this.labelSettingsHeader.TabIndex = 5;
            this.labelSettingsHeader.Text = "Among Us Game Settings";
            // 
            // labelSettingsBackup
            // 
            this.labelSettingsBackup.AutoSize = true;
            this.labelSettingsBackup.Location = new System.Drawing.Point(32, 165);
            this.labelSettingsBackup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsBackup.Name = "labelSettingsBackup";
            this.labelSettingsBackup.Size = new System.Drawing.Size(212, 15);
            this.labelSettingsBackup.TabIndex = 4;
            this.labelSettingsBackup.Text = "Should a copy of the game be created?";
            // 
            // settingsToggleBackup
            // 
            this.settingsToggleBackup.BorderColor = System.Drawing.Color.LightGray;
            this.settingsToggleBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsToggleBackup.ForeColor = System.Drawing.Color.White;
            this.settingsToggleBackup.IsOn = false;
            this.settingsToggleBackup.Location = new System.Drawing.Point(32, 190);
            this.settingsToggleBackup.Margin = new System.Windows.Forms.Padding(2);
            this.settingsToggleBackup.Name = "settingsToggleBackup";
            this.settingsToggleBackup.OffColor = System.Drawing.Color.DarkGray;
            this.settingsToggleBackup.OffText = "";
            this.settingsToggleBackup.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsToggleBackup.OnText = "";
            this.settingsToggleBackup.Size = new System.Drawing.Size(34, 19);
            this.settingsToggleBackup.TabIndex = 3;
            this.settingsToggleBackup.Text = "customToggle1";
            this.settingsToggleBackup.TextEnabled = true;
            this.settingsToggleBackup.Click += new System.EventHandler(this.settingsToggleBackup_Click);
            // 
            // settingsGamePathTextBox
            // 
            this.settingsGamePathTextBox.BackColor = System.Drawing.Color.Transparent;
            this.settingsGamePathTextBox.Br = System.Drawing.Color.White;
            this.settingsGamePathTextBox.Enabled = false;
            this.settingsGamePathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsGamePathTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.settingsGamePathTextBox.Location = new System.Drawing.Point(32, 69);
            this.settingsGamePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsGamePathTextBox.Name = "settingsGamePathTextBox";
            this.settingsGamePathTextBox.Size = new System.Drawing.Size(321, 30);
            this.settingsGamePathTextBox.TabIndex = 2;
            this.settingsGamePathTextBox.TextChanged += new System.EventHandler(this.settingsGamePathTextBox_TextChanged);
            // 
            // labelSettingsPath
            // 
            this.labelSettingsPath.AutoSize = true;
            this.labelSettingsPath.Location = new System.Drawing.Point(32, 52);
            this.labelSettingsPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsPath.Name = "labelSettingsPath";
            this.labelSettingsPath.Size = new System.Drawing.Size(305, 15);
            this.labelSettingsPath.TabIndex = 1;
            this.labelSettingsPath.Text = "Please specify the folder where Among Us.exe is located.";
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.labelCopyright);
            this.panelHelp.Controls.Add(this.labelCopyrightHeader);
            this.panelHelp.Controls.Add(this.linkLabelResourcesGit);
            this.panelHelp.Controls.Add(this.labelResourcesGit);
            this.panelHelp.Controls.Add(this.labelResourcesHeader);
            this.panelHelp.Controls.Add(this.labelVersionHeader);
            this.panelHelp.Controls.Add(this.labelVersion);
            this.panelHelp.Location = new System.Drawing.Point(172, 60);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(528, 372);
            this.panelHelp.TabIndex = 10;
            this.panelHelp.Visible = false;
            this.panelHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.Silver;
            this.labelCopyright.Location = new System.Drawing.Point(32, 150);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(78, 15);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Jolle && Narua";
            // 
            // labelCopyrightHeader
            // 
            this.labelCopyrightHeader.AutoSize = true;
            this.labelCopyrightHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCopyrightHeader.Location = new System.Drawing.Point(32, 133);
            this.labelCopyrightHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopyrightHeader.Name = "labelCopyrightHeader";
            this.labelCopyrightHeader.Size = new System.Drawing.Size(76, 19);
            this.labelCopyrightHeader.TabIndex = 5;
            this.labelCopyrightHeader.Text = "Copyright";
            // 
            // linkLabelResourcesGit
            // 
            this.linkLabelResourcesGit.AutoSize = true;
            this.linkLabelResourcesGit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelResourcesGit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelResourcesGit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.linkLabelResourcesGit.Location = new System.Drawing.Point(84, 92);
            this.linkLabelResourcesGit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelResourcesGit.Name = "linkLabelResourcesGit";
            this.linkLabelResourcesGit.Size = new System.Drawing.Size(295, 15);
            this.linkLabelResourcesGit.TabIndex = 4;
            this.linkLabelResourcesGit.TabStop = true;
            this.linkLabelResourcesGit.Text = "https://github.com/Narua2010/AmongUsModUpdater";
            this.linkLabelResourcesGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResourcesGit_LinkClicked);
            this.linkLabelResourcesGit.MouseEnter += new System.EventHandler(this.linkLabelResourcesGit_MouseEnter);
            this.linkLabelResourcesGit.MouseLeave += new System.EventHandler(this.linkLabelResourcesGit_MouseLeave);
            // 
            // labelResourcesGit
            // 
            this.labelResourcesGit.AutoSize = true;
            this.labelResourcesGit.ForeColor = System.Drawing.Color.Silver;
            this.labelResourcesGit.Location = new System.Drawing.Point(32, 92);
            this.labelResourcesGit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResourcesGit.Name = "labelResourcesGit";
            this.labelResourcesGit.Size = new System.Drawing.Size(46, 15);
            this.labelResourcesGit.TabIndex = 3;
            this.labelResourcesGit.Text = "Github:";
            // 
            // labelResourcesHeader
            // 
            this.labelResourcesHeader.AutoSize = true;
            this.labelResourcesHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResourcesHeader.Location = new System.Drawing.Point(32, 75);
            this.labelResourcesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResourcesHeader.Name = "labelResourcesHeader";
            this.labelResourcesHeader.Size = new System.Drawing.Size(76, 19);
            this.labelResourcesHeader.TabIndex = 2;
            this.labelResourcesHeader.Text = "Resources";
            // 
            // labelVersionHeader
            // 
            this.labelVersionHeader.AutoSize = true;
            this.labelVersionHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersionHeader.Location = new System.Drawing.Point(32, 20);
            this.labelVersionHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersionHeader.Name = "labelVersionHeader";
            this.labelVersionHeader.Size = new System.Drawing.Size(141, 19);
            this.labelVersionHeader.TabIndex = 1;
            this.labelVersionHeader.Text = "Version Information";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Silver;
            this.labelVersion.Location = new System.Drawing.Point(32, 37);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(216, 15);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Among Us Mod Updater Version: 0.0.0.0";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.settingsButton);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Controls.Add(this.helpButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(158, 332);
            this.panelMenu.TabIndex = 9;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(158, 60);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(47, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(68, 60);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(158, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(542, 60);
            this.panelTop.TabIndex = 10;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Silver;
            this.buttonExit.Location = new System.Drawing.Point(507, 7);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMenuActive
            // 
            this.panelMenuActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.panelMenuActive.Location = new System.Drawing.Point(158, 60);
            this.panelMenuActive.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuActive.Name = "panelMenuActive";
            this.panelMenuActive.Size = new System.Drawing.Size(7, 75);
            this.panelMenuActive.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 332);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelMenuActive);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelHelp);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Among Us Mod Updater";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otherRolesBanner)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelMenuActive;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVersionHeader;
        private System.Windows.Forms.LinkLabel linkLabelResourcesGit;
        private System.Windows.Forms.Label labelResourcesGit;
        private System.Windows.Forms.Label labelResourcesHeader;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCopyrightHeader;
        private System.Windows.Forms.Label labelSettingsPath;
        private CustomTextBox.CustomTextBox settingsGamePathTextBox;
        private CustomToggle.CustomToggle settingsToggleBackup;
        private System.Windows.Forms.Label labelSettingsBackup;
        private System.Windows.Forms.Label labelSettingsHeader;
        private CustomButton.CustomButton settingButtonManual;
        private CustomButton.CustomButton settingsButtonAutomated;
        private System.Windows.Forms.FolderBrowserDialog manualLocationFolderDialog;
        private CustomButton.CustomButton buttonHomeStart;
        private CustomButton.CustomButton buttoneHomeUpdate;
        private System.Windows.Forms.PictureBox otherRolesBanner;
        private System.Windows.Forms.Label labelProcessedDrives;
        private System.Windows.Forms.ProgressBar progressBarSearch;
        private System.Windows.Forms.Button buttonWorkerCancel;
    }
}

