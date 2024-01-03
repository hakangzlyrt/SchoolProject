using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class CourseAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStudentAdd_Click(object sender, EventArgs e)
    {
        EntityCourse course = new EntityCourse();
        course.COURSENAME = txtCourseName.Text;
        course.MİN = int.Parse(txtCourseMınQuota.Text);
        course.MAX = int.Parse(txtCourseMınQuota.Text);
        BLLCourse.CourseAddBLL(course);
        Response.Redirect("Course.aspx");
    }
}