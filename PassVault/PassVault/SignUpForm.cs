/*File: SignUpForm.cs
 * Created: September 18, 2014  
 * 
 * Copyright (c) 2014 Eric Liang http://www.eric-liang.com
 * 
 * This file is part of PassVault.
 * 
 * PassVault is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * PassVault is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with PassVault.  If not, see <http://www.gnu.org/licenses/>. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PassVault
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void sufCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sufCreateAccountButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(sufNameInput.Text.Trim()) || String.IsNullOrWhiteSpace(sufEmailInput.Text.Trim()) || String.IsNullOrWhiteSpace(sufConfirmEmailInput.Text.Trim()) || String.IsNullOrWhiteSpace(sufUsernameInput.Text.Trim()) || String.IsNullOrWhiteSpace(sufPasswordInput.Text.Trim()) || String.IsNullOrWhiteSpace(sufConfirmPasswordInput.Text.Trim()) || String.IsNullOrWhiteSpace(sufPasswordReminderInput.Text.Trim()) || (termsAgreementCheckbox.CheckState == CheckState.Unchecked))
            {
                MessageBox.Show("Please fill in all the required form fields.");
            }
            else
            {
                sufErrorProvider1.Clear();
                if (sufEmailInput.Text.Trim() != sufConfirmEmailInput.Text.Trim())
                {
                    sufErrorProvider1.SetError(sufConfirmEmailLabel, "The provided confirmation email address does not match the email address stated in the email address form field above.");
                }
                else if (sufPasswordInput.Text.Trim() != sufConfirmPasswordInput.Text.Trim())
                {
                    sufErrorProvider1.SetError(sufConfirmPasswordLabel, "The provided confirmation password does not match the password entered in the password form field above.");
                }
                else if (sufPasswordInput.Text.Trim() == sufPasswordReminderInput.Text.Trim())
                {
                    sufErrorProvider1.SetError(sufPasswordReminderLabel, "Your password reminder cannot be the same as your password. Please change your password reminder or your password.");
                }
                else if (String.IsNullOrWhiteSpace(sufDBTableNameInput.Text.Trim()))
                {
                    sufErrorProvider1.SetError(sufDBTableNameLabel, "You must enter a name for the database table that will be storing your list of PassVault Information.");
                }
                else
                {
                    Connection connector = new Connection(LoginMode.signUp, sufDBTableNameInput.Text.ToString());
                    connector.ConnectToDB();
                    string[] inputData = { sufNameInput.Text.Trim(), sufEmailInput.Text.Trim(), sufUsernameInput.Text.Trim(), sufPasswordInput.Text.Trim(), sufPasswordReminderInput.Text.Trim(), sufDBTableNameInput.Text.Trim() };
                    //START TEST
                    Encryption encryptor = new Encryption();
                    string[] EncryptedContent = encryptor.StartEncryption(inputData);
                    //END TEST
                    connector.InsertToTable(EncryptedContent);
                    connector.ShowTableData();
                    connector.CloseConnection();

                    sufFinalName.Text = sufFinalName.Text + ": " + sufNameInput.Text.Trim();
                    sufFinalEmail.Text = sufFinalEmail.Text + ": " + sufEmailInput.Text.Trim();
                    sufFinalUsername.Text = sufFinalUsername.Text + ": " + sufUsernameInput.Text.Trim();
                    sufFinalPassword.Text = sufFinalPassword.Text + ": " + sufPasswordInput.Text.Trim();
                    sufFinalPasswordHint.Text = sufFinalPasswordHint.Text + ": " + sufPasswordReminderInput.Text.Trim();
                    sufFinalDBTableName.Text = sufFinalDBTableName.Text + ": " + sufDBTableNameInput.Text.Trim();

                    signUpPanel2.Show();
                    signUpPanel1.Hide();
                }
            }
        }

        private void sufPasswordReminderInput_MouseHover(object sender, EventArgs e)
        {
            passwordReminderDisclaimer.SetToolTip(sufPasswordReminderInput, "This information will be shown after you submit the \"ForgotPasswordForm\" form, so don't make it to obvious for your own security.");
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void sufOKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
