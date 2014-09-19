namespace PassVault
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.forgotPasswordPanel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fgtConfirmationInput = new System.Windows.Forms.TextBox();
            this.fgtConfirmationLabel = new System.Windows.Forms.Label();
            this.captchaCodeLabel = new System.Windows.Forms.Label();
            this.fgtCancelButton = new System.Windows.Forms.Button();
            this.fgtSubmitButton = new System.Windows.Forms.Button();
            this.fgtEmailInput = new System.Windows.Forms.TextBox();
            this.fgtNameInput = new System.Windows.Forms.TextBox();
            this.fgtEmailLabel = new System.Windows.Forms.Label();
            this.fgtNameLabel = new System.Windows.Forms.Label();
            this.fgtInstructionLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.fgtErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.forgotPasswordPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgtErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // forgotPasswordPanel1
            // 
            this.forgotPasswordPanel1.Controls.Add(this.button1);
            this.forgotPasswordPanel1.Controls.Add(this.fgtConfirmationInput);
            this.forgotPasswordPanel1.Controls.Add(this.fgtConfirmationLabel);
            this.forgotPasswordPanel1.Controls.Add(this.captchaCodeLabel);
            this.forgotPasswordPanel1.Controls.Add(this.fgtCancelButton);
            this.forgotPasswordPanel1.Controls.Add(this.fgtSubmitButton);
            this.forgotPasswordPanel1.Controls.Add(this.fgtEmailInput);
            this.forgotPasswordPanel1.Controls.Add(this.fgtNameInput);
            this.forgotPasswordPanel1.Controls.Add(this.fgtEmailLabel);
            this.forgotPasswordPanel1.Controls.Add(this.fgtNameLabel);
            this.forgotPasswordPanel1.Controls.Add(this.fgtInstructionLabel);
            this.forgotPasswordPanel1.Controls.Add(this.forgotPasswordLabel);
            this.forgotPasswordPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgotPasswordPanel1.Location = new System.Drawing.Point(0, 0);
            this.forgotPasswordPanel1.Name = "forgotPasswordPanel1";
            this.forgotPasswordPanel1.Size = new System.Drawing.Size(454, 342);
            this.forgotPasswordPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(293, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fgtConfirmationInput
            // 
            this.fgtConfirmationInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtConfirmationInput.Location = new System.Drawing.Point(146, 221);
            this.fgtConfirmationInput.MaxLength = 5;
            this.fgtConfirmationInput.Name = "fgtConfirmationInput";
            this.fgtConfirmationInput.Size = new System.Drawing.Size(120, 25);
            this.fgtConfirmationInput.TabIndex = 11;
            // 
            // fgtConfirmationLabel
            // 
            this.fgtConfirmationLabel.AutoSize = true;
            this.fgtConfirmationLabel.Location = new System.Drawing.Point(39, 227);
            this.fgtConfirmationLabel.Name = "fgtConfirmationLabel";
            this.fgtConfirmationLabel.Size = new System.Drawing.Size(105, 13);
            this.fgtConfirmationLabel.TabIndex = 10;
            this.fgtConfirmationLabel.Text = "Confirmation Code";
            // 
            // captchaCodeLabel
            // 
            this.captchaCodeLabel.AutoSize = true;
            this.captchaCodeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.captchaCodeLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Bold);
            this.captchaCodeLabel.Location = new System.Drawing.Point(329, 216);
            this.captchaCodeLabel.Name = "captchaCodeLabel";
            this.captchaCodeLabel.Size = new System.Drawing.Size(82, 30);
            this.captchaCodeLabel.TabIndex = 9;
            this.captchaCodeLabel.Text = "BLANK";
            // 
            // fgtCancelButton
            // 
            this.fgtCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.fgtCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fgtCancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtCancelButton.Location = new System.Drawing.Point(246, 280);
            this.fgtCancelButton.Name = "fgtCancelButton";
            this.fgtCancelButton.Size = new System.Drawing.Size(100, 32);
            this.fgtCancelButton.TabIndex = 8;
            this.fgtCancelButton.Text = "Cancel";
            this.fgtCancelButton.UseVisualStyleBackColor = true;
            this.fgtCancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // fgtSubmitButton
            // 
            this.fgtSubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.fgtSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fgtSubmitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtSubmitButton.Location = new System.Drawing.Point(109, 280);
            this.fgtSubmitButton.Name = "fgtSubmitButton";
            this.fgtSubmitButton.Size = new System.Drawing.Size(100, 32);
            this.fgtSubmitButton.TabIndex = 7;
            this.fgtSubmitButton.Text = "Submit";
            this.fgtSubmitButton.UseVisualStyleBackColor = true;
            this.fgtSubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fgtEmailInput
            // 
            this.fgtEmailInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtEmailInput.Location = new System.Drawing.Point(146, 166);
            this.fgtEmailInput.Name = "fgtEmailInput";
            this.fgtEmailInput.Size = new System.Drawing.Size(270, 25);
            this.fgtEmailInput.TabIndex = 6;
            this.fgtEmailInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fgtNameInput
            // 
            this.fgtNameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtNameInput.Location = new System.Drawing.Point(146, 130);
            this.fgtNameInput.Name = "fgtNameInput";
            this.fgtNameInput.Size = new System.Drawing.Size(270, 25);
            this.fgtNameInput.TabIndex = 5;
            this.fgtNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fgtEmailLabel
            // 
            this.fgtEmailLabel.AutoSize = true;
            this.fgtEmailLabel.Location = new System.Drawing.Point(39, 172);
            this.fgtEmailLabel.Name = "fgtEmailLabel";
            this.fgtEmailLabel.Size = new System.Drawing.Size(78, 13);
            this.fgtEmailLabel.TabIndex = 3;
            this.fgtEmailLabel.Text = "Email Address";
            // 
            // fgtNameLabel
            // 
            this.fgtNameLabel.AutoSize = true;
            this.fgtNameLabel.Location = new System.Drawing.Point(40, 136);
            this.fgtNameLabel.Name = "fgtNameLabel";
            this.fgtNameLabel.Size = new System.Drawing.Size(36, 13);
            this.fgtNameLabel.TabIndex = 2;
            this.fgtNameLabel.Text = "Name";
            this.fgtNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // fgtInstructionLabel
            // 
            this.fgtInstructionLabel.AutoSize = true;
            this.fgtInstructionLabel.Location = new System.Drawing.Point(39, 64);
            this.fgtInstructionLabel.Name = "fgtInstructionLabel";
            this.fgtInstructionLabel.Size = new System.Drawing.Size(377, 39);
            this.fgtInstructionLabel.TabIndex = 1;
            this.fgtInstructionLabel.Text = resources.GetString("fgtInstructionLabel.Text");
            this.fgtInstructionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.forgotPasswordLabel.Location = new System.Drawing.Point(39, 30);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(153, 19);
            this.forgotPasswordLabel.TabIndex = 0;
            this.forgotPasswordLabel.Text = "FORGOT PASSWORD";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            // 
            // fgtErrorProvider1
            // 
            this.fgtErrorProvider1.ContainerControl = this;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(454, 342);
            this.Controls.Add(this.forgotPasswordPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 380);
            this.Name = "ForgotPasswordForm";
            this.Text = "PassVault - Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.forgotPasswordPanel1.ResumeLayout(false);
            this.forgotPasswordPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgtErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel forgotPasswordPanel1;
        private System.Windows.Forms.Label fgtInstructionLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Label fgtEmailLabel;
        private System.Windows.Forms.Label fgtNameLabel;
        private System.Windows.Forms.Button fgtCancelButton;
        private System.Windows.Forms.Button fgtSubmitButton;
        private System.Windows.Forms.TextBox fgtEmailInput;
        private System.Windows.Forms.TextBox fgtNameInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fgtConfirmationInput;
        private System.Windows.Forms.Label fgtConfirmationLabel;
        private System.Windows.Forms.Label captchaCodeLabel;
        private System.Windows.Forms.ErrorProvider fgtErrorProvider1;
    }
}