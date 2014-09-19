/*File: Encryption.cs
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
using System.Security.Cryptography;

namespace PassVault
{
    class Encryption
    {
        private static string Key = "eTxnu6AvGNjRjgrF62w8CcBzDSYMpAer";
        private static string IV = "CSnZSqjgJYjZuv8m";

        //Default Constructor
        public Encryption() { }

        //Start Encryption Process
        public string[] StartEncryption(string[] inputData)
        {
            var encryptedArrayofData = new List<string>();
            foreach(string value in inputData)
            {
                encryptedArrayofData.Add(Encrypt(value));
                //TEST CODE TO TEST ENCRYPTION IN SIGNUPFORM.CS
            }
            return encryptedArrayofData.ToArray();
        }

        //Start Decryption Process
        public string[] StartDecryption(string[] encryptedInputData)
        {
            var decryptedArrayofData = new List<string>();
            foreach (string value in encryptedInputData)
            {
                decryptedArrayofData.Add(Decrypt(value));
            }
            return decryptedArrayofData.ToArray();
        }

        public string SingleDecryption(string input)
        {
            string decryptedInput = Decrypt(input);
            return decryptedInput;
        }


        //Final AES256 ASCII Encryption
        private static string Encrypt(string rawData)
        {
            byte[] plainTextBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(rawData);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encryptedContent = crypto.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
            crypto.Dispose();
            string temp = Convert.ToBase64String(encryptedContent);
            //Console.WriteLine("Encrypted: " + temp);
            return temp;
        }

        //Decrypting AES256 ASCII Encrypted Contents
        private static string Decrypt(string encryptedData)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] levelOneOutput = crypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            crypto.Dispose();
            string temp = System.Text.ASCIIEncoding.ASCII.GetString(levelOneOutput);
            //Console.WriteLine("Decrypted: " + temp);
            return temp;
        }
        //After each completed hashed information, set the temporary stored raw info = null; for security reasons
    }
}
