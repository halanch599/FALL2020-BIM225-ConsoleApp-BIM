using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
   public class Student:Person
    {
        int studentID;
        int programID;
        float fees;

        public int StudentID { get => studentID; set => studentID = value; }
        public int ProgramID { get => programID; set => programID = value; }
        public float Fees { get => fees; set => fees = value; }

        public override void ViewNotification()
        {
            Console.WriteLine("Student Notification method person.");
            //base.ViewNotification();
        }
        public Student()
        {
            //Console.WriteLine("Student Constructor");
        }
        public Student(int studentID, string firstName, string lastName, string gender, 
            string email, string password, int departmentID,int programID,float fees)
            :base(firstName, lastName, gender, email,password, departmentID)
        {
            StudentID = studentID;
            ProgramID = programID;
            Fees = fees;
        }

       

        public void Display()
        {
            Console.WriteLine($"ID = {StudentID}\t Name= {FirstName} {LastName}");
        }

        public override bool Login(string email, string password)
        {
            try
            {
                bool valid = false;

                if (email == "std" && password == "123")
                {
                    valid = true;
                }
                return valid;

            }
            catch (Exception)
            {
                throw new Exception("Error in login method.");
            }
        }
    }
}
