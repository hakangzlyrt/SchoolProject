﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLUser
    {
        public static List<EntityUser> BLLList()
        {
            return DALUser.UserList();
        }
    }
}
