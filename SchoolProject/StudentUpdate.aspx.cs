using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
using DataAccessLayer;

public partial class StudentUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Page.IsPostBack==false)
        {
           
            int findId = Convert.ToInt32(Request.QueryString["STUDENTID"].ToString());
            txtStudentId.Text = findId.ToString();
            txtStudentId.Enabled = false;
            txtStudentNumber.Enabled = false;

            List<EntityStudent> studentList = BLLStudent.BLLStudentDetails(findId);
            txtStudentName.Text = studentList[0].NAME.ToString();
            txtStudentSurname.Text = studentList[0].SURNAME.ToString();
            txtStudentNumber.Text = studentList[0].NUMBER.ToString();       
            txtStudentPhotograph.Text = studentList[0].PHOTOGRAPH.ToString();
            txtStudentPassword.Text = studentList[0].PASSWORD.ToString();
            txtStudentBalance.Text = studentList[0].BALANCE.ToString();
        }          
    }

    protected void btnStudentUpdate_Click(object sender, EventArgs e)
    {
        EntityStudent student = new EntityStudent();
        student.NAME=txtStudentName.Text;   
        student.SURNAME=txtStudentSurname.Text;
        student.NUMBER=txtStudentNumber.Text;
        student.PHOTOGRAPH=txtStudentPhotograph.Text;
        student.PASSWORD=txtStudentPassword.Text;
        student.BALANCE=Convert.ToDouble(txtStudentBalance.Text);
        student.ID=Convert.ToInt32(txtStudentId.Text);
        BLLStudent.StudentUpdateBLL(student);
        Response.Redirect("Student.aspx");

    }
}