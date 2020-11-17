using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URL.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
           if(!String.IsNullOrWhiteSpace(to_encrypt.Text))
            { 
                // Create a client to connect to the encryption-decryption web service
                Encryption.ServiceClient encrypt = new Encryption.ServiceClient();
                // Call the encrypt function in the service
                decrypt_label.Text = encrypt.Encrypt(to_encrypt.Text);
            }
            else
            {// Error Message if encrypt empty 
                decrypt_label.Text = " Enter string to encrypt!";
            }
            
        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(company.Text))
            { // Create a client to the Stock Quote Web Service
                Stock.ServiceClient stock = new Stock.ServiceClient();
                // Call the getStockquote function in the web service
                stock_quote.Text = stock.getStockquote(company.Text);
            }
            else
            {// Error message if stock symbol is empty
                stock_quote.Text = "Enter Stock Symbol!";
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {// Create a client to the encrypt-decrypt web service
            Encryption.ServiceClient decrypt = new Encryption.ServiceClient();
            try
            {// Call the decrypt function in the webservice
                encrypt_label.Text = decrypt.Decrypt(to_decrypt.Text);
            }
            catch(Exception E)
            {// To handle exceptions in-case there the decrypt text does not match
                encrypt_label.Text = "Invalid Entry!";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {// Reload button of web browser
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {// Next Page button of browser
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {//Back button of web browser
            webBrowser1.GoBack();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {// Handle script errors
            webBrowser1.ScriptErrorsSuppressed = true;     
        }
    }
}
