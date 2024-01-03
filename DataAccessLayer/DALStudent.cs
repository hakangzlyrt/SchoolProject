using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALStudent
    {
        public static int StudentAdd(EntityStudent entityStudent)
        {
            using (SqlCommand command = new SqlCommand("insert into TBLSTUDENT (STUDENTNAME,STUDENTSURNAME,STUDENTNUMBER,STUDENTPHOTOGRAPH,STUDENTPASSWORD) values (@p1,@p2,@p3,@p4,@p5)", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                command.Parameters.AddWithValue("@p1", entityStudent.NAME);
                command.Parameters.AddWithValue("@p2", entityStudent.SURNAME);
                command.Parameters.AddWithValue("@p3", entityStudent.NUMBER);
                command.Parameters.AddWithValue("@p4", entityStudent.PHOTOGRAPH);
                command.Parameters.AddWithValue("@p5", entityStudent.PASSWORD);

                return command.ExecuteNonQuery();
            }
        }

        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> students = new List<EntityStudent>();
            using (SqlCommand command2 = new SqlCommand("Select * from TBLSTUDENT", Connection.connection))
            {
                if (command2.Connection.State != ConnectionState.Open)
                {
                    command2.Connection.Open();
                }
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityStudent student = new EntityStudent();
                        student.ID = Convert.ToInt32(reader["STUDENTID"].ToString());
                        student.NAME = reader["STUDENTNAME"].ToString();
                        student.SURNAME = reader["STUDENTSURNAME"].ToString();
                        student.NUMBER = reader["STUDENTNUMBER"].ToString();
                        student.PHOTOGRAPH = reader["STUDENTPHOTOGRAPH"].ToString();
                        student.PASSWORD = reader["STUDENTPASSWORD"].ToString();
                        student.BALANCE = Convert.ToDouble(reader["STUDENTBALANCE"].ToString());
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        public static bool StudentDelete(int student)
        {
            SqlCommand command3 = new SqlCommand("Delete from TBLSTUDENT where STUDENTID=@p1", Connection.connection);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }

            command3.Parameters.AddWithValue("@p1", student);
            return command3.ExecuteNonQuery() > 0;
        }

        public static List<EntityStudent> StudentDetails(int updateId)
        {
            List<EntityStudent> students = new List<EntityStudent>();

            using (SqlCommand command4 = new SqlCommand("Select * from TBLSTUDENT Where STUDENTID=@p1", Connection.connection))
            {
                command4.Parameters.AddWithValue("@p1", updateId);

                if (command4.Connection.State != ConnectionState.Open)
                {
                    command4.Connection.Open();
                }

                using (SqlDataReader reader = command4.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityStudent student = new EntityStudent();
                        student.ID = Convert.ToInt32(reader["STUDENTID"].ToString());
                        student.NAME = reader["STUDENTNAME"].ToString();
                        student.SURNAME = reader["STUDENTSURNAME"].ToString();
                        student.NUMBER = reader["STUDENTNUMBER"].ToString();
                        student.PHOTOGRAPH = reader["STUDENTPHOTOGRAPH"].ToString();
                        student.PASSWORD = reader["STUDENTPASSWORD"].ToString();
                        student.BALANCE = Convert.ToDouble(reader["STUDENTBALANCE"].ToString());
                        students.Add(student);
                    }
                }
                return students;
            }
        }

        public static bool StudentUpdate(EntityStudent student)
        {
            SqlCommand command5 = new SqlCommand("Update TBLSTUDENT set STUDENTNAME=@p1,STUDENTSURNAME=@p2,STUDENTNUMBER=@p3,STUDENTPHOTOGRAPH=@p4,STUDENTPASSWORD=@p5,STUDENTBALANCE=@p6 where STUDENTID=@p7", Connection.connection);
            if (command5.Connection.State != ConnectionState.Open)
            {
                command5.Connection.Open();
            }
            command5.Parameters.AddWithValue("@p1", student.NAME);
            command5.Parameters.AddWithValue("@p2", student.SURNAME);
            command5.Parameters.AddWithValue("@p3", student.NUMBER);
            command5.Parameters.AddWithValue("@p4", student.PHOTOGRAPH);
            command5.Parameters.AddWithValue("@p5", student.PASSWORD);
            command5.Parameters.AddWithValue("@p6", student.BALANCE);
            command5.Parameters.AddWithValue("@p7", student.ID);
            return command5.ExecuteNonQuery() > 0;



        }
    }
}
