using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int Unidades { get; set; }
        public Product(int ProductID, string ProductName, int SupplierID, string CompanyName, 
            int CategoryID, string CategoryName, double UnitPrice, int UnitsInStock, int ReorderLevel, bool Discontinued)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SupplierID = SupplierID;
            this.CompanyName = CompanyName;
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
            this.Discontinued = Discontinued;
            this.ReorderLevel = ReorderLevel;
        }

        public Product(string ProductName, string CompanyName,int UnitsRequired)
        {
            this.ProductName = ProductName;
            this.CompanyName = CompanyName;
            this.Unidades = UnitsRequired;
        }
    }
}
