using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeacherDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int findId = Convert.ToInt32(Request.QueryString["TEACHERID"]);
        Response.Write(findId);
        EntityTeacher teacher1 = new EntityTeacher();
        teacher1.TEACHERID = findId;
        BLLTeacher.TeacherDeleteBLL(teacher1.TEACHERID);
        Response.Redirect("Teacher.aspx");
    }
}