using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityContact
    {
        private int contactıd;
        public int CONTACTID
        {
            get { return contactıd; }
            set { contactıd = value; }
        }

        private string namesurname;
        public string NAMESURNAME
        {
            get { return namesurname; }
            set { namesurname = value; }
        }

        private string mail;
        public string MAIL
        {
            get { return mail; }
            set { mail = value; }
        }

        private string message;
        public string MESSAGE
        {
            get { return message; }
            set { message = value; }
        }

        private string subject;
        public string SUBJECT
        {
            get { return subject; }
            set { subject = value; }
        }

    }
}
