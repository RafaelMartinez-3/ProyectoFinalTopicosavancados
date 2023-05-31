using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Sales
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int UnitsInStock { get; set; }
        public double Subtotal { get; set; }
        //public int OrderId { get; set; }

        public Sales()
        {

        }

        public Sales(int productID, String productName, double unitPrice, int quantity, int unitsInStock, double subtotal)
        {
            ProductID = productID;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            UnitsInStock = unitsInStock;
            Subtotal = subtotal;
        }
    }
}
