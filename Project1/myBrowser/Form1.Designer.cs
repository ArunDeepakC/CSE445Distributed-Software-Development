namespace myBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.URL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.message = new System.Windows.Forms.Label();
            this.to_encrypt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.decrypt_label = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.TextBox();
            this.stock_button = new System.Windows.Forms.Button();
            this.stock_quote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.encrypt_label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.to_decrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.Location = new System.Drawing.Point(301, 19);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(1053, 26);
            this.URL.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1376, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 190);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1478, 674);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.SystemColors.Control;
            this.message.Location = new System.Drawing.Point(707, 74);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(193, 20);
            this.message.TabIndex = 3;
            this.message.Text = "Enter Message to Encrypt";
            // 
            // to_encrypt
            // 
            this.to_encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to_encrypt.Location = new System.Drawing.Point(947, 68);
            this.to_encrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.to_encrypt.Name = "to_encrypt";
            this.to_encrypt.Size = new System.Drawing.Size(170, 26);
            this.to_encrypt.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1148, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // decrypt_label
            // 
            this.decrypt_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decrypt_label.AutoSize = true;
            this.decrypt_label.BackColor = System.Drawing.SystemColors.Control;
            this.decrypt_label.Location = new System.Drawing.Point(1304, 75);
            this.decrypt_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decrypt_label.Name = "decrypt_label";
            this.decrypt_label.Size = new System.Drawing.Size(0, 20);
            this.decrypt_label.TabIndex = 6;
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(13, 98);
            this.company.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(148, 26);
            this.company.TabIndex = 7;
            // 
            // stock_button
            // 
            this.stock_button.Location = new System.Drawing.Point(194, 94);
            this.stock_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(115, 30);
            this.stock_button.TabIndex = 8;
            this.stock_button.Text = "Get Stock Quote";
            this.stock_button.UseVisualStyleBackColor = true;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // stock_quote
            // 
            this.stock_quote.AutoSize = true;
            this.stock_quote.Location = new System.Drawing.Point(121, 136);
            this.stock_quote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock_quote.Name = "stock_quote";
            this.stock_quote.Size = new System.Drawing.Size(0, 20);
            this.stock_quote.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the stock symbol:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(194, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 40);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(101, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "reload.png");
            // 
            // encrypt_label
            // 
            this.encrypt_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encrypt_label.AutoSize = true;
            this.encrypt_label.BackColor = System.Drawing.SystemColors.Control;
            this.encrypt_label.Location = new System.Drawing.Point(1304, 128);
            this.encrypt_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encrypt_label.Name = "encrypt_label";
            this.encrypt_label.Size = new System.Drawing.Size(0, 20);
            this.encrypt_label.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(1148, 121);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 16;
            this.button6.Text = "Decrypt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // to_decrypt
            // 
            this.to_decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to_decrypt.Location = new System.Drawing.Point(947, 121);
            this.to_decrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.to_decrypt.Name = "to_decrypt";
            this.to_decrypt.Size = new System.Drawing.Size(170, 26);
            this.to_decrypt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(707, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Message to Decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stock Quote:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encrypt_label);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.to_decrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stock_quote);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.company);
            this.Controls.Add(this.decrypt_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.to_encrypt);
            this.Controls.Add(this.message);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.URL);
            this.MinimumSize = new System.Drawing.Size(1489, 893);
            this.Name = "Form1";
            this.Text = "myBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox to_encrypt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label decrypt_label;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Label stock_quote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox to_decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

