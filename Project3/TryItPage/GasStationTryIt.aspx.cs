using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public partial class GasStationTryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {    
        lbl_output.Text = "";
        string address = txt_address.Text;

        try
        {  //Call the GasStationService restful api and receive its response
            using (var webClient = new WebClient())
            {


                string response = webClient.DownloadString("http://webstrar5.fulton.asu.edu/page3/api/GasStation/" + address);
                string[] result = response.Split(',');
                // dsiplay result in label
                foreach (var item in result)
                {

                    lbl_output.Text += item.ToString() + "<br />";
                }
            }
        }
        catch (Exception)
        { // Exception handling in case field is empty
            lbl_output.Text = "Invalid Address!";
        }

        }

    }
