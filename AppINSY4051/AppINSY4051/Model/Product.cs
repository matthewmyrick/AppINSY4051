using System;
using System.Collections.Generic;
using System.Text;

namespace AppINSY4051.Model
{
  public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageSource { get; set; }

        public Product (string id, string name, double price, string imagesource)
        {
            ID = id;
            Name = name;
            Price = price;
            ImageSource = imagesource;

        }
    }
}
