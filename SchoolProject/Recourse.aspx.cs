using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

public partial class Recourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //List<EntityRecourse> recourses = BLLRecourse.BLLList();
        //Repeater1.DataSource = recourses;
        //Repeater1.DataBind();


        if (!Page.IsPostBack)
        {
            // EntityRecourse listesini al
            List<EntityRecourse> recourseList = BLLRecourse.BLLList();

            // Öğrenci listesini ve ders listesini al
            List<EntityStudent> students = BLLStudent.BLLList();
            List<EntityCourse> courses = BLLCourse.BLLList();

            // Her bir EntityRecourse için öğrenci adını ve ders adını doldur
            foreach (EntityRecourse recourse in recourseList)
            {
                recourse.StudentFullName = GetStudentFullName(recourse.RECOURSESTUDENTID, students);
                recourse.CourseName = GetCourseName(recourse.RECOURSECOURSEID, courses);
            }

            // Repeater kontrolünü bağla
            Repeater1.DataSource = recourseList;
            Repeater1.DataBind();
        }
    }
    private string GetStudentFullName(int studentID, List<EntityStudent> students)
    {
        EntityStudent student = students.FirstOrDefault(s => s.ID == studentID);
        return student != null ? student.FULLNAME : string.Empty;
    }

    private string GetCourseName(int courseID, List<EntityCourse> courses)
    {
        EntityCourse course = courses.FirstOrDefault(c => c.ID == courseID);
        return course != null ? course.COURSENAME : string.Empty;
    }
}