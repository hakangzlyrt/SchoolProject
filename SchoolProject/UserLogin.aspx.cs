using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class UserLogin : System.Web.UI.Page
{
    List<EntityUser> user = BLLUser.BLLList();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var query = from x in user
                    where x.USERNAME == txtUsurname.Text
                        && x.PASSWORD == txtPassword.Text
                    select x;
        if (query.Any())
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            hdnErrorMessage.Value = "Kullanıcı adı ya da şifre yanlış";
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowError", "ShowErrorMessage();", true);
        }
    }
}