using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test
{
    class Program
    {
        public Dictionary<string, string[]> GET_PRODUCTS()
        {
            Dictionary<string, string[]> PRODUCTS = new Dictionary<string, string[]>();
            string[] prod1 = { "Coffee", "10", "image" };
            PRODUCTS.Add("1001", prod1);
           string[] prod2 = { "Potato Chips", "4.50", "image" };
            PRODUCTS.Add("1002", prod2);
           string[] prod3 = { "Coke", "2.20", "image" };
            PRODUCTS.Add("1003", prod3);
            string[] prod4 = { "Water", "1.50", "image"};
            PRODUCTS.Add("1004", prod4);
            string[] prod5 = { "Pizza", "6.50", "image"};
            PRODUCTS.Add("1005", prod5);
            string[] prod6 = {"Beef Jerky", "8.00", "image"};
            PRODUCTS.Add("1006", prod6);
            string[] prod7 ={"Cookies", "3.15", "image" };
            PRODUCTS.Add("1007", prod7);
            string[] prod8 = {"Sprite", "2.20", "image" };
            PRODUCTS.Add("1008", prod8);
            string[] prod9 ={"Pepsi", "2.20", "image" };
            PRODUCTS.Add("1009", prod9);
            string[] prod10 = {"Mountain Dew", "2.20", "image" };
            PRODUCTS.Add("1010", prod10);
            string[] prod11 = { "Deli Sandwich", "3.50", "image" };
            PRODUCTS.Add("1011", prod11);
            string[] prod12 = { "Sushi", "5.00", "image" };
            PRODUCTS.Add("1012", prod12);
            string[] prod13 = { "Tortilla Chips", "3.40", "image" };
            PRODUCTS.Add("1013", prod13);
            string[] prod14 = { "Salsa", "2.00", "image" };
            PRODUCTS.Add("1014", prod14);
            string[] prod15 = { "Ketchup", "2.40", "image" };
            PRODUCTS.Add("1015", prod15);
            string[] prod16 = { "Mustard", "2.40", "image" };
            PRODUCTS.Add("1016", prod16);
            string[] prod17 = { "Relish", "2.40", "image" };
            PRODUCTS.Add("1017", prod17);
            string[] prod18 = { "Hot Dog", "1.50", "image" };
            PRODUCTS.Add("1018", prod18);
            string[] prod19 = { "Bratwurst", "2.20", "image" };
            PRODUCTS.Add("1019", prod19);
            string[] prod20 = { "Beer (12-pack)", "13.00", "image" };
            PRODUCTS.Add("1020", prod20);

           //  Random random = new Random();
           // int index = random.Next(PRODUCTS.Count);
           // string key = PRODUCTS.Keys.ElementAt(index);

         //   KeyValuePair<string, int> pair = PRODUCTS.ElementAt(index);

            return PRODUCTS;
        }


        static void Main(string[] args)
        {


            {
                Dictionary<string, string[]> PRODUCTS = new Dictionary<string, string[]>();

                using (var reader = new StreamReader("C:\\Users\\Samuel Adams\\Git Shit\\AppINSY4051\\Test\\DB.csv"))
                {
                    Dictionary<string, string[]> db = new Dictionary<string, string[]>(); ;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        string[] items = new string[3];
                        items[0] = values[1];
                        items[1] = values[2];
                        items[2] = values[3];
                        db.Add(values[0], items);

                    }
                    foreach (KeyValuePair<string, string[]> item in db)
                    {
                        Console.WriteLine(item.Key);
                        Console.WriteLine(item.Value[0]);
                    }

                }
            }

    }
    }
}
