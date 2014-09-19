/*File: ForgotPasswordForm.cs
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
//Needed for Forgot Password Mail Functions
using System.Net;
using System.Net.Mail;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;

namespace PassVault
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            captchaCodeLabel.Text = captchaGenerator();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLICKED");
            if (String.IsNullOrWhiteSpace(fgtNameInput.Text.Trim()) && String.IsNullOrWhiteSpace(fgtEmailInput.Text.Trim()) || String.IsNullOrWhiteSpace(fgtConfirmationInput.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                MessageBox.Show("Info Accepted");
                if (fgtConfirmationInput.Text == captchaCodeLabel.Text)
                {
                    fgtConfirmationLabel.ForeColor = Color.Black;
                    MessageBox.Show("Correct!");
                    /*
                        Connection passFaultConnect = new Connection(LoginMode.mainLogin);
                     */
                    /*
                        Try Sending Email.
                        1. Connect to passvaultinfo database.
                        2. Same idea as login, but this time find the email and password that matches the username.
                        3. Store that email and password to their own variables.
                        4. Close db connection.
                        5. Prepare Certificates and Email Message Format Content.
                        6. Attempt to Send!
                            a. Success - Your password has been sent to your email address. Please check your inbox or spam folder for the message.
                            b. Fail - Error. Failed to send message. Please try again. If problem persists, please check your internet or firewall settings. If it still continues, please check your email privacy settings.
                    */
                }
                else
                {
                    fgtConfirmationLabel.ForeColor = Color.Red;
                    fgtErrorProvider1.SetError(fgtConfirmationInput, "Your input did not match the specified captcha code. Please try again.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillAllFieldsWarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private static Random random = new Random();

        //Generates a Random String Captcha Code to Prevent Spam
        private static string captchaGenerator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 5;
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            captchaCodeLabel.Text = captchaGenerator();
        }
    }
}
