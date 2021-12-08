using System;
using System.Collections.Generic;
using System.Text;

namespace CartApp.Model
{
    public class Product
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }

        public Product(string sku, string name, string image)
        {
            SKU = sku;
            Name = name;
            ImageSource = image;
        }
    }
}
