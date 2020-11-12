using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
    class Department
    {
       private int departmentID;
        private string name;

        public Department(int departmentID, string name)
        {
            this.departmentID = departmentID;
            this.name = name;
        }
    }
}
