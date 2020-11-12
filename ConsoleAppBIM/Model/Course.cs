using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
    class Course
    {
        int courseID;
        string name;

        public Course(int courseID, string name)
        {
            this.courseID = courseID;
            this.name = name;
        }
    }
}
