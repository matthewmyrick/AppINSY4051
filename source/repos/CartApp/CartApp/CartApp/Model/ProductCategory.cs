using System;
using System.Collections.Generic;
using System.Text;

namespace CartApp.Model
{
    public class ProductCategory
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public ProductCategory(string id, string name)
        {
            ID = id;
            Name = name;
            Products = new List<Product>();
        }
    }
}
