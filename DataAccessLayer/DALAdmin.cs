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
    public class DALAdmin
    {
        public static List<EntityAdmin> AdminList()
        {
            List<EntityAdmin> admins = new List<EntityAdmin>();
            using (SqlCommand command = new SqlCommand("Select * from TBLADMIN", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityAdmin admin = new EntityAdmin();
                        admin.ID = Convert.ToInt32(reader["ADMINID"].ToString());
                        admin.USERNAME = reader["USERNAME"].ToString();
                        admin.PASSWORD = reader["PASSWORD"].ToString();

                        admins.Add(admin);
                    }
                }
            }
            return admins;
        }
    }
}
