using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Customer
	{
		public string CustomerID { get; set; }
		public string CompanyName { get; set; }

		public Customer(string customerID, string companyName)
		{
			CustomerID= customerID;
			CompanyName= companyName;
		}
	}
}
