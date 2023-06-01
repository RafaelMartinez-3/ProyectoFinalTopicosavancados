using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Title { get; set; }
        public String PostalCode { get; set; }
        public int ReportsTo { get; set; }
        public String ReportsToName { get; set; }
        public String FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
