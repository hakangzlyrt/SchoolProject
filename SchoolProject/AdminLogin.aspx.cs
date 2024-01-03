using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

public partial class Login : System.Web.UI.Page
{
    List<EntityAdmin> admin = BLLAdmin.BLLList();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var query = from x in admin
                    where x.USERNAME == txtUsurname.Text
                        && x.PASSWORD == txtPassword.Text
                    select x;
        if (query.Any())
        {
            Response.Redirect("Student.aspx");
        }
        else
        {
            hdnErrorMessage.Value = "Kullanıcı adı ya da şifre yanlış";
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowError", "ShowErrorMessage();", true);
        }
    }

    protected void btnUserLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserLogin.aspx");
    }
}