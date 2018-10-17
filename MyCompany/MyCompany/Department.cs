using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Department
    {

        public string department;

        public Department(string department)
        {
            this.department = department;
        }

        public override string ToString()
        {
            return department;
        }
    }
}
