using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
    class Employee:Person
    {
        int employeeID;
        float salary;
        DateTime joiningDate;
        float tax;
        public Employee()
        {
            Console.WriteLine("Employee Constructor.");
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public float Salary { get => salary; set => salary = value; }
        public DateTime JoiningDate { get => joiningDate; set => joiningDate = value; }
        public float Tax { get => tax; set => tax = value; }
    }
}
