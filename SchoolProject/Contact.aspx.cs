using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

public partial class Contact : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<EntityContact> contactList = BLLContact.BLLList();
            Repeater1.DataSource = contactList;
            Repeater1.DataBind();
        }
    }
}