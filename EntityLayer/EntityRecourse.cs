using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityRecourse
    {
        private int recourseid;
        private int recoursecourseid;
        private int recoursestudentid;

        public int RECOURSEID
        {
            get { return recourseid; }
            set { recourseid = value; }
        }

        public int RECOURSECOURSEID
        {
            get { return recoursecourseid; }
            set { recoursecourseid = value; }
        }

        public int RECOURSESTUDENTID
        {
            get { return recoursestudentid; }
            set { recoursestudentid = value; }
        }

        public string StudentFullName { get; set; }
        public string CourseName { get; set; }
    }
}
