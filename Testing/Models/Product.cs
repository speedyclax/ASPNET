using System.Collections.Generic;

namespace Testing.Models
{
    public class Product
    {
        public Product() 
        { 
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string CategoryID { get; set; }
        public string OnSale { get; set; }
        public string StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
