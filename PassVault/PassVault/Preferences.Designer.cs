namespace PassVault
{
    partial class preferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preferencesForm));
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.dbConnectButton = new System.Windows.Forms.Button();
            this.dbPassInput = new System.Windows.Forms.MaskedTextBox();
            this.dbUserInput = new System.Windows.Forms.TextBox();
            this.dbHostInput = new System.Windows.Forms.TextBox();
            this.stayConnectedCheckbox = new System.Windows.Forms.CheckBox();
            this.dbHost = new System.Windows.Forms.Label();
            this.dbPass = new System.Windows.Forms.Label();
            this.dbUser = new System.Windows.Forms.Label();
            this.preferencesExitButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.generalSettingsGroup = new System.Windows.Forms.GroupBox();
            this.updateStorageModeButton = new System.Windows.Forms.Button();
            this.offlineStorageRadiobutton = new System.Windows.Forms.RadioButton();
            this.onlineStorageRadiobutton = new System.Windows.Forms.RadioButton();
            this.prefConnectionPanel = new System.Windows.Forms.Panel();
            this.prefAccountPanel = new System.Windows.Forms.Panel();
            this.passvaultAccountSettingsGroup = new System.Windows.Forms.GroupBox();
            this.confirmPasswordButton = new System.Windows.Forms.Button();
            this.editAccountInfoPasswordInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editAccountInfoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prefDeleteAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prefGeneralPanel = new System.Windows.Forms.Panel();
            this.connectionGroup.SuspendLayout();
            this.generalSettingsGroup.SuspendLayout();
            this.prefConnectionPanel.SuspendLayout();
            this.prefAccountPanel.SuspendLayout();
            this.passvaultAccountSettingsGroup.SuspendLayout();
            this.prefGeneralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.dbConnectButton);
            this.connectionGroup.Controls.Add(this.dbPassInput);
            this.connectionGroup.Controls.Add(this.dbUserInput);
            this.connectionGroup.Controls.Add(this.dbHostInput);
            this.connectionGroup.Controls.Add(this.stayConnectedCheckbox);
            this.connectionGroup.Controls.Add(this.dbHost);
            this.connectionGroup.Controls.Add(this.dbPass);
            this.connectionGroup.Controls.Add(this.dbUser);
            this.connectionGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroup.Location = new System.Drawing.Point(2, 3);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Size = new System.Drawing.Size(337, 167);
            this.connectionGroup.TabIndex = 0;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Database Login Info";
            // 
            // dbConnectButton
            // 
            this.dbConnectButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.dbConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbConnectButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbConnectButton.Location = new System.Drawing.Point(218, 118);
            this.dbConnectButton.Name = "dbConnectButton";
            this.dbConnectButton.Size = new System.Drawing.Size(100, 32);
            this.dbConnectButton.TabIndex = 7;
            this.dbConnectButton.Text = "Connect";
            this.dbConnectButton.UseVisualStyleBackColor = true;
            this.dbConnectButton.Click += new System.EventHandler(this.dbConnectButton_Click);
            // 
            // dbPassInput
            // 
            this.dbPassInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dbPassInput.Location = new System.Drawing.Point(157, 81);
            this.dbPassInput.Name = "dbPassInput";
            this.dbPassInput.PasswordChar = '*';
            this.dbPassInput.Size = new System.Drawing.Size(161, 25);
            this.dbPassInput.TabIndex = 6;
            // 
            // dbUserInput
            // 
            this.dbUserInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dbUserInput.Location = new System.Drawing.Point(157, 54);
            this.dbUserInput.Name = "dbUserInput";
            this.dbUserInput.Size = new System.Drawing.Size(161, 25);
            this.dbUserInput.TabIndex = 5;
            // 
            // dbHostInput
            // 
            this.dbHostInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dbHostInput.Location = new System.Drawing.Point(157, 27);
            this.dbHostInput.Name = "dbHostInput";
            this.dbHostInput.Size = new System.Drawing.Size(161, 25);
            this.dbHostInput.TabIndex = 4;
            // 
            // stayConnectedCheckbox
            // 
            this.stayConnectedCheckbox.AutoSize = true;
            this.stayConnectedCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayConnectedCheckbox.Location = new System.Drawing.Point(21, 128);
            this.stayConnectedCheckbox.Name = "stayConnectedCheckbox";
            this.stayConnectedCheckbox.Size = new System.Drawing.Size(106, 17);
            this.stayConnectedCheckbox.TabIndex = 3;
            this.stayConnectedCheckbox.Text = "Stay Connected";
            this.stayConnectedCheckbox.UseVisualStyleBackColor = true;
            this.stayConnectedCheckbox.CheckedChanged += new System.EventHandler(this.stayConnectedCheckbox_CheckedChanged);
            // 
            // dbHost
            // 
            this.dbHost.AutoSize = true;
            this.dbHost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbHost.Location = new System.Drawing.Point(17, 33);
            this.dbHost.Name = "dbHost";
            this.dbHost.Size = new System.Drawing.Size(49, 13);
            this.dbHost.TabIndex = 2;
            this.dbHost.Text = "DB Host";
            // 
            // dbPass
            // 
            this.dbPass.AutoSize = true;
            this.dbPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPass.Location = new System.Drawing.Point(17, 87);
            this.dbPass.Name = "dbPass";
            this.dbPass.Size = new System.Drawing.Size(74, 13);
            this.dbPass.TabIndex = 1;
            this.dbPass.Text = "DB Password";
            // 
            // dbUser
            // 
            this.dbUser.AutoSize = true;
            this.dbUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbUser.Location = new System.Drawing.Point(17, 60);
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(76, 13);
            this.dbUser.TabIndex = 0;
            this.dbUser.Text = "DB Username";
            // 
            // preferencesExitButton
            // 
            this.preferencesExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.preferencesExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preferencesExitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesExitButton.Location = new System.Drawing.Point(405, 328);
            this.preferencesExitButton.Name = "preferencesExitButton";
            this.preferencesExitButton.Size = new System.Drawing.Size(100, 32);
            this.preferencesExitButton.TabIndex = 2;
            this.preferencesExitButton.Text = "Exit";
            this.preferencesExitButton.UseVisualStyleBackColor = true;
            this.preferencesExitButton.Click += new System.EventHandler(this.preferencesExitButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "General",
            "Account",
            "Connection"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.MaximumSize = new System.Drawing.Size(147, 360);
            this.listBox1.MinimumSize = new System.Drawing.Size(147, 342);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 342);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // generalSettingsGroup
            // 
            this.generalSettingsGroup.Controls.Add(this.updateStorageModeButton);
            this.generalSettingsGroup.Controls.Add(this.offlineStorageRadiobutton);
            this.generalSettingsGroup.Controls.Add(this.onlineStorageRadiobutton);
            this.generalSettingsGroup.Location = new System.Drawing.Point(2, 3);
            this.generalSettingsGroup.Name = "generalSettingsGroup";
            this.generalSettingsGroup.Size = new System.Drawing.Size(337, 100);
            this.generalSettingsGroup.TabIndex = 4;
            this.generalSettingsGroup.TabStop = false;
            this.generalSettingsGroup.Text = "Storage Mode";
            // 
            // updateStorageModeButton
            // 
            this.updateStorageModeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.updateStorageModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStorageModeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStorageModeButton.Location = new System.Drawing.Point(254, 18);
            this.updateStorageModeButton.Name = "updateStorageModeButton";
            this.updateStorageModeButton.Size = new System.Drawing.Size(65, 65);
            this.updateStorageModeButton.TabIndex = 3;
            this.updateStorageModeButton.Text = "Update";
            this.updateStorageModeButton.UseVisualStyleBackColor = true;
            this.updateStorageModeButton.Click += new System.EventHandler(this.updateStorageModeButton_Click);
            // 
            // offlineStorageRadiobutton
            // 
            this.offlineStorageRadiobutton.AutoSize = true;
            this.offlineStorageRadiobutton.Checked = true;
            this.offlineStorageRadiobutton.Location = new System.Drawing.Point(28, 28);
            this.offlineStorageRadiobutton.Name = "offlineStorageRadiobutton";
            this.offlineStorageRadiobutton.Size = new System.Drawing.Size(137, 17);
            this.offlineStorageRadiobutton.TabIndex = 1;
            this.offlineStorageRadiobutton.TabStop = true;
            this.offlineStorageRadiobutton.Text = "Offline Storage Mode";
            this.offlineStorageRadiobutton.UseVisualStyleBackColor = true;
            // 
            // onlineStorageRadiobutton
            // 
            this.onlineStorageRadiobutton.AutoSize = true;
            this.onlineStorageRadiobutton.Enabled = false;
            this.onlineStorageRadiobutton.Location = new System.Drawing.Point(28, 55);
            this.onlineStorageRadiobutton.Name = "onlineStorageRadiobutton";
            this.onlineStorageRadiobutton.Size = new System.Drawing.Size(136, 17);
            this.onlineStorageRadiobutton.TabIndex = 0;
            this.onlineStorageRadiobutton.Text = "Online Storage Mode";
            this.onlineStorageRadiobutton.UseVisualStyleBackColor = true;
            // 
            // prefConnectionPanel
            // 
            this.prefConnectionPanel.Controls.Add(this.connectionGroup);
            this.prefConnectionPanel.Enabled = false;
            this.prefConnectionPanel.Location = new System.Drawing.Point(165, 12);
            this.prefConnectionPanel.Name = "prefConnectionPanel";
            this.prefConnectionPanel.Size = new System.Drawing.Size(340, 310);
            this.prefConnectionPanel.TabIndex = 5;
            // 
            // prefAccountPanel
            // 
            this.prefAccountPanel.Controls.Add(this.passvaultAccountSettingsGroup);
            this.prefAccountPanel.Location = new System.Drawing.Point(523, 12);
            this.prefAccountPanel.Name = "prefAccountPanel";
            this.prefAccountPanel.Size = new System.Drawing.Size(340, 310);
            this.prefAccountPanel.TabIndex = 6;
            // 
            // passvaultAccountSettingsGroup
            // 
            this.passvaultAccountSettingsGroup.Controls.Add(this.confirmPasswordButton);
            this.passvaultAccountSettingsGroup.Controls.Add(this.editAccountInfoPasswordInput);
            this.passvaultAccountSettingsGroup.Controls.Add(this.label3);
            this.passvaultAccountSettingsGroup.Controls.Add(this.editAccountInfoButton);
            this.passvaultAccountSettingsGroup.Controls.Add(this.label2);
            this.passvaultAccountSettingsGroup.Controls.Add(this.prefDeleteAccountButton);
            this.passvaultAccountSettingsGroup.Controls.Add(this.label1);
            this.passvaultAccountSettingsGroup.Location = new System.Drawing.Point(3, 3);
            this.passvaultAccountSettingsGroup.Name = "passvaultAccountSettingsGroup";
            this.passvaultAccountSettingsGroup.Size = new System.Drawing.Size(334, 304);
            this.passvaultAccountSettingsGroup.TabIndex = 2;
            this.passvaultAccountSettingsGroup.TabStop = false;
            this.passvaultAccountSettingsGroup.Text = "Account Settings";
            // 
            // confirmPasswordButton
            // 
            this.confirmPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.confirmPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPasswordButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordButton.Location = new System.Drawing.Point(217, 64);
            this.confirmPasswordButton.Name = "confirmPasswordButton";
            this.confirmPasswordButton.Size = new System.Drawing.Size(100, 32);
            this.confirmPasswordButton.TabIndex = 6;
            this.confirmPasswordButton.Text = "Confirm";
            this.confirmPasswordButton.UseVisualStyleBackColor = true;
            this.confirmPasswordButton.Click += new System.EventHandler(this.confirmPasswordButton_Click);
            // 
            // editAccountInfoPasswordInput
            // 
            this.editAccountInfoPasswordInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAccountInfoPasswordInput.Location = new System.Drawing.Point(20, 69);
            this.editAccountInfoPasswordInput.Name = "editAccountInfoPasswordInput";
            this.editAccountInfoPasswordInput.PasswordChar = '*';
            this.editAccountInfoPasswordInput.Size = new System.Drawing.Size(150, 25);
            this.editAccountInfoPasswordInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please enter your PassVault password in order to enable\r\nthe options to edit your" +
    " account.";
            // 
            // editAccountInfoButton
            // 
            this.editAccountInfoButton.Enabled = false;
            this.editAccountInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editAccountInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccountInfoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAccountInfoButton.Location = new System.Drawing.Point(217, 110);
            this.editAccountInfoButton.Name = "editAccountInfoButton";
            this.editAccountInfoButton.Size = new System.Drawing.Size(100, 32);
            this.editAccountInfoButton.TabIndex = 3;
            this.editAccountInfoButton.Text = "Edit Account";
            this.editAccountInfoButton.UseVisualStyleBackColor = true;
            this.editAccountInfoButton.Click += new System.EventHandler(this.editAccountInfoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit Account Information";
            // 
            // prefDeleteAccountButton
            // 
            this.prefDeleteAccountButton.Enabled = false;
            this.prefDeleteAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.prefDeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prefDeleteAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefDeleteAccountButton.Location = new System.Drawing.Point(217, 266);
            this.prefDeleteAccountButton.Name = "prefDeleteAccountButton";
            this.prefDeleteAccountButton.Size = new System.Drawing.Size(100, 32);
            this.prefDeleteAccountButton.TabIndex = 1;
            this.prefDeleteAccountButton.Text = "Delete Account";
            this.prefDeleteAccountButton.UseVisualStyleBackColor = true;
            this.prefDeleteAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PassVault Account Deletion";
            // 
            // prefGeneralPanel
            // 
            this.prefGeneralPanel.Controls.Add(this.generalSettingsGroup);
            this.prefGeneralPanel.Location = new System.Drawing.Point(882, 12);
            this.prefGeneralPanel.Name = "prefGeneralPanel";
            this.prefGeneralPanel.Size = new System.Drawing.Size(340, 310);
            this.prefGeneralPanel.TabIndex = 7;
            // 
            // preferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1237, 372);
            this.Controls.Add(this.prefGeneralPanel);
            this.Controls.Add(this.prefAccountPanel);
            this.Controls.Add(this.prefConnectionPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.preferencesExitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 410);
            this.Name = "preferencesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.generalSettingsGroup.ResumeLayout(false);
            this.generalSettingsGroup.PerformLayout();
            this.prefConnectionPanel.ResumeLayout(false);
            this.prefAccountPanel.ResumeLayout(false);
            this.passvaultAccountSettingsGroup.ResumeLayout(false);
            this.passvaultAccountSettingsGroup.PerformLayout();
            this.prefGeneralPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.Button dbConnectButton;
        private System.Windows.Forms.MaskedTextBox dbPassInput;
        private System.Windows.Forms.TextBox dbUserInput;
        private System.Windows.Forms.TextBox dbHostInput;
        private System.Windows.Forms.CheckBox stayConnectedCheckbox;
        private System.Windows.Forms.Label dbHost;
        private System.Windows.Forms.Label dbPass;
        private System.Windows.Forms.Label dbUser;
        private System.Windows.Forms.Button preferencesExitButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox generalSettingsGroup;
        private System.Windows.Forms.Panel prefConnectionPanel;
        private System.Windows.Forms.Panel prefAccountPanel;
        private System.Windows.Forms.GroupBox passvaultAccountSettingsGroup;
        private System.Windows.Forms.Button prefDeleteAccountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel prefGeneralPanel;
        private System.Windows.Forms.Button editAccountInfoButton;
        private System.Windows.Forms.RadioButton offlineStorageRadiobutton;
        private System.Windows.Forms.RadioButton onlineStorageRadiobutton;
        private System.Windows.Forms.Button confirmPasswordButton;
        private System.Windows.Forms.MaskedTextBox editAccountInfoPasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateStorageModeButton;
        private System.Windows.Forms.Label label2;

    }
}