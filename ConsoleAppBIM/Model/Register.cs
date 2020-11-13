using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleAppBIM.Model
{
    class Register
    {
        int studentID;
        int courseID;
        DateTime registrationDate;


        public Register(int studentID, int courseID, DateTime registrationDate)
        {
            this.studentID = studentID;
            this.courseID = courseID;
            this.registrationDate = registrationDate;



        }

    }
}
