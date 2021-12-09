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
            string[] prod1 = { "Coffee", "10", "https://content-prod-live.cert.starbucks.com/binary/v2/asset/137-75690.png" };
            PRODUCTS.Add("1001", prod1);
           string[] prod2 = { "Potato Chips", "4.50", "https://mobileimages.lowes.com/product/converted/028400/028400097802.jpg?size=pdhi" };
            PRODUCTS.Add("1002", prod2);
           string[] prod3 = { "Coke", "2.20", "https://images.heb.com/is/image/HEBGrocery/000145352" };
            PRODUCTS.Add("1003", prod3);
            string[] prod4 = { "Water", "1.50", "http://mobileimages.lowes.com/productimages/99c41519-c391-42dd-94f3-453715851bdf/01545439.jpg" };
            PRODUCTS.Add("1004", prod4);
            string[] prod5 = { "Pizza", "6.50", "https://i5.walmartimages.com/asr/1c9f8d71-9889-4ea3-8e80-5ebcef6f89a8.b6f695097b12b97271e7a517abe654d3.jpeg" };
            PRODUCTS.Add("1005", prod5);
            string[] prod6 = {"Beef Jerky", "8.00", "https://target.scene7.com/is/image/Target/GUEST_a9430a42-1564-41d2-8262-eba59f386d41?wid=488&hei=488&fmt=pjpeg" };
            PRODUCTS.Add("1006", prod6);
            string[] prod7 ={"Cookies", "3.15", "https://images-gmi-pmc.edge-generalmills.com/087d17eb-500e-4b26-abd1-4f9ffa96a2c6.jpg" };
            PRODUCTS.Add("1007", prod7);
            string[] prod8 = {"Sprite", "2.20", "https://images.heb.com/is/image/HEBGrocery/001397083" };
            PRODUCTS.Add("1008", prod8);
            string[] prod9 ={"Pepsi", "2.20", "https://images.heb.com/is/image/HEBGrocery/000026101?fit=constrain,1&wid=800&hei=800&fmt=jpg&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0" };
            PRODUCTS.Add("1009", prod9);
            string[] prod10 = {"Mountain Dew", "2.20", "https://www.kroger.com/product/images/large/front/0001200000131" };
            PRODUCTS.Add("1010", prod10);
            string[] prod11 = { "Deli Sandwich", "3.50", "https://hips.hearstapps.com/del.h-cdn.co/assets/15/11/4000x2000/landscape-1426025675-125826167.jpg?resize=480:*" };
            PRODUCTS.Add("1011", prod11);
            string[] prod12 = { "Sushi", "5.00", "https://www.kikkoman.com/homecook/search/recipe/img/00005163.jpg" };
            PRODUCTS.Add("1012", prod12);
            string[] prod13 = { "Tortilla Chips", "3.40", "https://images.heb.com/is/image/HEBGrocery/001619792" };
            PRODUCTS.Add("1013", prod13);
            string[] prod14 = { "Salsa", "2.00", "https://i5.walmartimages.com/asr/ec1d61e6-840b-49d7-95f3-dc12d24604da.55074e716b6aca0a08d36f136633862e.jpeg" };
            PRODUCTS.Add("1014", prod14);
            string[] prod15 = { "Ketchup", "2.40", "https://m.media-amazon.com/images/I/71b0CQV4SFS._SX425_.jpg" };
            PRODUCTS.Add("1015", prod15);
            string[] prod16 = { "Mustard", "2.40", "https://m.media-amazon.com/images/I/71rHQWBAQzL._SL1500_.jpg" };
            PRODUCTS.Add("1016", prod16);
            string[] prod17 = { "Relish", "2.40", "https://m.media-amazon.com/images/I/7179O53Dk9L._SL1500_.jpg" };
            PRODUCTS.Add("1017", prod17);
            string[] prod18 = { "Hot Dog", "1.50", "https://upload.wikimedia.org/wikipedia/commons/b/b1/Hot_dog_with_mustard.png" };
            PRODUCTS.Add("1018", prod18);
            string[] prod19 = { "Bratwurst", "2.20", "https://www.oklahomajoes.com/media/ctm//S/m/Smoked_Bratwurst_02_3x2_full.jpg.jpeg" };
            PRODUCTS.Add("1019", prod19);
            string[] prod20 = { "Beer (12-pack)", "13.00", "https://pikfly.com/images/products/164/39919.jpg" };
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
