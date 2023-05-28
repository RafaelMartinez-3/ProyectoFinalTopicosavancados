using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Customer
	{
		public int CustomerID { get; set; }
		public string CustomerName { get; set; }

		public Customer(int customerID, string customerName)
		{
			CustomerID= customerID;
			CustomerName= customerName;
		}
	}
}
