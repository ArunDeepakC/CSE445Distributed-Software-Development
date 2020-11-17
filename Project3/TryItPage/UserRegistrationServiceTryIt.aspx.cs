using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserRegistrationServiceTryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_register_Click(object sender, EventArgs e)
    {
        // Create Proxy to registration service
        UserRegistration.Service1Client proxy = new UserRegistration.Service1Client();

        //Ensure entry not null
        if (!String.IsNullOrWhiteSpace(txt_user.Text) && !String.IsNullOrWhiteSpace(txt_pass.Text))
        {
            //Call the operation to register
            Boolean created = proxy.registerUser(txt_user.Text, txt_pass.Text);

            //Set label to the apt response
            if (created)
            {
                lbl_register.Text = "User successfully Registered!";
            }
            else
            {
                lbl_register.Text = "User already registered to service!";
            }
        }
        else
        {
            lbl_register.Text = "Enter Valid Username and password!";
        }
    }
}