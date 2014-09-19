/*File: Connection.cs
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
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;

//FOR MESSAGEBOX DEBUGGING
using System.Windows.Forms;

namespace PassVault
{
    public enum LoginMode { mainLogin, dbLogin, signUp };

    class Connection
    {
        private LoginMode loginMode;

        private string accountUsername;
        private string accountPassword;

        //DATABASE NAMES
        private string pvaultinfo_programDB = "pvaultinfo_programDB";
        private string pvaultinfo_offlineDB = "pvaultinfo_offlineDB";

        //DATABASE FILE DIRECTORY
        private string path_programDB = @"data/pvaultinfo_programDB.sqlite";
        private string path_offlineDB = @"data/pvaultinfo_offlineDB.sqlite";

        //TABLE NAMES
        //Program Accounts Stored = users_programTB
        private string tableName;

        //CONNECTION STRINGS
        private SQLiteConnection mainDBConnection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);
        private SQLiteConnection dataDBConnection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString);

        ////////////////
        //CONSTRUCTORS//
        ////////////////

        //Forgot Password, etc...
        public Connection(LoginMode m)
        {
            loginMode = m;
        }

        //Login
        public Connection(LoginMode m, string u, string p)
        {
            loginMode = m;
            accountUsername = u;
            accountPassword = p;
        }

        //Data + SignUp
        public Connection(LoginMode m, string tbN)
        {
            loginMode = m;
            tableName = tbN;
        }

        ///////////
        //METHODS//
        ///////////

        //Database Existence Check
        private void DBExistsCheck()
        {
            if (!File.Exists(@"data"))
            {
                Directory.CreateDirectory("data");
                string readmePath = @"data/IMPORTANT_READ_ME.txt";
                if (!File.Exists(readmePath))
                {
                    File.Create(readmePath).Dispose();
                    using (StreamWriter sw = File.CreateText(readmePath))
                    {
                        sw.WriteLine("WARNING! \r\n DO NOT DELETE the files in the data folder! They are the database files that contain all the user information and the information that is accessed by each user. \r\n IF you delete the files, then all the information will be lost and users will need to recreate their account(s)! \r\n Thank you for your time to read this very important message. \r\n\n\n DISCLAIMER: We are not responsible should anything happen to your database files.");
                        sw.Close();
                    }
                }
                else if (File.Exists(readmePath))
                {
                    //Nothing Happens
                }
            }

            if (!File.Exists(path_programDB)) //user accounts DB make
            {
                SQLiteConnection.CreateFile("data/" + pvaultinfo_programDB + ".sqlite");
                mainDBConnection.Open();
                string sql = "CREATE TABLE users_programTB(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(512) NOT NULL, Email varchar(512) NOT NULL, Username varchar(512) UNIQUE, Password varchar(512) NOT NULL, PasswordHint text NOT NULL, DB_Table_Name varchar(512) UNIQUE)";
                SQLiteCommand command = new SQLiteCommand(sql, mainDBConnection);
                command.ExecuteNonQuery();
                mainDBConnection.Close();
            }
            if (!File.Exists(path_offlineDB)) //data DB make
            {
                SQLiteConnection.CreateFile("data/" + pvaultinfo_offlineDB + ".sqlite");
            }
        }

        //Missing TB or new TB from SignUp
        public void createTable()
        {
            dataDBConnection.Open();
            string sql = "CREATE TABLE IF NOT EXISTS " + tableName + "(ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Label varchar(512) NOT NULL, Username varchar(512) NOT NULL, Password varchar(512) NOT NULL, Notes varchar(512) NOT NULL)";
            SQLiteCommand command = new SQLiteCommand(sql, dataDBConnection);
            command.ExecuteNonQuery();
            dataDBConnection.Close();
        }

        //Start DB Connection for Program Use
        public void ConnectToDB()
        {
            DBExistsCheck();
            switch (loginMode)
            { 
                case LoginMode.mainLogin:
                    mainDBConnection.Open();
                    break;
                case LoginMode.dbLogin:
                    createTable(); //Checks if user's table exists and if needs to be created 
                    dataDBConnection.Open(); //Opens after because createTable() has its own open/close
                    //open database table with tableName value and display the values in the datagridview
                    break;
                case LoginMode.signUp:
                    mainDBConnection.Open();
                    dataDBConnection.Open();
                    break;
            }
        }

        //To Close Connection From Objects in Other Class Files
        public void CloseConnection()
        {
            switch (loginMode)
            { 
                case LoginMode.mainLogin:
                    mainDBConnection.Close();
                    break;
                case LoginMode.dbLogin:
                    dataDBConnection.Close();
                    break;
                case LoginMode.signUp:
                    mainDBConnection.Close();
                    dataDBConnection.Close();
                    break;
            }
        }

        //Adds Data to Table From SignUp OR New Data Entry
        public void InsertToTable(string[] dataList)
        {
            //Insertion Process Depending on Mode
            string sql;
            SQLiteCommand command;
            switch (loginMode)
            { 
                case LoginMode.signUp:
                        //CHECK FOR UNIQUENESS OF USERNAME AND DB_TABLE_NAME!!!
                        sql = "INSERT INTO users_programTB(Name, Email, Username, Password, PasswordHint, DB_Table_Name) VALUES(@Name, @Email, @Username, @Password, @PasswordHint, @DB_Table_Name)";
                        command = new SQLiteCommand(sql, mainDBConnection);
                        command.Parameters.AddWithValue("@Name", dataList[0]);
                        command.Parameters.AddWithValue("@Email", dataList[1]);
                        command.Parameters.AddWithValue("@Username", dataList[2]);
                        command.Parameters.AddWithValue("@Password", dataList[3]);
                        command.Parameters.AddWithValue("@PasswordHint", dataList[4]);
                        command.Parameters.AddWithValue("@DB_Table_Name", dataList[5]);
                        command.ExecuteNonQuery();
                    break;
                case LoginMode.dbLogin:
                        sql = "INSERT INTO " + tableName + "(Label, Username, Password, Notes) VALUES(@Label, @Username, @Password, @Notes)";
                        command = new SQLiteCommand(sql, dataDBConnection);
                        command.Parameters.AddWithValue("@Label", dataList[0]);
                        command.Parameters.AddWithValue("@Username", dataList[1]);
                        command.Parameters.AddWithValue("@Password", dataList[2]);
                        command.Parameters.AddWithValue("@Notes", dataList[3]);
                        command.ExecuteNonQuery();
                    break;
            }

        }

        public string LoginCheck()
        {   //MAYBE Add a MUST LoginMode.mainLogin to use this method.
            //Already Connected Once Called Upon
            //Start Comparing Data
            SQLiteCommand command = new SQLiteCommand("SELECT Username, Password, DB_Table_Name FROM users_programTB", mainDBConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Username"].ToString() == accountUsername)
                {
                    Console.WriteLine("Username Matches Database Username!");
                    Console.WriteLine(reader["Username"]);
                    if (reader["Password"].ToString() == accountPassword)
                    {
                        Console.WriteLine("Password Found Corresponding Match!");
                        Console.WriteLine(reader["Password"]);
                        return (string)reader["DB_Table_Name"];
                        //break;
                    }
                    else
                    {
                        Console.WriteLine("Password DOES NOT MATCH!");
                    }
                }
                else
                {
                    Console.WriteLine("Username DOES NOT MATCH!");
                }
            }
            return null;
        }

        //For Override and Program Display (dbLogin)
        public void ShowTableData()
        {
            string sql;
            SQLiteCommand command;
            SQLiteDataReader reader;
            Encryption decryptor = new Encryption();
            switch (loginMode)
            { 
                case LoginMode.mainLogin:
                    sql = "SELECT * FROM " + "users_programTB";
                    command = new SQLiteCommand(sql, mainDBConnection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] data = { reader["Name"].ToString(), reader["Email"].ToString(), reader["Username"].ToString(), reader["Password"].ToString(), reader["PasswordHint"].ToString(), reader["DB_Table_Name"].ToString() };
                        Console.Write(reader["ID"] + "   ");
                        Console.WriteLine(String.Join(" ", decryptor.StartDecryption(data)));
                    }
                    break;
                case LoginMode.dbLogin:
                    sql = "SELECT * FROM " + tableName;
                    command = new SQLiteCommand(sql, dataDBConnection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("ID: " + reader["ID"] + "\tUsername: " + reader["Username"] + "\tPassword: " + reader["Password"] + "\tNotes: " + reader["Notes"]);
                    }
                    break;
            }
        }
    }
}
