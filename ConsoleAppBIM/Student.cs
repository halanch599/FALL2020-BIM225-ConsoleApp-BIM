using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM
{
    class Student
    {
        // Data
        //default data is private
        int studentID;
        string firstName;
        string lastName;
        string gender;
        // default constructor is added by comipler if no constructor is added in class
        // parameter constructor
        public Student(int id,string fname,string lname,string gen)
        {
            studentID = id;
            firstName = fname;
            lastName = lname;
            gender = gen;
        }

        //camel (Deve) casing
        // Methods

        public void DisplayStudent()
        {
            Console.WriteLine($"ID= {studentID}, Name = {firstName} {lastName}," +
               $" Gender = {gender}");
        }
    }
}
