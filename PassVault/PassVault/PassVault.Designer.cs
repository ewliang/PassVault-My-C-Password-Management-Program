namespace PassVault
{
    partial class passVaultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passVaultForm));
            this.userLabel = new System.Windows.Forms.Label();
            this.addUserInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asExcelSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passLabel = new System.Windows.Forms.Label();
            this.addPassInput = new System.Windows.Forms.MaskedTextBox();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.newAccountGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notesRichTextbox = new System.Windows.Forms.RichTextBox();
            this.labelInput = new System.Windows.Forms.TextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.storedAccountGroup = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.accountGrid = new System.Windows.Forms.DataGridView();
            this.copyAccountButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.newAccountGroup.SuspendLayout();
            this.storedAccountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.userLabel.Location = new System.Drawing.Point(207, 64);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(58, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username";
            // 
            // addUserInput
            // 
            this.addUserInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserInput.Location = new System.Drawing.Point(210, 89);
            this.addUserInput.Name = "addUserInput";
            this.addUserInput.Size = new System.Drawing.Size(170, 25);
            this.addUserInput.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asExcelSpreadsheetToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exportToolStripMenuItem.Text = "Export As";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // asExcelSpreadsheetToolStripMenuItem
            // 
            this.asExcelSpreadsheetToolStripMenuItem.Name = "asExcelSpreadsheetToolStripMenuItem";
            this.asExcelSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.asExcelSpreadsheetToolStripMenuItem.Text = "Excel Spreadsheet";
            this.asExcelSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.asExcelSpreadsheetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyAccountButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About Pass Vault";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.passLabel.Location = new System.Drawing.Point(370, 30);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(56, 13);
            this.passLabel.TabIndex = 0;
            this.passLabel.Text = "Password";
            // 
            // addPassInput
            // 
            this.addPassInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassInput.Location = new System.Drawing.Point(373, 55);
            this.addPassInput.Name = "addPassInput";
            this.addPassInput.PasswordChar = '*';
            this.addPassInput.Size = new System.Drawing.Size(169, 25);
            this.addPassInput.TabIndex = 3;
            // 
            // addAccountButton
            // 
            this.addAccountButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.Location = new System.Drawing.Point(560, 50);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(80, 80);
            this.addAccountButton.TabIndex = 5;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = false;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // newAccountGroup
            // 
            this.newAccountGroup.Controls.Add(this.label1);
            this.newAccountGroup.Controls.Add(this.addPassInput);
            this.newAccountGroup.Controls.Add(this.passLabel);
            this.newAccountGroup.Controls.Add(this.notesRichTextbox);
            this.newAccountGroup.Controls.Add(this.addAccountButton);
            this.newAccountGroup.Controls.Add(this.labelInput);
            this.newAccountGroup.Controls.Add(this.labelLabel);
            this.newAccountGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.newAccountGroup.Location = new System.Drawing.Point(13, 34);
            this.newAccountGroup.Name = "newAccountGroup";
            this.newAccountGroup.Size = new System.Drawing.Size(659, 181);
            this.newAccountGroup.TabIndex = 0;
            this.newAccountGroup.TabStop = false;
            this.newAccountGroup.Text = "Add New Account Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notes (optional)";
            // 
            // notesRichTextbox
            // 
            this.notesRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesRichTextbox.Location = new System.Drawing.Point(21, 110);
            this.notesRichTextbox.Name = "notesRichTextbox";
            this.notesRichTextbox.Size = new System.Drawing.Size(521, 51);
            this.notesRichTextbox.TabIndex = 4;
            this.notesRichTextbox.Text = "";
            this.notesRichTextbox.MouseHover += new System.EventHandler(this.notesRichTextbox_MouseHover);
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(21, 55);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(170, 25);
            this.labelInput.TabIndex = 1;
            this.labelInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelInput_KeyDown);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelLabel.Location = new System.Drawing.Point(18, 30);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(34, 13);
            this.labelLabel.TabIndex = 0;
            this.labelLabel.Text = "Label";
            // 
            // storedAccountGroup
            // 
            this.storedAccountGroup.Controls.Add(this.exitButton);
            this.storedAccountGroup.Controls.Add(this.accountGrid);
            this.storedAccountGroup.Controls.Add(this.copyAccountButton);
            this.storedAccountGroup.Controls.Add(this.deleteAccountButton);
            this.storedAccountGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.storedAccountGroup.Location = new System.Drawing.Point(14, 222);
            this.storedAccountGroup.Name = "storedAccountGroup";
            this.storedAccountGroup.Size = new System.Drawing.Size(658, 365);
            this.storedAccountGroup.TabIndex = 1;
            this.storedAccountGroup.TabStop = false;
            this.storedAccountGroup.Text = "Stored Account(s)";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(539, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 32);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // accountGrid
            // 
            this.accountGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.accountGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGrid.Location = new System.Drawing.Point(20, 27);
            this.accountGrid.Name = "accountGrid";
            this.accountGrid.ReadOnly = true;
            this.accountGrid.Size = new System.Drawing.Size(619, 274);
            this.accountGrid.TabIndex = 6;
            this.accountGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.accountGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountGrid_KeyDown);
            // 
            // copyAccountButton
            // 
            this.copyAccountButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copyAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.copyAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyAccountButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAccountButton.ForeColor = System.Drawing.Color.Black;
            this.copyAccountButton.Location = new System.Drawing.Point(20, 318);
            this.copyAccountButton.Name = "copyAccountButton";
            this.copyAccountButton.Size = new System.Drawing.Size(100, 32);
            this.copyAccountButton.TabIndex = 7;
            this.copyAccountButton.Text = "Copy";
            this.copyAccountButton.UseVisualStyleBackColor = false;
            this.copyAccountButton.Click += new System.EventHandler(this.copyAccountButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteAccountButton.ForeColor = System.Drawing.Color.Black;
            this.deleteAccountButton.Location = new System.Drawing.Point(126, 318);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(100, 32);
            this.deleteAccountButton.TabIndex = 8;
            this.deleteAccountButton.Text = "Delete";
            this.deleteAccountButton.UseVisualStyleBackColor = false;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // passVaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 597);
            this.Controls.Add(this.storedAccountGroup);
            this.Controls.Add(this.addUserInput);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.newAccountGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 635);
            this.MinimumSize = new System.Drawing.Size(700, 635);
            this.Name = "passVaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PassVault v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.newAccountGroup.ResumeLayout(false);
            this.newAccountGroup.PerformLayout();
            this.storedAccountGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox addUserInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.MaskedTextBox addPassInput;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.GroupBox newAccountGroup;
        private System.Windows.Forms.GroupBox storedAccountGroup;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button copyAccountButton;
        private System.Windows.Forms.TextBox labelInput;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.DataGridView accountGrid;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.RichTextBox notesRichTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asExcelSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

