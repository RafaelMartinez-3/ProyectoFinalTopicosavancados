using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Inventory
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ReorderLevel { get; set; }
        public int UnitsInStock { get; set; }

        public Inventory(int productID, string productName, int reorderLevel, int unitsInStock)
        {
            ProductID = productID;
            ProductName = productName;
            ReorderLevel = reorderLevel;
            UnitsInStock = unitsInStock;
        }
    }
}
