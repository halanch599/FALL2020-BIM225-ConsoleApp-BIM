using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
  public abstract class Person
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string email;
        private string password;
        private int departmentID;
        private Address address;


        public Address Address { get { return address; } set { address = value; } }
        public string FirstName { get { return firstName; } set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int DepartmentID { get => departmentID; set => departmentID = value; }


        // Methods
        public abstract bool Login(string email, string password);
        //{
        //    try
        //    {
        //        bool valid = false;

        //        if (email=="admin" && password=="123")
        //        {
        //            valid = true;
        //        }
        //        return valid;

        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Error in login method.");
        //    }
        //}

        public virtual void ViewNotification()
        {
            Console.WriteLine("Notification method person.");
        }
      public void Logout(Person p)
        {
            try
            {
                if (p is Employee)
                {
                    Console.WriteLine("Employee Logout Successfully.");

                }
                else
                {
                    if (p is Student)
                    {
                        Console.WriteLine("Student Logout Successfully.");

                    }
                    else
                    {
                        Console.WriteLine("Person Logout Successfully.");
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error in login method.");
            }
        }
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
    }
}
