using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class DALTeacher
    {
        public static List<EntityTeacher> TeacherList()
        {
            List<EntityTeacher> teachers = new List<EntityTeacher>();
            using (SqlCommand command = new SqlCommand("Select * from TBLTEACHER", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityTeacher teacher = new EntityTeacher();
                        teacher.TEACHERID = Convert.ToInt32(reader["TEACHERID"].ToString());
                        teacher.TEACHERNAMESURNAME = reader["TEACHERNAMESURNAME"].ToString();
                        teacher.TEACHERBRANCH = Convert.ToInt32(reader["TEACHERBRANCH"].ToString());
                        teachers.Add(teacher);
                    }
                }
            }
            return teachers;
        }

        public static int TeacherAdd(EntityTeacher entityTeacher)
        {
            SqlCommand command2 = new SqlCommand("insert into TBLTEACHER (TEACHERNAMESURNAME,TEACHERBRANCH) values (@p1,@p2)", Connection.connection);
            command2.Parameters.AddWithValue("@p1", entityTeacher.TEACHERNAMESURNAME);
            command2.Parameters.AddWithValue("@p2", entityTeacher.TEACHERBRANCH);          
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            return command2.ExecuteNonQuery();
        }

        public static bool TeacherDelete(int teacher)
        {
            SqlCommand command3 = new SqlCommand("Delete from TBLTEACHER where TEACHERID=@p1", Connection.connection);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }

            command3.Parameters.AddWithValue("@p1", teacher);
            return command3.ExecuteNonQuery() > 0;
        }

        public static bool TeacherUpdate(EntityTeacher entityTeacher)
        {
            SqlCommand command4 = new SqlCommand("Update TBLTEACHER set TEACHERNAMESURNAME=@p1,TEACHERBRANCH=@p2 where TEACHERID=@p3", Connection.connection);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@p1", entityTeacher.TEACHERNAMESURNAME);
            command4.Parameters.AddWithValue("@p2", entityTeacher.TEACHERBRANCH);
            command4.Parameters.AddWithValue("@p3", entityTeacher.TEACHERID);         
            return command4.ExecuteNonQuery() > 0;
        }

        public static List<EntityTeacher> TeacherDetails(int updateId)
        {
            List<EntityTeacher> teachers = new List<EntityTeacher>();

            using (SqlCommand command5 = new SqlCommand("Select * from TBLTEACHER Where TEACHERID=@p1", Connection.connection))
            {
                command5.Parameters.AddWithValue("@p1", updateId);

                if (command5.Connection.State != ConnectionState.Open)
                {
                    command5.Connection.Open();
                }

                using (SqlDataReader reader = command5.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityTeacher teacher = new EntityTeacher();
                        teacher.TEACHERID = Convert.ToInt32(reader["TEACHERID"].ToString());
                        teacher.TEACHERNAMESURNAME = reader["TEACHERNAMESURNAME"].ToString();
                        teacher.TEACHERBRANCH = Convert.ToInt32(reader["TEACHERBRANCH"].ToString());
                        teachers.Add(teacher);
                    }
                }
                return teachers;
            }
        }
    }
}