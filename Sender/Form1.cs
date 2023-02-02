using CSharp_easy_RSA_PEM;
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;

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

                dynamic deserializedObject = JsonConvert.DeserializeObject(textBox_inputJSON.Text.Length != 0 ? textBox_inputJSON.Text : "[]");
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

        private void button_send_Click(object sender, EventArgs e)
        {
            if (textBox_JSON.TextLength == 0)
            {
                MessageBox.Show("Please generate JSON string!");
                return;
            }
            if (textBox_signature.TextLength == 0)
            {
                MessageBox.Show("Please generate signature!");
                return;
            }
            if (textBox_endpoint.TextLength == 0)
            {
                MessageBox.Show("Please input endpoint!");
                return;
            }
            if (textBox_bearerToken.TextLength == 0)
            {
                MessageBox.Show("Please input bearer token!");
                return;
            }

            try
            {
                textBox_response.Text = "";
                string jsonToSend = textBox_JSON.Text;
                string signature = textBox_signature.Text;

                string[] tempStrArray = textBox_endpoint.Text.Split('/');
                string endpoint = tempStrArray[tempStrArray.Length - 1];
                string serviceURL = "";
                for (int i = 0; i < tempStrArray.Length - 1; i++)
                {
                    serviceURL += tempStrArray[i] + '/';
                }

                var client = new RestClient(serviceURL);
                var request = new RestRequest(endpoint, radioButton_GET.Checked ? Method.Get : Method.Post);

                request.AddHeader("Authorization", string.Format("Bearer {0}", textBox_bearerToken.Text));
                request.AddHeader("x-signature", signature);

                if ( radioButton_GET.Checked )  // GET
                {
                    if ( textBox_JSON.Text != "[]" )
                    {
                        var deserializedObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonToSend);
                        foreach (var pair in deserializedObject)
                        {
                            request.AddParameter(pair.Key, pair.Value);
                        }
                    }
                }
                else  // POST
                {
                    request.AddParameter("application/json", jsonToSend, ParameterType.RequestBody);
                }


                RestResponse response = client.Execute(request);

                if (response.ResponseStatus == ResponseStatus.Error)
                {
                    if (response.ErrorMessage != null)
                        MessageBox.Show(response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(response.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string content = response.Content; // Raw content as string
                textBox_response.Text = content;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }
    }
}
