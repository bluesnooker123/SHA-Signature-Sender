namespace Sender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_fileName = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.button_generateSignature = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_signature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_inputJSON = new System.Windows.Forms.TextBox();
            this.textBox_JSON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_endpoint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_GET = new System.Windows.Forms.RadioButton();
            this.radioButton_POST = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_bearerToken = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_response = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pem Files (*.pem) | *.pem";
            // 
            // label_fileName
            // 
            this.label_fileName.AutoSize = true;
            this.label_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileName.Location = new System.Drawing.Point(13, 313);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(167, 20);
            this.label_fileName.TabIndex = 2;
            this.label_fileName.Text = "Choose private key file";
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.Location = new System.Drawing.Point(185, 305);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(110, 37);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_generateSignature
            // 
            this.button_generateSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generateSignature.Location = new System.Drawing.Point(306, 305);
            this.button_generateSignature.Name = "button_generateSignature";
            this.button_generateSignature.Size = new System.Drawing.Size(200, 37);
            this.button_generateSignature.TabIndex = 4;
            this.button_generateSignature.Text = "Generate Signature";
            this.button_generateSignature.UseVisualStyleBackColor = true;
            this.button_generateSignature.Click += new System.EventHandler(this.button_generateSignature_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature";
            // 
            // textBox_signature
            // 
            this.textBox_signature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_signature.Location = new System.Drawing.Point(99, 404);
            this.textBox_signature.Multiline = true;
            this.textBox_signature.Name = "textBox_signature";
            this.textBox_signature.ReadOnly = true;
            this.textBox_signature.Size = new System.Drawing.Size(415, 361);
            this.textBox_signature.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "JSON String";
            // 
            // textBox_inputJSON
            // 
            this.textBox_inputJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputJSON.Location = new System.Drawing.Point(126, 18);
            this.textBox_inputJSON.Multiline = true;
            this.textBox_inputJSON.Name = "textBox_inputJSON";
            this.textBox_inputJSON.Size = new System.Drawing.Size(388, 279);
            this.textBox_inputJSON.TabIndex = 7;
            // 
            // textBox_JSON
            // 
            this.textBox_JSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_JSON.Location = new System.Drawing.Point(99, 352);
            this.textBox_JSON.Name = "textBox_JSON";
            this.textBox_JSON.ReadOnly = true;
            this.textBox_JSON.Size = new System.Drawing.Size(415, 26);
            this.textBox_JSON.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "JSON";
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(942, 499);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(124, 37);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Endpoint";
            // 
            // textBox_endpoint
            // 
            this.textBox_endpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_endpoint.Location = new System.Drawing.Point(606, 18);
            this.textBox_endpoint.Name = "textBox_endpoint";
            this.textBox_endpoint.Size = new System.Drawing.Size(522, 26);
            this.textBox_endpoint.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Method";
            // 
            // radioButton_GET
            // 
            this.radioButton_GET.AutoSize = true;
            this.radioButton_GET.Checked = true;
            this.radioButton_GET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_GET.Location = new System.Drawing.Point(36, 3);
            this.radioButton_GET.Name = "radioButton_GET";
            this.radioButton_GET.Size = new System.Drawing.Size(60, 24);
            this.radioButton_GET.TabIndex = 15;
            this.radioButton_GET.TabStop = true;
            this.radioButton_GET.Text = "GET";
            this.radioButton_GET.UseVisualStyleBackColor = true;
            // 
            // radioButton_POST
            // 
            this.radioButton_POST.AutoSize = true;
            this.radioButton_POST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_POST.Location = new System.Drawing.Point(134, 3);
            this.radioButton_POST.Name = "radioButton_POST";
            this.radioButton_POST.Size = new System.Drawing.Size(69, 24);
            this.radioButton_POST.TabIndex = 16;
            this.radioButton_POST.Text = "POST";
            this.radioButton_POST.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_GET);
            this.panel1.Controls.Add(this.radioButton_POST);
            this.panel1.Location = new System.Drawing.Point(606, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 30);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bearer Token";
            // 
            // textBox_bearerToken
            // 
            this.textBox_bearerToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bearerToken.Location = new System.Drawing.Point(531, 77);
            this.textBox_bearerToken.Multiline = true;
            this.textBox_bearerToken.Name = "textBox_bearerToken";
            this.textBox_bearerToken.Size = new System.Drawing.Size(597, 415);
            this.textBox_bearerToken.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Response";
            // 
            // textBox_response
            // 
            this.textBox_response.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_response.Location = new System.Drawing.Point(606, 544);
            this.textBox_response.Multiline = true;
            this.textBox_response.Name = "textBox_response";
            this.textBox_response.ReadOnly = true;
            this.textBox_response.Size = new System.Drawing.Size(522, 221);
            this.textBox_response.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 786);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_response);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_bearerToken);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_endpoint);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_JSON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_inputJSON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_signature);
            this.Controls.Add(this.button_generateSignature);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label_fileName);
            this.Name = "Form1";
            this.Text = "Sender";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_generateSignature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_signature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_inputJSON;
        private System.Windows.Forms.TextBox textBox_JSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_endpoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_GET;
        private System.Windows.Forms.RadioButton radioButton_POST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_bearerToken;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_response;
    }
}

