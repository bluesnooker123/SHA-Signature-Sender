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
            this.label_fileName.Location = new System.Drawing.Point(91, 472);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(216, 20);
            this.label_fileName.TabIndex = 2;
            this.label_fileName.Text = "Please choose private key file";
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.Location = new System.Drawing.Point(326, 464);
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
            this.button_generateSignature.Location = new System.Drawing.Point(536, 464);
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
            this.label3.Location = new System.Drawing.Point(452, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature";
            // 
            // textBox_signature
            // 
            this.textBox_signature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_signature.Location = new System.Drawing.Point(536, 78);
            this.textBox_signature.Multiline = true;
            this.textBox_signature.Name = "textBox_signature";
            this.textBox_signature.ReadOnly = true;
            this.textBox_signature.Size = new System.Drawing.Size(355, 363);
            this.textBox_signature.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "JSON String";
            // 
            // textBox_inputJSON
            // 
            this.textBox_inputJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputJSON.Location = new System.Drawing.Point(136, 26);
            this.textBox_inputJSON.Multiline = true;
            this.textBox_inputJSON.Name = "textBox_inputJSON";
            this.textBox_inputJSON.Size = new System.Drawing.Size(300, 415);
            this.textBox_inputJSON.TabIndex = 7;
            // 
            // textBox_JSON
            // 
            this.textBox_JSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_JSON.Location = new System.Drawing.Point(536, 26);
            this.textBox_JSON.Name = "textBox_JSON";
            this.textBox_JSON.ReadOnly = true;
            this.textBox_JSON.Size = new System.Drawing.Size(355, 26);
            this.textBox_JSON.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "JSON";
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(767, 464);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(124, 37);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 523);
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
    }
}

