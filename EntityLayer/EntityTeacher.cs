using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityTeacher
    {
        private int teacherid;
        private string teachernamesurname;
        private int teacherbranch;

        public int TEACHERID
        {
            get { return teacherid; }
            set { teacherid = value; }
        }
        public int TEACHERBRANCH
        {
            get { return teacherbranch; }
            set { teacherbranch = value; }
        }
        public string TEACHERNAMESURNAME
        {
            get { return teachernamesurname; }
            set { teachernamesurname = value; }
        }
        public string CourseName { get; set; }

    }
}
