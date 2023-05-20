using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categorias
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }

        public Categorias(int categoryid, String categoryName, String description)
        {
            CategoryID = categoryid;
            CategoryName = categoryName;
            CategoryDescription = description;
        }

        public Categorias()
        {
            CategoryID = 0;
            CategoryName = "";
            CategoryDescription = "";
        }

    }
}
