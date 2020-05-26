﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;
namespace EncryptionDecryption
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public string cyphertext;
        private void btnET_Click(object sender, EventArgs e)
        {

            UnicodeEncoding encoding = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            byte[] plaintext;
            byte[] cyphertext;
            var Etext = text1.Text;
            if (!string.IsNullOrEmpty(Etext))
            {
                plaintext = encoding.GetBytes(Etext);
                var rsaparam = rsa.ExportParameters(false);
                cyphertext = RsaEnc.Encrypt(plaintext, rsa.ExportParameters(false), false);
                var encryptedtext = encoding.GetString(cyphertext);
                txtbET.Text = encryptedtext;

            }
            else
            {
                MessageBox.Show("!!!!  FILL THE REQUIRED FIELD  !!!!");

            }
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            byte[] plaintext;
            byte[] cyphertext;
            var Etext = text1.Text;
            if (!string.IsNullOrEmpty(Etext))
            {
                plaintext = encoding.GetBytes(Etext);
                var rsaparam = rsa.ExportParameters(false);
                cyphertext = RsaEnc.Encrypt(plaintext, rsa.ExportParameters(false), false);
                byte[] decryptedtext = RsaEnc.Decrypt(cyphertext, rsa.ExportParameters(true), false);
                txtbDT.Text = encoding.GetString(decryptedtext);

            }

            else
            {
                MessageBox.Show("!!!!  FILL THE REQUIRED FIELD  !!!!");

            }
        }
    }

    public class RsaEnc
    {
        public static byte[] Encrypt(byte[] data, RSAParameters rsakey, bool doPadding)
        {

            
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(rsakey);
                    var endData = rsa.Encrypt(data, doPadding);
                    return endData;
                }
            
            
        }

        public static byte[] Decrypt(byte[] data, RSAParameters rsakey, bool doPadding)
        {
            
                byte[] decryptData;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(rsakey);
                    decryptData = rsa.Decrypt(data, doPadding);
                    return decryptData;
                }

          

            

        }
    }
}



