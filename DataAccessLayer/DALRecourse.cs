using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALRecourse
    {
        public static List<EntityRecourse> RecourseList()
        {
            List<EntityRecourse> entityRecourses = new List<EntityRecourse>();
            using (SqlCommand command = new SqlCommand("Select * from TBLRECOURSE", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityRecourse recourse = new EntityRecourse();
                        recourse.RECOURSEID = Convert.ToInt32(reader["RECOURSEID"].ToString());
                        recourse.RECOURSECOURSEID = Convert.ToInt32(reader["COURSEID"].ToString());
                        recourse.RECOURSESTUDENTID = Convert.ToInt32(reader["STUDENTID"].ToString());

                        entityRecourses.Add(recourse);
                    }
                }
            }
            return entityRecourses;
        }
    }
}
