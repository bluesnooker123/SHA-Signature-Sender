using CSharp_easy_RSA_PEM;
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Sender
{
    public partial class Form1 : Form
    {
        string FilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                label_fileName.Text = openFileDialog1.SafeFileName;
            }
        }

        private void button_generateSignature_Click(object sender, EventArgs e)
        {
            if (textBox_message.TextLength == 0)
            {
                MessageBox.Show("Please type message!");
                return;
            }
            if (FilePath == "")
            {
                MessageBox.Show("Please choose private key file!");
                return;
            }

            try
            {
                string loadedRSA = File.ReadAllText(FilePath);
                RSACryptoServiceProvider privateRSAkey = Crypto.DecodeRsaPrivateKey(loadedRSA);
                SHA1Managed sha1 = new SHA1Managed();
                string importantMessage = textBox_message.Text;
                byte[] importantMessageBytes = Encoding.UTF8.GetBytes(importantMessage);
                byte[] hashedMessage = sha1.ComputeHash(importantMessageBytes);

                byte[] bytes = privateRSAkey.SignHash(hashedMessage, CryptoConfig.MapNameToOID("SHA1"));
                string signature = Convert.ToBase64String(bytes);

                textBox_signature.Text = signature;
            }
            catch (Exception exp) {
                MessageBox.Show(exp.ToString());
            }            

        }
    }
}
