namespace PassVault
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.sufNameLabel = new System.Windows.Forms.Label();
            this.sufEmailLabel = new System.Windows.Forms.Label();
            this.sufConfirmEmailLabel = new System.Windows.Forms.Label();
            this.sufUsernameLabel = new System.Windows.Forms.Label();
            this.sufPasswordLabel = new System.Windows.Forms.Label();
            this.signUpPanel1 = new System.Windows.Forms.Panel();
            this.sufCancelButton = new System.Windows.Forms.Button();
            this.sufCreateAccountButton = new System.Windows.Forms.Button();
            this.sufPasswordReminderInput = new System.Windows.Forms.TextBox();
            this.sufConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.sufPasswordInput = new System.Windows.Forms.TextBox();
            this.sufUsernameInput = new System.Windows.Forms.TextBox();
            this.sufConfirmEmailInput = new System.Windows.Forms.TextBox();
            this.sufEmailInput = new System.Windows.Forms.TextBox();
            this.sufNameInput = new System.Windows.Forms.TextBox();
            this.termsAgreementCheckbox = new System.Windows.Forms.CheckBox();
            this.sufPasswordReminderLabel = new System.Windows.Forms.Label();
            this.sufConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordReminderDisclaimer = new System.Windows.Forms.ToolTip(this.components);
            this.sufErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.signUpPanel2 = new System.Windows.Forms.Panel();
            this.sufGroupboxAccount = new System.Windows.Forms.GroupBox();
            this.sufGroupboxDatabase = new System.Windows.Forms.GroupBox();
            this.sufDBTableNameLabel = new System.Windows.Forms.Label();
            this.sufDBTableNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sufCreatedAccountInfoGroupbox = new System.Windows.Forms.GroupBox();
            this.sufOKButton = new System.Windows.Forms.Button();
            this.sufFinalName = new System.Windows.Forms.Label();
            this.sufFinalEmail = new System.Windows.Forms.Label();
            this.sufFinalUsername = new System.Windows.Forms.Label();
            this.sufFinalPassword = new System.Windows.Forms.Label();
            this.sufFinalPasswordHint = new System.Windows.Forms.Label();
            this.sufFinalDBTableName = new System.Windows.Forms.Label();
            this.signUpPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sufErrorProvider1)).BeginInit();
            this.signUpPanel2.SuspendLayout();
            this.sufGroupboxAccount.SuspendLayout();
            this.sufGroupboxDatabase.SuspendLayout();
            this.sufCreatedAccountInfoGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sufNameLabel
            // 
            this.sufNameLabel.AutoSize = true;
            this.sufNameLabel.Location = new System.Drawing.Point(22, 33);
            this.sufNameLabel.Name = "sufNameLabel";
            this.sufNameLabel.Size = new System.Drawing.Size(36, 13);
            this.sufNameLabel.TabIndex = 0;
            this.sufNameLabel.Text = "Name";
            // 
            // sufEmailLabel
            // 
            this.sufEmailLabel.AutoSize = true;
            this.sufEmailLabel.Location = new System.Drawing.Point(22, 64);
            this.sufEmailLabel.Name = "sufEmailLabel";
            this.sufEmailLabel.Size = new System.Drawing.Size(34, 13);
            this.sufEmailLabel.TabIndex = 1;
            this.sufEmailLabel.Text = "Email";
            // 
            // sufConfirmEmailLabel
            // 
            this.sufConfirmEmailLabel.AutoSize = true;
            this.sufConfirmEmailLabel.Location = new System.Drawing.Point(22, 95);
            this.sufConfirmEmailLabel.Name = "sufConfirmEmailLabel";
            this.sufConfirmEmailLabel.Size = new System.Drawing.Size(78, 13);
            this.sufConfirmEmailLabel.TabIndex = 2;
            this.sufConfirmEmailLabel.Text = "Confirm Email";
            // 
            // sufUsernameLabel
            // 
            this.sufUsernameLabel.AutoSize = true;
            this.sufUsernameLabel.Location = new System.Drawing.Point(22, 126);
            this.sufUsernameLabel.Name = "sufUsernameLabel";
            this.sufUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.sufUsernameLabel.TabIndex = 3;
            this.sufUsernameLabel.Text = "Username";
            // 
            // sufPasswordLabel
            // 
            this.sufPasswordLabel.AutoSize = true;
            this.sufPasswordLabel.Location = new System.Drawing.Point(22, 157);
            this.sufPasswordLabel.Name = "sufPasswordLabel";
            this.sufPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.sufPasswordLabel.TabIndex = 4;
            this.sufPasswordLabel.Text = "Password";
            // 
            // signUpPanel1
            // 
            this.signUpPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signUpPanel1.Controls.Add(this.sufCancelButton);
            this.signUpPanel1.Controls.Add(this.termsAgreementCheckbox);
            this.signUpPanel1.Controls.Add(this.sufGroupboxDatabase);
            this.signUpPanel1.Controls.Add(this.sufCreateAccountButton);
            this.signUpPanel1.Controls.Add(this.sufGroupboxAccount);
            this.signUpPanel1.Location = new System.Drawing.Point(0, 0);
            this.signUpPanel1.Name = "signUpPanel1";
            this.signUpPanel1.Size = new System.Drawing.Size(400, 505);
            this.signUpPanel1.TabIndex = 5;
            // 
            // sufCancelButton
            // 
            this.sufCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sufCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sufCancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufCancelButton.Location = new System.Drawing.Point(222, 449);
            this.sufCancelButton.Name = "sufCancelButton";
            this.sufCancelButton.Size = new System.Drawing.Size(140, 32);
            this.sufCancelButton.TabIndex = 11;
            this.sufCancelButton.Text = "Cancel";
            this.sufCancelButton.UseVisualStyleBackColor = true;
            this.sufCancelButton.Click += new System.EventHandler(this.sufCancelButton_Click);
            // 
            // sufCreateAccountButton
            // 
            this.sufCreateAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sufCreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sufCreateAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufCreateAccountButton.Location = new System.Drawing.Point(33, 449);
            this.sufCreateAccountButton.Name = "sufCreateAccountButton";
            this.sufCreateAccountButton.Size = new System.Drawing.Size(140, 32);
            this.sufCreateAccountButton.TabIndex = 10;
            this.sufCreateAccountButton.Text = "Create Account";
            this.sufCreateAccountButton.UseVisualStyleBackColor = true;
            this.sufCreateAccountButton.Click += new System.EventHandler(this.sufCreateAccountButton_Click);
            // 
            // sufPasswordReminderInput
            // 
            this.sufPasswordReminderInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufPasswordReminderInput.Location = new System.Drawing.Point(24, 249);
            this.sufPasswordReminderInput.Name = "sufPasswordReminderInput";
            this.sufPasswordReminderInput.Size = new System.Drawing.Size(330, 25);
            this.sufPasswordReminderInput.TabIndex = 9;
            this.sufPasswordReminderInput.MouseHover += new System.EventHandler(this.sufPasswordReminderInput_MouseHover);
            // 
            // sufConfirmPasswordInput
            // 
            this.sufConfirmPasswordInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufConfirmPasswordInput.Location = new System.Drawing.Point(174, 182);
            this.sufConfirmPasswordInput.Name = "sufConfirmPasswordInput";
            this.sufConfirmPasswordInput.PasswordChar = '*';
            this.sufConfirmPasswordInput.Size = new System.Drawing.Size(180, 25);
            this.sufConfirmPasswordInput.TabIndex = 8;
            // 
            // sufPasswordInput
            // 
            this.sufPasswordInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufPasswordInput.Location = new System.Drawing.Point(174, 151);
            this.sufPasswordInput.Name = "sufPasswordInput";
            this.sufPasswordInput.PasswordChar = '*';
            this.sufPasswordInput.Size = new System.Drawing.Size(180, 25);
            this.sufPasswordInput.TabIndex = 7;
            // 
            // sufUsernameInput
            // 
            this.sufUsernameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufUsernameInput.Location = new System.Drawing.Point(174, 120);
            this.sufUsernameInput.Name = "sufUsernameInput";
            this.sufUsernameInput.Size = new System.Drawing.Size(180, 25);
            this.sufUsernameInput.TabIndex = 6;
            // 
            // sufConfirmEmailInput
            // 
            this.sufConfirmEmailInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufConfirmEmailInput.Location = new System.Drawing.Point(174, 89);
            this.sufConfirmEmailInput.Name = "sufConfirmEmailInput";
            this.sufConfirmEmailInput.Size = new System.Drawing.Size(180, 25);
            this.sufConfirmEmailInput.TabIndex = 5;
            // 
            // sufEmailInput
            // 
            this.sufEmailInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufEmailInput.Location = new System.Drawing.Point(174, 58);
            this.sufEmailInput.Name = "sufEmailInput";
            this.sufEmailInput.Size = new System.Drawing.Size(180, 25);
            this.sufEmailInput.TabIndex = 4;
            // 
            // sufNameInput
            // 
            this.sufNameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufNameInput.Location = new System.Drawing.Point(174, 27);
            this.sufNameInput.Name = "sufNameInput";
            this.sufNameInput.Size = new System.Drawing.Size(180, 25);
            this.sufNameInput.TabIndex = 3;
            // 
            // termsAgreementCheckbox
            // 
            this.termsAgreementCheckbox.AutoSize = true;
            this.termsAgreementCheckbox.Location = new System.Drawing.Point(36, 404);
            this.termsAgreementCheckbox.Name = "termsAgreementCheckbox";
            this.termsAgreementCheckbox.Size = new System.Drawing.Size(329, 30);
            this.termsAgreementCheckbox.TabIndex = 2;
            this.termsAgreementCheckbox.Text = "I have read and agree with the terms of service and privacy \r\nstatement.";
            this.termsAgreementCheckbox.UseVisualStyleBackColor = true;
            // 
            // sufPasswordReminderLabel
            // 
            this.sufPasswordReminderLabel.AutoSize = true;
            this.sufPasswordReminderLabel.Location = new System.Drawing.Point(21, 220);
            this.sufPasswordReminderLabel.Name = "sufPasswordReminderLabel";
            this.sufPasswordReminderLabel.Size = new System.Drawing.Size(108, 13);
            this.sufPasswordReminderLabel.TabIndex = 1;
            this.sufPasswordReminderLabel.Text = "Password Reminder";
            // 
            // sufConfirmPasswordLabel
            // 
            this.sufConfirmPasswordLabel.AutoSize = true;
            this.sufConfirmPasswordLabel.Location = new System.Drawing.Point(22, 188);
            this.sufConfirmPasswordLabel.Name = "sufConfirmPasswordLabel";
            this.sufConfirmPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.sufConfirmPasswordLabel.TabIndex = 0;
            this.sufConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // sufErrorProvider1
            // 
            this.sufErrorProvider1.ContainerControl = this;
            // 
            // signUpPanel2
            // 
            this.signUpPanel2.Controls.Add(this.sufOKButton);
            this.signUpPanel2.Controls.Add(this.label1);
            this.signUpPanel2.Controls.Add(this.sufCreatedAccountInfoGroupbox);
            this.signUpPanel2.Location = new System.Drawing.Point(422, 0);
            this.signUpPanel2.Name = "signUpPanel2";
            this.signUpPanel2.Size = new System.Drawing.Size(400, 506);
            this.signUpPanel2.TabIndex = 6;
            // 
            // sufGroupboxAccount
            // 
            this.sufGroupboxAccount.Controls.Add(this.sufPasswordReminderInput);
            this.sufGroupboxAccount.Controls.Add(this.sufNameInput);
            this.sufGroupboxAccount.Controls.Add(this.sufConfirmPasswordInput);
            this.sufGroupboxAccount.Controls.Add(this.sufNameLabel);
            this.sufGroupboxAccount.Controls.Add(this.sufPasswordInput);
            this.sufGroupboxAccount.Controls.Add(this.sufConfirmPasswordLabel);
            this.sufGroupboxAccount.Controls.Add(this.sufUsernameInput);
            this.sufGroupboxAccount.Controls.Add(this.sufEmailLabel);
            this.sufGroupboxAccount.Controls.Add(this.sufConfirmEmailInput);
            this.sufGroupboxAccount.Controls.Add(this.sufPasswordReminderLabel);
            this.sufGroupboxAccount.Controls.Add(this.sufPasswordLabel);
            this.sufGroupboxAccount.Controls.Add(this.sufConfirmEmailLabel);
            this.sufGroupboxAccount.Controls.Add(this.sufEmailInput);
            this.sufGroupboxAccount.Controls.Add(this.sufUsernameLabel);
            this.sufGroupboxAccount.Location = new System.Drawing.Point(12, 12);
            this.sufGroupboxAccount.Name = "sufGroupboxAccount";
            this.sufGroupboxAccount.Size = new System.Drawing.Size(375, 300);
            this.sufGroupboxAccount.TabIndex = 0;
            this.sufGroupboxAccount.TabStop = false;
            this.sufGroupboxAccount.Text = "PassVault Account Info";
            // 
            // sufGroupboxDatabase
            // 
            this.sufGroupboxDatabase.Controls.Add(this.sufDBTableNameInput);
            this.sufGroupboxDatabase.Controls.Add(this.sufDBTableNameLabel);
            this.sufGroupboxDatabase.Location = new System.Drawing.Point(12, 318);
            this.sufGroupboxDatabase.Name = "sufGroupboxDatabase";
            this.sufGroupboxDatabase.Size = new System.Drawing.Size(375, 69);
            this.sufGroupboxDatabase.TabIndex = 1;
            this.sufGroupboxDatabase.TabStop = false;
            this.sufGroupboxDatabase.Text = "Database Table Info";
            // 
            // sufDBTableNameLabel
            // 
            this.sufDBTableNameLabel.AutoSize = true;
            this.sufDBTableNameLabel.Location = new System.Drawing.Point(22, 28);
            this.sufDBTableNameLabel.Name = "sufDBTableNameLabel";
            this.sufDBTableNameLabel.Size = new System.Drawing.Size(117, 13);
            this.sufDBTableNameLabel.TabIndex = 0;
            this.sufDBTableNameLabel.Text = "Database Table Name";
            // 
            // sufDBTableNameInput
            // 
            this.sufDBTableNameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufDBTableNameInput.Location = new System.Drawing.Point(174, 22);
            this.sufDBTableNameInput.Name = "sufDBTableNameInput";
            this.sufDBTableNameInput.Size = new System.Drawing.Size(180, 25);
            this.sufDBTableNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // sufCreatedAccountInfoGroupbox
            // 
            this.sufCreatedAccountInfoGroupbox.Controls.Add(this.sufFinalDBTableName);
            this.sufCreatedAccountInfoGroupbox.Controls.Add(this.sufFinalPasswordHint);
            this.sufCreatedAccountInfoGroupbox.Controls.Add(this.sufFinalPassword);
            this.sufCreatedAccountInfoGroupbox.Controls.Add(this.sufFinalUsername);
            this.sufCreatedAccountInfoGroupbox.Controls.Add(this.sufFinalEmail);
            this.sufCreatedAccountInfoGroupbox.Controls.Add(this.sufFinalName);
            this.sufCreatedAccountInfoGroupbox.Location = new System.Drawing.Point(10, 121);
            this.sufCreatedAccountInfoGroupbox.Name = "sufCreatedAccountInfoGroupbox";
            this.sufCreatedAccountInfoGroupbox.Size = new System.Drawing.Size(380, 265);
            this.sufCreatedAccountInfoGroupbox.TabIndex = 1;
            this.sufCreatedAccountInfoGroupbox.TabStop = false;
            this.sufCreatedAccountInfoGroupbox.Text = "Your Account Information";
            // 
            // sufOKButton
            // 
            this.sufOKButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sufOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sufOKButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufOKButton.Location = new System.Drawing.Point(130, 449);
            this.sufOKButton.Name = "sufOKButton";
            this.sufOKButton.Size = new System.Drawing.Size(140, 32);
            this.sufOKButton.TabIndex = 2;
            this.sufOKButton.Text = "OK";
            this.sufOKButton.UseVisualStyleBackColor = true;
            this.sufOKButton.Click += new System.EventHandler(this.sufOKButton_Click);
            // 
            // sufFinalName
            // 
            this.sufFinalName.AutoSize = true;
            this.sufFinalName.Location = new System.Drawing.Point(25, 35);
            this.sufFinalName.MaximumSize = new System.Drawing.Size(330, 0);
            this.sufFinalName.Name = "sufFinalName";
            this.sufFinalName.Size = new System.Drawing.Size(36, 13);
            this.sufFinalName.TabIndex = 0;
            this.sufFinalName.Text = "Name";
            // 
            // sufFinalEmail
            // 
            this.sufFinalEmail.AutoSize = true;
            this.sufFinalEmail.Location = new System.Drawing.Point(25, 56);
            this.sufFinalEmail.MaximumSize = new System.Drawing.Size(325, 0);
            this.sufFinalEmail.Name = "sufFinalEmail";
            this.sufFinalEmail.Size = new System.Drawing.Size(34, 13);
            this.sufFinalEmail.TabIndex = 1;
            this.sufFinalEmail.Text = "Email";
            // 
            // sufFinalUsername
            // 
            this.sufFinalUsername.AutoSize = true;
            this.sufFinalUsername.Location = new System.Drawing.Point(25, 77);
            this.sufFinalUsername.MaximumSize = new System.Drawing.Size(325, 0);
            this.sufFinalUsername.Name = "sufFinalUsername";
            this.sufFinalUsername.Size = new System.Drawing.Size(58, 13);
            this.sufFinalUsername.TabIndex = 2;
            this.sufFinalUsername.Text = "Username";
            // 
            // sufFinalPassword
            // 
            this.sufFinalPassword.AutoSize = true;
            this.sufFinalPassword.Location = new System.Drawing.Point(25, 99);
            this.sufFinalPassword.MaximumSize = new System.Drawing.Size(325, 0);
            this.sufFinalPassword.Name = "sufFinalPassword";
            this.sufFinalPassword.Size = new System.Drawing.Size(56, 13);
            this.sufFinalPassword.TabIndex = 3;
            this.sufFinalPassword.Text = "Password";
            // 
            // sufFinalPasswordHint
            // 
            this.sufFinalPasswordHint.AutoSize = true;
            this.sufFinalPasswordHint.Location = new System.Drawing.Point(25, 124);
            this.sufFinalPasswordHint.MaximumSize = new System.Drawing.Size(320, 0);
            this.sufFinalPasswordHint.Name = "sufFinalPasswordHint";
            this.sufFinalPasswordHint.Size = new System.Drawing.Size(81, 13);
            this.sufFinalPasswordHint.TabIndex = 4;
            this.sufFinalPasswordHint.Text = "Password Hint\r\n";
            // 
            // sufFinalDBTableName
            // 
            this.sufFinalDBTableName.AutoSize = true;
            this.sufFinalDBTableName.Location = new System.Drawing.Point(25, 210);
            this.sufFinalDBTableName.MaximumSize = new System.Drawing.Size(315, 0);
            this.sufFinalDBTableName.Name = "sufFinalDBTableName";
            this.sufFinalDBTableName.Size = new System.Drawing.Size(117, 13);
            this.sufFinalDBTableName.TabIndex = 5;
            this.sufFinalDBTableName.Text = "Database Table Name";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.signUpPanel2);
            this.Controls.Add(this.signUpPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "PassVault - Sign Up Form";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.signUpPanel1.ResumeLayout(false);
            this.signUpPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sufErrorProvider1)).EndInit();
            this.signUpPanel2.ResumeLayout(false);
            this.signUpPanel2.PerformLayout();
            this.sufGroupboxAccount.ResumeLayout(false);
            this.sufGroupboxAccount.PerformLayout();
            this.sufGroupboxDatabase.ResumeLayout(false);
            this.sufGroupboxDatabase.PerformLayout();
            this.sufCreatedAccountInfoGroupbox.ResumeLayout(false);
            this.sufCreatedAccountInfoGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sufNameLabel;
        private System.Windows.Forms.Label sufEmailLabel;
        private System.Windows.Forms.Label sufConfirmEmailLabel;
        private System.Windows.Forms.Label sufUsernameLabel;
        private System.Windows.Forms.Label sufPasswordLabel;
        private System.Windows.Forms.Panel signUpPanel1;
        private System.Windows.Forms.CheckBox termsAgreementCheckbox;
        private System.Windows.Forms.Label sufPasswordReminderLabel;
        private System.Windows.Forms.Label sufConfirmPasswordLabel;
        private System.Windows.Forms.Button sufCancelButton;
        private System.Windows.Forms.Button sufCreateAccountButton;
        private System.Windows.Forms.TextBox sufPasswordReminderInput;
        private System.Windows.Forms.TextBox sufConfirmPasswordInput;
        private System.Windows.Forms.TextBox sufPasswordInput;
        private System.Windows.Forms.TextBox sufUsernameInput;
        private System.Windows.Forms.TextBox sufConfirmEmailInput;
        private System.Windows.Forms.TextBox sufEmailInput;
        private System.Windows.Forms.TextBox sufNameInput;
        private System.Windows.Forms.ToolTip passwordReminderDisclaimer;
        private System.Windows.Forms.ErrorProvider sufErrorProvider1;
        private System.Windows.Forms.GroupBox sufGroupboxDatabase;
        private System.Windows.Forms.TextBox sufDBTableNameInput;
        private System.Windows.Forms.Label sufDBTableNameLabel;
        private System.Windows.Forms.GroupBox sufGroupboxAccount;
        private System.Windows.Forms.Panel signUpPanel2;
        private System.Windows.Forms.Button sufOKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sufCreatedAccountInfoGroupbox;
        private System.Windows.Forms.Label sufFinalDBTableName;
        private System.Windows.Forms.Label sufFinalPasswordHint;
        private System.Windows.Forms.Label sufFinalPassword;
        private System.Windows.Forms.Label sufFinalUsername;
        private System.Windows.Forms.Label sufFinalEmail;
        private System.Windows.Forms.Label sufFinalName;
    }
}