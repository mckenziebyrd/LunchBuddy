using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddyExercise 
{
    internal class LunchBuddy
    {


        public LunchBuddy(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

        }

        private string _firstName;
        private string _lastName;

        public Resturant Eat()
        {
            Resturant resturant = new Resturant();
            Console.WriteLine($"{_firstName} {_lastName} is eating at {resturant.Name}");
            return resturant;

        }
        public void Eat(string food)
        {
            Console.WriteLine($"{_firstName} {_lastName} is eating {food}");
        }
        public void Eat(List <LunchBuddy> companions)
        {
            Resturant resturant = new Resturant();
            string compainionNames = "";
            foreach (LunchBuddy companion in companions)
            {
                compainionNames += companion._lastName;
            }
            Console.WriteLine($"{_firstName} {_lastName} is eating at {resturant.Name} with {compainionNames}.");
        }
        public void Eat(string food, List <LunchBuddy> compainions)
        {
            Resturant resturant = new Resturant():

                Console.WriteLine($"{_firstName} {_lastName} has ordered {food} at {resturant.name}.);
        }
    }
};
