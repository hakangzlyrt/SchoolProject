using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

public partial class TeacherAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Öğrenci branşlarını getir
            List<EntityCourse> courses = BLLCourse.BLLList();

            // DropDownList'a branş isimlerini ve ID'lerini bağla
            dropDownListTeacher.DataSource = courses;
            dropDownListTeacher.DataTextField = "COURSENAME";
            dropDownListTeacher.DataValueField = "ID";
            dropDownListTeacher.DataBind();
        }
    }

    protected void btnStudentAdd_Click(object sender, EventArgs e)
    {
        //EntityTeacher teacher = new EntityTeacher();
        //teacher.TEACHERNAMESURNAME = txtTeacherNameSurname.Text;
        //teacher.TEACHERBRANCH = Convert.ToInt32(txtTeacherBranch.Text);
        //BLLTeacher.TeacherAddBLL(teacher);
        //Response.Redirect("Teacher.aspx");

        EntityTeacher teacher = new EntityTeacher();
        teacher.TEACHERNAMESURNAME = txtTeacherNameSurname.Text;
        teacher.TEACHERBRANCH = Convert.ToInt32(dropDownListTeacher.SelectedValue);

        // Diğer öğretmen bilgilerini de alabilirsiniz
        // teacher.TEACHERSOMEOTHERPROPERTY = txtSomeOtherProperty.Text;

        BLLTeacher.TeacherAddBLL(teacher);
        Response.Redirect("Teacher.aspx");


    }
}