using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // create dictionary of products to generate
            Dictionary<string, double> PRODUCTS = new Dictionary<string, double>();
            // add the products to the dictionary
            PRODUCTS.Add("Cereal", 3.59);
            PRODUCTS.Add("Pizza", 5.99);
            PRODUCTS.Add("Coffee", 4.75);
            PRODUCTS.Add("Pasta", 7.89);
            PRODUCTS.Add("Beer", 12.55);
            PRODUCTS.Add("Chips", 2.99);
            PRODUCTS.Add("Soda", 9.99);
            PRODUCTS.Add("Chicken", 5.67);
            PRODUCTS.Add("Eggs", 2.99);
            PRODUCTS.Add("Salsa", 3.15);

            // read the csv file that keeps all the products of our cart
            using (var reader = new StreamReader("C:\\Users\\matth\\OneDrive\\Documents\\GitHub\\AppINSY4051\\Test\\db.csv"))
            {
                // create empty dictionary for our csv data to be put into 
                Dictionary<string, double> db = new Dictionary<string, double>();
                // read csv 
                while (!reader.EndOfStream)
                {
                    // read line string 
                    var line = reader.ReadLine();
                    // seperate teh string values with a , 
                    var values = line.Split(',');
                    // add the values to db dictionary and convert number to double
                    db.Add(values[0], double.Parse(values[1]));
                }
  
                foreach (KeyValuePair<string, double> item in db)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
