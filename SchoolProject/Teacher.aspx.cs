using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class Teacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<EntityTeacher> teachers = BLLTeacher.BLLList();
            List<EntityCourse> courses = BLLCourse.BLLList();

            foreach (EntityTeacher teacher in teachers)
            {
                teacher.CourseName = GetCourseName(teacher.TEACHERBRANCH,courses);
            }

            Repeater1.DataSource = teachers;
            Repeater1.DataBind();
        }
    }
    private string GetCourseName(int courseID, List<EntityCourse> courses)
    {
        EntityCourse course = courses.FirstOrDefault(c => c.ID == courseID);
        return course != null ? course.COURSENAME : string.Empty;
    }
}
