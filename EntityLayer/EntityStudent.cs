using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer
{
    public class EntityStudent
    {
        private string name;
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;
        public string SURNAME
        {
            get { return surname; }
            set { surname = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string number;
        public string NUMBER
        {
            get { return number; }
            set { number = value; }
        }
        private string photograph;
        public string PHOTOGRAPH
        {
            get { return photograph; }
            set { photograph = value; }
        }
        private double balance;
        public double BALANCE
        {
            get { return balance; }
            set { balance = value; }
        }

        private string password;
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public string FULLNAME
        {
            get { return $"{NAME} {SURNAME}"; }
        }
    }
}
