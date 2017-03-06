using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        CAServiceReference.CAServiceClient cas = 
            new CAServiceReference.CAServiceClient();
        int key = cas.PersonLogin(UserNameTextBox.Text,PasswordTextBox.Text);
        if(key != 0)//if key is not equal to zero, then legit key. Otherwise login failed
        {
            Session["userkey"] = key;
            Response.Redirect("GrantPage.aspx");
        }
        else
        {
            ResultLabel.Text = "Login failed";
        }

    }
}