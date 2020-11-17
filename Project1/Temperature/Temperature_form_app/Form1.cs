using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// Create a client to connect to the temperature conversion web service
            TempService.Service1Client tempService = new TempService.Service1Client();
            //Check if textbox is not null and digit
            if (String.IsNullOrWhiteSpace(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                label5.Text = "Enter the celcius value!";
            }
            else
            {
                //Call the c2f operation through the client
                int f = tempService.c2f(int.Parse(textBox1.Text));
                //Display the converted value in label
                label5.Text = f.ToString() + "°F";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {// Create a client to connect to the temperature conversion web service
            TempService.Service1Client tempService = new TempService.Service1Client();
            //Check if textbox is not null and digit
            if (String.IsNullOrWhiteSpace(textBox2.Text) || !textBox2.Text.All(char.IsDigit))
            {
                label6.Text = "Enter the Fahrenheit value!";
            }
            else
            {
                //Call the f2c operation through the client
                int c = tempService.f2c(int.Parse(textBox2.Text));
                //Display the converted value in label
                label6.Text = c.ToString() + "°C";
            }
        }
    }
}
