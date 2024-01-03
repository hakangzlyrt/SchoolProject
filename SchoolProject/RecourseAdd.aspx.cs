using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;
using System.ServiceModel.Channels;

public partial class Courses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Öğrenci listesini al
            List<EntityStudent> students = BLLStudent.BLLList();

            // DropDownList'a öğrenci isimlerini ve ID'lerini bağla
            dropDownListStudent.DataSource = students;
            dropDownListStudent.DataTextField = "FULLNAME"; 
            dropDownListStudent.DataValueField = "ID"; // Öğrenci ID özelliği
            dropDownListStudent.DataBind();


            List<EntityCourse> courses = BLLCourse.BLLList();
            dropDownListCourse.DataSource = courses;
            dropDownListCourse.DataTextField = "COURSENAME";
            dropDownListCourse.DataValueField = "ID";
            dropDownListCourse.DataBind();
            
        }
    }

    protected void btnRecourseAdd_Click(object sender, EventArgs e)
    {
        EntityRecourse entityRecourse = new EntityRecourse();
        entityRecourse.RECOURSESTUDENTID = int.Parse(dropDownListStudent.SelectedValue);
        entityRecourse.RECOURSECOURSEID = int.Parse(dropDownListCourse.SelectedValue.ToString());
        BLLCourse.RecourseAddBLL(entityRecourse);
        Response.Redirect("Recourse.aspx");
    }
}