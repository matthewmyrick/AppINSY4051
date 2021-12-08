using System;
using System.Collections.Generic;
using System.IO;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Dictionary<string, float> PRODUCTS = new Dictionary<string, float>();
                PRODUCTS.Add("cereal", 85);
                using (var reader = new StreamReader("C:\\Users\\Samuel Adams\\Git Shit\\AppINSY4051\\Test\\DB.csv"))
                {
                    Dictionary<string, float> db = new Dictionary<string, float>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        db.Add(values[0], float.Parse(values[1]));
                    }
                    foreach (KeyValuePair<string, float> item in db)
                    {
                        Console.WriteLine(item.Key);
                        Console.WriteLine(item.Value);
                    }
                }
            }
        }
    }
}
