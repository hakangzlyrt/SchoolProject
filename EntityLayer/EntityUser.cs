using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityUser
    {
        private int ıd { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public int ID
        {
            get { return ıd; }
            set { ıd = value; }
        }

        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
    }
}
