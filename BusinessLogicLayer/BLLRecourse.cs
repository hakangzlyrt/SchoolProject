using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLRecourse
    {
        public static List<EntityRecourse> BLLList()
        {
            return DALRecourse.RecourseList();

        }
    }
}
