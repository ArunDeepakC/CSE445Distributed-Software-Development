using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewsFocusTryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_url_Click(object sender, EventArgs e)
    {
        try
        {
            //Obtain the proxy of the NewsService service
            NewsService.Service1Client proxy = new NewsService.Service1Client();
            string str = txt_topics.Text;
            //Convert text box input to an array of strings
            string[] topic_list = str.Split(' ');
            //Call the NewsFocus method using proxy
            string[] result = proxy.NewsFocus(topic_list);
            // Add the output to the result label, also check for invalid entries
            if (result != null && str!="")
            {

                lbl_url.Text = "";
                foreach (string w in result)
                {
                    lbl_url.Text += w + "<br /><br />";
                }
            }
            else
            {// Exception handling incase field is empty
                lbl_url.Text = "";
                lbl_url.Text = "Invalid Entry!";
            }
        }
        catch(Exception)
        {
            lbl_url.Text = "Invalid Entry!";
        }
    }
}