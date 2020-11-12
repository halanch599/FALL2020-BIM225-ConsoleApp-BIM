using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
    class Student
    {
        int studentID;
        string firstName;
        string lastName;
        string gender;
        string email;
        string password;
        int departmentID;

        public Student(int studentID, string firstName, string lastName, string gender, 
            string email, string password, int departmentID)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.departmentID = departmentID;
        }
    }
}
