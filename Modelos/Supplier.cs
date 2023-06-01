using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }

        public Supplier(int supplierId, string companyName)
        {
            SupplierId = supplierId;
            CompanyName = companyName;
        }
    }
}
