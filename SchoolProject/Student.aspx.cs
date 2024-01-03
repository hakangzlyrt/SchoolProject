using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class StudentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Sayfa ilk yüklendiğinde çalışacak kodlar
            List<EntityStudent> students = BLLStudent.BLLList();
            Repeater1.DataSource = students;
            Repeater1.DataBind();
        }
    }
}