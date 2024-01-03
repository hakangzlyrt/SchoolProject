using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static int StudentAddBLL(EntityStudent entityStudent)
        {
            if (entityStudent.NAME != null && entityStudent.NAME != "" && entityStudent.SURNAME != null && entityStudent.SURNAME != "" && entityStudent.NUMBER != null && entityStudent.NUMBER != "" && entityStudent.PASSWORD != null && entityStudent.PASSWORD != "" && entityStudent.PHOTOGRAPH != null && entityStudent.PHOTOGRAPH != "" )
             {
                return DALStudent.StudentAdd(entityStudent);
            }
            return -1;
        }

        public static List<EntityStudent> BLLList()
        {
            return DALStudent.StudentList();
        }

        public static bool StudentDeleteBLL(int studentdel)
        {
            if (studentdel>=0)
            {
                return DALStudent.StudentDelete(studentdel);
            }
            return false;
        }

        public static List<EntityStudent> BLLStudentDetails(int details)
        {
            return DALStudent.StudentDetails(details);
        }
        
        public static bool StudentUpdateBLL(EntityStudent entityStudentUpdate)
        {
            if (entityStudentUpdate.NAME != null && entityStudentUpdate.NAME != "" && entityStudentUpdate.SURNAME != null && entityStudentUpdate.SURNAME != "" && entityStudentUpdate.NUMBER != null && entityStudentUpdate.NUMBER != "" && entityStudentUpdate.PASSWORD != null && entityStudentUpdate.PASSWORD !="" &&  entityStudentUpdate.PHOTOGRAPH != null &&  entityStudentUpdate.PHOTOGRAPH !="" && entityStudentUpdate.ID>0)
            {
                return DALStudent.StudentUpdate(entityStudentUpdate);
            }
            return false;
        }
    }
}
