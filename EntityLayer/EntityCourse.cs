using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCourse
    {
        private string coursename;
        public string COURSENAME 
        { 
            get {  return coursename; } 
            set {  coursename = value; } 
        }

        private int min;
        public int MİN  
        {
            get { return min; }
            set { min = value; }
        }

        private int max;
        public int MAX
        {
            get { return max; }
            set { max = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
