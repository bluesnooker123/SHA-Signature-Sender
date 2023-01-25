using CSharp_easy_RSA_PEM;
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            if (textBox_inputJSON.TextLength == 0)
            {
                MessageBox.Show("Please type JSON String!");
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

                dynamic deserializedObject = JsonConvert.DeserializeObject(textBox_inputJSON.Text);
                string json = JsonConvert.SerializeObject(deserializedObject);

                textBox_JSON.Text = json;

                string importantMessage = json;
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
