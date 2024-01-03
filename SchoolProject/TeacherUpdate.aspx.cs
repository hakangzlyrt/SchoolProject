using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeacherUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            int findId = Convert.ToInt32(Request.QueryString["TEACHERID"].ToString());
            txtTeacherId.Text = findId.ToString();
            txtTeacherId.Enabled = false;
            List<EntityCourse> courses = BLLCourse.BLLList();
            dropDownListTeacherBranch.DataSource = courses;
            dropDownListTeacherBranch.DataTextField = "COURSENAME";
            dropDownListTeacherBranch.DataValueField = "ID";
            dropDownListTeacherBranch.DataBind();

            List<EntityTeacher> teacherList = BLLTeacher.BLLTeacherDetails(findId);
            txtTeacherNameSurname.Text = teacherList[0].TEACHERNAMESURNAME.ToString();
            //txtTeacherBranch.Text = teacherList[0].TEACHERBRANCH.ToString();
        }
    }
    protected void btnTeacherUpdate_Click(object sender, EventArgs e)
    {
        EntityTeacher teacher = new EntityTeacher();
        teacher.TEACHERNAMESURNAME = txtTeacherNameSurname.Text;
        //teacher.TEACHERBRANCH = Convert.ToInt32(txtTeacherBranch.Text);
        teacher.TEACHERBRANCH = Convert.ToInt32(dropDownListTeacherBranch.SelectedValue); 
        teacher.TEACHERID = Convert.ToInt32(txtTeacherId.Text);
        BLLTeacher.TeacherUpdateBLL(teacher);
        Response.Redirect("Teacher.aspx");
    }
}