using System;

namespace Variables_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Gianna";
            int myAge = 24;
            char lastNameInitial = 'S';
            bool isHungry = true;
            double distanceFromFood = 3.14;
            decimal timeTilRestaurantClose = 2.3m;




            Console.WriteLine($"My name is {myName} {lastNameInitial}. " +
                $"I'm {myAge} years old. It is {isHungry} that I am hungry." +
                $"The restaurant I want to go to is {distanceFromFood} miles away." +
                $"It closes in {timeTilRestaurantClose} hours.");
        }
    }
}
