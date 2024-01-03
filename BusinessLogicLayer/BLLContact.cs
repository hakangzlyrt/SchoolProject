using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLContact
    {
        public static List<EntityContact> BLLList()
        {
            return DALContact.ContactList();
        }

        public static List<EntityContact> BLLContactDetails(int details)
        {
            return DALContact.ContactDetails(details);
        }
        public static int ContactAddBLL(EntityContact entityContact)
        {
            if (entityContact.NAMESURNAME != null && entityContact.NAMESURNAME != "" && entityContact.MAIL != null && entityContact.MAIL != "" && entityContact.MESSAGE != null && entityContact.MESSAGE != "" && entityContact.SUBJECT != null && entityContact.SUBJECT != "")
            {
                return DALContact.ContactAdd(entityContact);
            }
            return -1;
        }
    }
}
