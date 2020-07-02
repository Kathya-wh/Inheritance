using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {

        public Animal()
        {

        }
        public int LegNumber { get; set; }
        public string AnimalSound { get; set; }
        public bool IsDomestic { get; set; }
        public string CommonFood { get; set; }

        public void MyAnimals()
        {
            MyAnimals();
            Console.WriteLine($"{LegNumber}");
            Console.WriteLine($"{AnimalSound}");
            Console.WriteLine($"{IsDomestic}");
            Console.WriteLine($"{CommonFood}");
        }














    }






}
