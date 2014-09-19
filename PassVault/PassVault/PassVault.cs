/*File: PassVault.cs
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
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Configuration;

using System.Collections;

namespace PassVault
{
    public partial class passVaultForm : Form
    {
        public passVaultForm()
        {
            InitializeComponent();
        }
        SQLiteConnection DataLoadConnectionString = new SQLiteConnection(ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoadConnectionString.Open();
            try
            {
                string sql = "SELECT * FROM " + Login.info; //access global variable from Login.cs to get the tableName
                SQLiteDataAdapter adap = new SQLiteDataAdapter(sql, DataLoadConnectionString);
                System.Data.DataTable ds = new System.Data.DataTable();
                adap.Fill(ds);
                ds.Columns.RemoveAt(0); //removes ID Column since ID is NOT encrypted
                Encryption decryptor = new Encryption();
                string[] decryptedData = { };
                StringBuilder output = new StringBuilder();
                System.Data.DataTable dt = new System.Data.DataTable(); //contains decrypted information
                dt.Columns.Add("Label");
                dt.Columns.Add("Username");
                dt.Columns.Add("Password");
                dt.Columns.Add("Notes");
                foreach (DataRow row in ds.Rows)
                {
                    foreach (DataColumn col in ds.Columns)
                    {
                        output.AppendFormat("{0} ", row[col]);
                    }
                    output.AppendLine();
                    string[] stringArray = output.ToString().Split(' ').ToArray();
                    decryptedData = decryptor.StartDecryption(stringArray);
                    for(int i = 0; i < decryptedData.Count() - 3; i++)
                    {
                        DataRow rowF = dt.NewRow();
                        rowF["Label"] = decryptedData[i];
                        i++;
                        rowF["Username"] = decryptedData[i];
                        i++;
                        rowF["Password"] = decryptedData[i];
                        i++;
                        rowF["Notes"] = decryptedData[i];
                        dt.Rows.Add(rowF);
                    }
                    output.Clear();
                }
                accountGrid.DataSource = dt.DefaultView;
                DataLoadConnectionString.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (DataLoadConnectionString.State == ConnectionState.Open)
                {
                    DataLoadConnectionString.Clone();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            System.Windows.Forms.Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutBox1();
            aboutForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            int accountRowCount = accountGrid.RowCount;
            int rowIncrement = accountRowCount + 1;
            Console.Write(accountRowCount);

            //Missing Form Field Input Check
            if (labelInput.TextLength < 2 || addUserInput.TextLength < 1 || addPassInput.TextLength < 1)
            {
                MessageBox.Show("Please fill in all the form fields.");
            }
            else
            {
                Connection inserter = new Connection(LoginMode.dbLogin, Login.info);
                string[] data = { labelInput.Text.Trim(), addUserInput.Text.Trim(), addPassInput.Text.Trim(), notesRichTextbox.Text.Trim() };
                Encryption encryptInputData = new Encryption();
                string[] encryptedInputData = encryptInputData.StartEncryption(data);
                inserter.ConnectToDB();
                inserter.InsertToTable(encryptedInputData);
                //Update DataGridView Contents
                inserter.CloseConnection();
                Form1_Load(null, null);
            }
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        SQLiteConnection dbConnectorDel = new SQLiteConnection(ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString);
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete;
            DialogResult confirmDeleteWindow = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm", MessageBoxButtons.YesNo);
            int selectedRow = accountGrid.CurrentCell.RowIndex;
            switch (confirmDeleteWindow)
            {
                case DialogResult.Yes:
                    int ID = accountGrid.SelectedRows[0].Index;
                    string sql = "DELETE FROM " + Login.info + " WHERE ID = @ID";
                    commandDelete = new SQLiteCommand(sql, dbConnectorDel);
                    commandDelete.Parameters.AddWithValue("@ID", ID);
                    dbConnectorDel.Open();
                    commandDelete.ExecuteNonQuery();
                    Console.WriteLine(ID);
                    Form1_Load(null, null);
                    dbConnectorDel.Close();
                    MessageBox.Show("The selected rows has been deleted.");
                    break;
                case DialogResult.No:
                    //Nothing Happens
                    break;
            }
        }

        //Copy Selected Cell(s) Information
        private void copyAccountButton_Click(object sender, EventArgs e)
        {
            if (accountGrid.SelectedCells.Count >= 1)
            {
                Clipboard.SetDataObject(this.accountGrid.GetClipboardContent());
            }
            else
            {
                MessageBox.Show("You must select at least 1 box or at least 1 row.");
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var preferencesForm = new preferencesForm();
            preferencesForm.Show();
        }

        private void labelInput_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void accountGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //activate the confirmation function
            }
        }

        private void asExcelSpreadsheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accountGrid.CurrentCell.Value == null) //if database, maybe try DBNull.Value instead of Null
            {
                MessageBox.Show("Error! No content is detected in the datagrid.");
            }
            else
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook accountWb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

                Worksheet accountWs = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;

                //accountWs.Cells[1, 1] = "ID";
                accountWs.Cells[1, 1] = "LABEL";
                accountWs.Cells[1, 2] = "USERNAME";
                accountWs.Cells[1, 3] = "PASSWORD";
                accountWs.Cells[1, 4] = "NOTES";

                for (int j = 2; j <= accountGrid.Rows.Count; j++) //Row Start - Not 1 Because Column Labels
                {
                    for (int i = 1; i < 5; i++) //Columns
                    {
                        accountWs.Cells[j, i] = accountGrid.Rows[j - 2].Cells[i - 1].Value;
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notesRichTextbox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.notesRichTextbox, "Contents typed here will NOT be encrypted.");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.info = ""; //clear the tableName value
            accountGrid.DataSource = null; //clear DataGridView
            //LOGOUT AND END SESSION
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens HTML Help Documentation
        }
    }
}
