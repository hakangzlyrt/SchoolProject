using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLTeacher
    {
        public static List<EntityTeacher> BLLList()
        {
            return DALTeacher.TeacherList();
        }

        public static int TeacherAddBLL(EntityTeacher teacher)
        {
            if (teacher.TEACHERNAMESURNAME != null && teacher.TEACHERNAMESURNAME != "" && teacher.TEACHERBRANCH>0)
            {
                return DALTeacher.TeacherAdd(teacher);
            }
            return -1;
        }

        public static bool TeacherDeleteBLL(int teacherdel)
        {
            if (teacherdel >= 0)
            {
                return DALTeacher.TeacherDelete(teacherdel);
            }
            return false;
        }


        public static bool TeacherUpdateBLL(EntityTeacher entityTeacher)
        {
            if (entityTeacher.TEACHERNAMESURNAME != null && entityTeacher.TEACHERNAMESURNAME != "" && entityTeacher.TEACHERBRANCH >0 && entityTeacher.TEACHERID>0)
            {
                return DALTeacher.TeacherUpdate(entityTeacher);
            }
            return false;
        }

        public static List<EntityTeacher> BLLTeacherDetails(int details)
        {
            return DALTeacher.TeacherDetails(details);
        }
    }
}
