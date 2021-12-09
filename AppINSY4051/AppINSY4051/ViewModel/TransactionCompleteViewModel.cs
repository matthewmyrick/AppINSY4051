using System;
using System.Collections.Generic;
using System.Text;

namespace AppINSY4051.ViewModel
{
    public class TransactionCompleteViewModel
    {
       public static string[] DriverNames { get; set; }
       public static Random random = new Random();


        public TransactionCompleteViewModel()
        {
            DriverNames = new string[] { "Derek", "Eli", "Matthew", "Sam", "Hannah", "Katie", "Grace", "Kayla", "Michael", "Thomas", "Eddie", "Austin" };
            int index = random.Next(DriverNames.Length);
        }

       
        
    }


}
