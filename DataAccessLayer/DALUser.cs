using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALUser
    {
        public static List<EntityUser> UserList()
        {
            List<EntityUser> users = new List<EntityUser>();
            using (SqlCommand command = new SqlCommand("Select * from TBLUSER", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityUser user = new EntityUser();
                        user.ID = Convert.ToInt32(reader["USERID"].ToString());
                        user.USERNAME = reader["USERNAME"].ToString();
                        user.PASSWORD = reader["PASSWORD"].ToString();

                        users.Add(user);
                    }
                }
            }
            return users;
        }
    }
}
