using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class StudentAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnStudentAdd_Click(object sender, EventArgs e)
    {
        EntityStudent student = new EntityStudent();
        student.NAME = txtStudentName.Text;
        student.SURNAME = txtStudentSurname.Text;
        student.NUMBER = txtStudentNumber.Text;
        student.PHOTOGRAPH = txtStudentPhotograph.Text;
        student.PASSWORD = txtStudentPassword.Text;        
        BLLStudent.StudentAddBLL(student);
        Response.Redirect("Student.aspx");
    }
}