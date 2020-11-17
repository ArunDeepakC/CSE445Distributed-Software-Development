using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NaturalHazardTryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_getresult_Click(object sender, EventArgs e)
    {
        try
        {
            // obtain values from text box
            decimal latitude = Convert.ToDecimal(txt_latitude.Text);
            decimal longitude = Convert.ToDecimal(txt_longitude.Text);
            //Check if it is a valid latitude and longitude
            if (latitude>=-90 && latitude<=90&&longitude>=-180&&longitude<=180)
            {
                // Obtain a proxy of the Natural Hazards Service
                NaturalHazardService.Service1Client proxy = new NaturalHazardService.Service1Client();
                //Call the NaturalHazards method of NaturalHazardService using the proxy
                decimal result = proxy.NaturalHazards(latitude, longitude);
                //Store the value in the result label
                lbl_result.Text = result.ToString();
            }
            else { lbl_result.Text = "Enter valid latitude and longitude!"; }
        }
        catch(Exception)
        {// Exception handling in case of invalid entry
            lbl_result.Text = "Enter valid latitude and longitude!";
        }
    }
}