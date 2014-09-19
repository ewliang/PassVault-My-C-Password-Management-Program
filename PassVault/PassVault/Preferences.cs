/*File: Preferences.cs
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
using System.Data.SQLite;
using System.Configuration;

namespace PassVault
{
    public partial class preferencesForm : Form
    {
        public preferencesForm()
        {
            InitializeComponent();
        }

        private void dbConnectButton_Click(object sender, EventArgs e)
        {
            if (dbHostInput.TextLength < 1 || dbUserInput.TextLength < 1 || dbPassInput.TextLength < 1)
            {
                MessageBox.Show("Please fill in all the required form fields.");
            }
            else { 
                //continue with connection process using try/catch!!!
                try
                {
                    
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void preferencesExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stayConnectedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            switch (stayConnectedCheckbox.Checked)
            { 
                case true:
                    dbHostInput.Text = dbHostInput.Text;
                    dbUserInput.Text = dbUserInput.Text;
                    dbPassInput.Text = dbPassInput.Text;
                    MessageBox.Show("YES");
                    break;
                case false:
                default:
                    //Nothing Happens
                    break;
            }
        }

        SQLiteConnection DataLoadConnectionString = new SQLiteConnection(ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmDeleteAccountWindow = MessageBox.Show("You are about to delete your PassVault account. Doing so WILL REMOVE ALL CONTENTS in your database. Make sure you've already backed up all your information. Are you absolutely positively sure you WANT TO DELETE your account?", "Confirm", MessageBoxButtons.YesNo);

            switch (confirmDeleteAccountWindow)
            { 
                case DialogResult.Yes:
                    try
                    {
                        DataLoadConnectionString.Open();
                        string sql = "DROP TABLE IF EXISTS pvaultinfo_offlineDB." + Login.info;
                        SQLiteCommand commandDropTB = new SQLiteCommand(sql, DataLoadConnectionString);
                        commandDropTB.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    MessageBox.Show("Your account has been deleted. All information in the account's database has been cleared.");
                    Application.Exit();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Account deletion has been cancelled.");
                    break;
            }
        }

        //SQLiteConnection UsersConnectionString = new SQLiteConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);
        private void confirmPasswordButton_Click(object sender, EventArgs e)
        {
            switch (editAccountInfoPasswordInput.Text.Trim())
            {
                case "123":
                    MessageBox.Show("Password confirmed. You may now edit your account information.");
                    editAccountInfoButton.Enabled = true;
                    prefDeleteAccountButton.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Invalid password. Please try again.");
                    break;
            }
        }

        private void updateStorageModeButton_Click(object sender, EventArgs e)
        {
            if (onlineStorageRadiobutton.Checked == true)
            {
                MessageBox.Show("Coming Soon!");
                onlineStorageRadiobutton.Checked = false;
                offlineStorageRadiobutton.Checked = true;
            }
        }

        private void editAccountInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            { 
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
