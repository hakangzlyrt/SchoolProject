using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLCourse
    {
        public static List<EntityCourse> BLLList()
        {
            return DALCourse.CourseList();

        }

        public static int RecourseAddBLL(EntityRecourse recourse)
        {
            if(recourse.RECOURSESTUDENTID!=null && recourse.RECOURSECOURSEID!=null)
            {
                return DALCourse.CourseAdd(recourse);
            }
            return -1;
        }

        public static int CourseAddBLL(EntityCourse course)
        {
            if (course.COURSENAME != null && course.COURSENAME!="" && course.MİN!=null && course.MAX!=null)
            {
                return DALCourse.CourseAdd2(course);
            }
            return -1;
        }
    }
}

   
