using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void btnSendMessage_Click(object sender, EventArgs e)
    {
        EntityContact contact= new EntityContact();
        contact.NAMESURNAME = txtNameSurname.Text;
        contact.MAIL = txtEmail.Text;
        contact.MESSAGE = txtMessage.Text;
        contact.SUBJECT = txtSubject.Text;
        BLLContact.ContactAddBLL(contact);
     
    }

    protected void btnRecourseAdd_Click(object sender, EventArgs e)
    {
       
    }
}