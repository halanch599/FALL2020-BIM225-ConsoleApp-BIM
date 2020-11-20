using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
   public class Employee:Person
    {
        int employeeID;
        float salary;
        DateTime joiningDate;
        float tax;
        public Employee()
        {
            //Console.WriteLine("Employee Constructor.");
        }

        public Employee(string firstName, string lastName, string gender, string email, string password, int departmentID,
            int employeeID,float salary,DateTime joiningDate,float tax) 
            : base(firstName, lastName, gender, email, password, departmentID)
        {
            this.employeeID = employeeID;
            this.salary = salary;
            this.joiningDate = joiningDate;
            this.tax = tax;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public float Salary { get => salary; set => salary = value; }
        public DateTime JoiningDate { get => joiningDate; set => joiningDate = value; }
        public float Tax { get => tax; set => tax = value; }

        //public override void ViewNotification()
        //{
        //    Console.WriteLine("Employee Notification method person.");
        //    //base.ViewNotification();
        //}
        public override bool Login(string email, string password)
        {
            try
            {
                bool valid = false;

                if (email == "admin" && password == "123")
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
