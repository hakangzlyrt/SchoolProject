using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Diagnostics.Contracts;

namespace DataAccessLayer
{
    public class DALContact
    {
        public static List<EntityContact> ContactList()
        {
            List<EntityContact> contacts = new List<EntityContact>();
            using (SqlCommand command = new SqlCommand("Select * from TBLCONTACT", Connection.connection))
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityContact contact = new EntityContact();
                        contact.CONTACTID = Convert.ToInt32(reader["CONTACTID"].ToString());
                        contact.NAMESURNAME = reader["NAMESURNAME"].ToString();
                        contact.MAIL = reader["MAIL"].ToString();
                        contact.MESSAGE = reader["MESSAGE"].ToString();
                        contact.SUBJECT = reader["SUBJECT"].ToString();
                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }

        public static List<EntityContact> ContactDetails(int updateId)
        {
            List<EntityContact> contacts = new List<EntityContact>();

            using (SqlCommand command2 = new SqlCommand("Select * from TBLCONTACT Where CONTACTID=@p1", Connection.connection))
            {
                command2.Parameters.AddWithValue("@p1", updateId);

                if (command2.Connection.State != ConnectionState.Open)
                {
                    command2.Connection.Open();
                }

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EntityContact contact = new EntityContact();
                        contact.CONTACTID = Convert.ToInt32(reader["CONTACTID"].ToString());
                        contact.NAMESURNAME = reader["NAMESURNAME"].ToString();
                        contact.MAIL = reader["MAIL"].ToString();
                        contact.MESSAGE = reader["MESSAGE"].ToString();
                        contact.SUBJECT = reader["SUBJECT"].ToString();
                        contacts.Add(contact);
                    }
                }
                return contacts;
            }
        }


        public static int ContactAdd(EntityContact entityContact)
        {
            using (SqlCommand command3 = new SqlCommand("insert into TBLCONTACT (NAMESURNAME,MAIL,MESSAGE,SUBJECT) values (@p1,@p2,@p3,@p4)", Connection.connection))
            {
                if (command3.Connection.State != ConnectionState.Open)
                {
                    command3.Connection.Open();
                }

                command3.Parameters.AddWithValue("@p1", entityContact.NAMESURNAME);
                command3.Parameters.AddWithValue("@p2", entityContact.MAIL);
                command3.Parameters.AddWithValue("@p3", entityContact.MESSAGE);
                command3.Parameters.AddWithValue("@p4", entityContact.SUBJECT);

                return command3.ExecuteNonQuery();
            }
        }
    }
}