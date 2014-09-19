/*File: Login.cs
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
using System.IO;
using System.Runtime.InteropServices; //for console window
using System.Configuration;
using System.Data.SqlClient;

namespace PassVault
{
    public partial class Login : Form
    {
        public static string info; //to store tableName to send to passvault
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            invalidMemberLoginWarningLabel.Hide();
            adminOverrideAccessCheckbox.CheckState = CheckState.Unchecked; //extra reassurance
        }

        //Creates Console Window
        [DllImport("kernel32.dll")]
        public static extern Int32 AllocConsole();

        private void mainLoginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(mainUsernameInput.Text) || String.IsNullOrWhiteSpace(mainPasswordInput.Text))
            {
                MessageBox.Show("Please fill in all the required form fields.");
            }
            else
            {
                string[] loginData = {mainUsernameInput.Text.Trim().ToString(), mainPasswordInput.Text.Trim().ToString()};
                Encryption loginEncryptor = new Encryption();
                string[] encryptedLoginData = loginEncryptor.StartEncryption(loginData);
                Connection pvLoginConnect = new Connection(LoginMode.mainLogin, encryptedLoginData[0], encryptedLoginData[1]);
                switch (adminOverrideAccessCheckbox.CheckState)
                {
                    case CheckState.Unchecked:
                        //Connect & Compare User Input to Database
                        pvLoginConnect.ConnectToDB();
                        Encryption tableNameDecryptor = new Encryption();
                        info = tableNameDecryptor.SingleDecryption(pvLoginConnect.LoginCheck()); //info contains the tableName needed to be displayed
                        
                        switch (String.IsNullOrEmpty(info))
                        { 
                            case true:
                                //Nothing Happens
                                break;
                            case false:
                                //Load Table Data Corresponding to User
                                passVaultForm mainProg = new passVaultForm(); 
                                mainProg.Show();
                                break;
                        }
                        pvLoginConnect.CloseConnection();
                        break;
                    case CheckState.Checked:
                        MessageBox.Show("OVERRIDE LOGIN ENABLED!");
                        //Look for File Directory for Offline Access after Online Connection Made.
                        //OFFLINE OVERRIDE
                        string[] tempOvAct = new string[File.ReadLines(@"C:\Users\Eric Liang\Desktop\XP6VV.txt").Count()];
                        using (StreamReader sr = File.OpenText(@"C:\Users\Eric Liang\Desktop\XP6VV.txt"))
                        {
                            for (int i = 0; i < File.ReadLines(@"C:\Users\Eric Liang\Desktop\XP6VV.txt").Count(); i++)
                            {
                                tempOvAct[i] = sr.ReadLine().Trim();
                            } 
                        }
                        if (mainUsernameInput.Text == tempOvAct[0] && mainPasswordInput.Text == tempOvAct[1])
                        {
                            MessageBox.Show("OVERRIDE ACCESS GRANTED. Loading Data...");
                            System.Threading.Thread.Sleep(5000); //Delay Time for Console Window to Load All Data Otherwise Blankout
                            AllocConsole(); //Opens Console Window
                            Connection Override = new Connection(LoginMode.mainLogin);
                            Override.ConnectToDB();
                            Override.ShowTableData();
                            Override.CloseConnection();
                        }
                        else
                        {
                            MessageBox.Show("Error! Wrong Information.");
                        }
                        break;
                    default:
                        MessageBox.Show("Uh oh, something went horribly wrong.");
                        break;
                }
            }
        }

        private void signupLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotpassForm = new ForgotPasswordForm();
            forgotpassForm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.F3))
            {
                MessageBox.Show("Secret Shortcut Combo Clicked");
                switch (adminOverrideAccessCheckbox.CheckState)
                { 
                    case CheckState.Checked:
                        adminOverrideAccessCheckbox.Checked = false;
                        MessageBox.Show("Override now disabled.");
                        break;
                    case CheckState.Unchecked:
                        adminOverrideAccessCheckbox.Checked = true;
                        MessageBox.Show("Override now enabled.");
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
