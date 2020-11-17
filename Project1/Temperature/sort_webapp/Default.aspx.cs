using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sort_webapp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSort_Click(object sender, EventArgs e)
        {// Create a client to the web service Sort
            Sort.Service1Client sort_num = new Sort.Service1Client();
            //Check if textbox is not null
            if (String.IsNullOrWhiteSpace(TextNum.Text))
            {
                Label2.Text = "Enter the string of numbers!";
            }
            // Call the sort function in web service
            else
            {
                Label2.Text = sort_num.sort(TextNum.Text);
            }
        }
    }
}