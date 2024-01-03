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
    public class DALCourse
    {
        public static List<EntityCourse> CourseList()
        {
            List<EntityCourse> courses = new List<EntityCourse>();

            using (SqlCommand command = new SqlCommand("Select * from TBLCOURSE", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityCourse course = new EntityCourse();
                        course.ID = Convert.ToInt32(reader["COURSEID"].ToString());
                        course.COURSENAME = reader["COURSENAME"].ToString();
                        course.MİN = Convert.ToInt32(reader["COURSEMINQUOTA"].ToString());
                        course.MAX = Convert.ToInt32(reader["COURSEMAXQUOTA"].ToString());
                        courses.Add(course);
                    }
                }
            }
            return courses;
        }

        public static int CourseAdd(EntityRecourse entityRecourse)
        {
            SqlCommand command2 = new SqlCommand("insert into TBLRECOURSE (COURSEID,STUDENTID) values (@p1,@p2)",Connection.connection);
            command2.Parameters.AddWithValue("@p1", entityRecourse.RECOURSECOURSEID);
            command2.Parameters.AddWithValue("@p2", entityRecourse.RECOURSESTUDENTID);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            return command2.ExecuteNonQuery();  
        }

        public static int CourseAdd2(EntityCourse entityCourse)
        {
            SqlCommand command3 = new SqlCommand("insert into TBLCOURSE (COURSENAME,COURSEMINQUOTA,COURSEMAXQUOTA) values (@p1,@p2,@p3)", Connection.connection);
            command3.Parameters.AddWithValue("@p1", entityCourse.COURSENAME);
            command3.Parameters.AddWithValue("@p2", entityCourse.MİN);
            command3.Parameters.AddWithValue("@p3", entityCourse.MAX);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            return command3.ExecuteNonQuery();
        }
    }
}

