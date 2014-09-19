namespace PassVault
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.passvaultMemberLoginLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.mainUsernameInput = new System.Windows.Forms.TextBox();
            this.mainPasswordInput = new System.Windows.Forms.MaskedTextBox();
            this.mainLoginButton = new System.Windows.Forms.Button();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.signupLabel = new System.Windows.Forms.LinkLabel();
            this.invalidMemberLoginWarningLabel = new System.Windows.Forms.Label();
            this.adminOverrideAccessCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // passvaultMemberLoginLabel
            // 
            this.passvaultMemberLoginLabel.AutoSize = true;
            this.passvaultMemberLoginLabel.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passvaultMemberLoginLabel.Location = new System.Drawing.Point(178, 20);
            this.passvaultMemberLoginLabel.Name = "passvaultMemberLoginLabel";
            this.passvaultMemberLoginLabel.Size = new System.Drawing.Size(118, 19);
            this.passvaultMemberLoginLabel.TabIndex = 0;
            this.passvaultMemberLoginLabel.Text = "MEMBER LOGIN";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(179, 77);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(179, 116);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // mainUsernameInput
            // 
            this.mainUsernameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainUsernameInput.Location = new System.Drawing.Point(257, 71);
            this.mainUsernameInput.Name = "mainUsernameInput";
            this.mainUsernameInput.Size = new System.Drawing.Size(175, 25);
            this.mainUsernameInput.TabIndex = 3;
            // 
            // mainPasswordInput
            // 
            this.mainPasswordInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPasswordInput.Location = new System.Drawing.Point(257, 110);
            this.mainPasswordInput.Name = "mainPasswordInput";
            this.mainPasswordInput.PasswordChar = '*';
            this.mainPasswordInput.Size = new System.Drawing.Size(175, 25);
            this.mainPasswordInput.TabIndex = 4;
            // 
            // mainLoginButton
            // 
            this.mainLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.mainLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLoginButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLoginButton.Location = new System.Drawing.Point(332, 144);
            this.mainLoginButton.Name = "mainLoginButton";
            this.mainLoginButton.Size = new System.Drawing.Size(100, 32);
            this.mainLoginButton.TabIndex = 5;
            this.mainLoginButton.Text = "Login";
            this.mainLoginButton.UseVisualStyleBackColor = true;
            this.mainLoginButton.Click += new System.EventHandler(this.mainLoginButton_Click);
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Location = new System.Drawing.Point(179, 155);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(99, 13);
            this.forgotPasswordLink.TabIndex = 6;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // profilePic
            // 
            this.profilePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePic.BackgroundImage")));
            this.profilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePic.Location = new System.Drawing.Point(24, 36);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(135, 135);
            this.profilePic.TabIndex = 7;
            this.profilePic.TabStop = false;
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.Location = new System.Drawing.Point(278, 155);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(48, 13);
            this.signupLabel.TabIndex = 8;
            this.signupLabel.TabStop = true;
            this.signupLabel.Text = "Sign Up";
            this.signupLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLabel_LinkClicked);
            // 
            // invalidMemberLoginWarningLabel
            // 
            this.invalidMemberLoginWarningLabel.AutoSize = true;
            this.invalidMemberLoginWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidMemberLoginWarningLabel.Location = new System.Drawing.Point(180, 45);
            this.invalidMemberLoginWarningLabel.Name = "invalidMemberLoginWarningLabel";
            this.invalidMemberLoginWarningLabel.Size = new System.Drawing.Size(210, 13);
            this.invalidMemberLoginWarningLabel.TabIndex = 9;
            this.invalidMemberLoginWarningLabel.Text = "Invalid ID or Password. Please try again.";
            // 
            // adminOverrideAccessCheckbox
            // 
            this.adminOverrideAccessCheckbox.AutoSize = true;
            this.adminOverrideAccessCheckbox.Location = new System.Drawing.Point(160, 391);
            this.adminOverrideAccessCheckbox.Name = "adminOverrideAccessCheckbox";
            this.adminOverrideAccessCheckbox.Size = new System.Drawing.Size(136, 17);
            this.adminOverrideAccessCheckbox.TabIndex = 10;
            this.adminOverrideAccessCheckbox.Text = "AdminOverrideAccess";
            this.adminOverrideAccessCheckbox.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(454, 197);
            this.Controls.Add(this.adminOverrideAccessCheckbox);
            this.Controls.Add(this.invalidMemberLoginWarningLabel);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.forgotPasswordLink);
            this.Controls.Add(this.mainLoginButton);
            this.Controls.Add(this.mainPasswordInput);
            this.Controls.Add(this.mainUsernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passvaultMemberLoginLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 235);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassVault Member Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passvaultMemberLoginLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox mainUsernameInput;
        private System.Windows.Forms.MaskedTextBox mainPasswordInput;
        private System.Windows.Forms.Button mainLoginButton;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.LinkLabel signupLabel;
        private System.Windows.Forms.Label invalidMemberLoginWarningLabel;
        private System.Windows.Forms.CheckBox adminOverrideAccessCheckbox;
    }
}