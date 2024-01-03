using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class StudentDelete : System.Web.UI.Page
{
     
    protected void Page_Load(object sender, EventArgs e)
    {
        int findId = Convert.ToInt32(Request.QueryString["STUDENTID"]);
        Response.Write(findId);
        EntityStudent student = new EntityStudent();
        student.ID = findId;
        BLLStudent.StudentDeleteBLL(student.ID);
        Response.Redirect("Student.aspx");
    }
}