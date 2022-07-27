using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddyExercise
{
    internal class Resturant

  
    { 
        List<string> _resturantNames = new List<string>()
            {
                "Locust",
                "Lou",
                "Red Headed Stranger",
                "Oku"
            };
        public Resturant()
        {
           Random random = new Random();
            string name = _resturantNames[new Random().Next(0, _resturantNames.Count)];
           
        }

        public string Name { get; set; }
    }
}
 