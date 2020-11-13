using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string email;
        private string password;
        private int departmentID;

        public string FirstName { get { return firstName; } set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int DepartmentID { get => departmentID; set => departmentID = value; }

        //properties

        //public string Email
        //{
        //    get
        //    {
        //        return email;
        //    }
        //}
        //public string Password
        //{
        //    set
        //    {
        //        if (password.Length<= 8)
        //        {
        //            throw new Exception("Password should be at least 8 charachters.");
        //        }
        //        firstName = value;

        //    }
        //}

        //public string FirstName
        //{
        //    get { return firstName; }
        //    set {
        //        if (firstName==null)
        //        {
        //            throw new Exception("First Name cannot be empty.");
        //        }
        //        firstName = value; 

        //    }
        //}
        //public string getFirstName()
        //{
        //    return firstName;
        //}
        //public void setFirstName(string fname)
        //{
        //    firstName = fname;
        //}
        public Person()
        {
           // Console.WriteLine("Person Constructor");
        }

        public Person(string firstName, string lastName, string gender, string email, 
            string password, int departmentID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Email = email;
            this.Password = password;
            this.DepartmentID = departmentID;
        }
    }
}
