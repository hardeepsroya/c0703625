using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0703625
{
   public class Customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public void Promote()
        {
            var rating = CalculateRating();
            if (rating==0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else { Console.WriteLine("Promoted to Level 2"); }
        }
        public int CalculateRating()
        {
            return 0;
        }
       
   
    }
}

    
    

