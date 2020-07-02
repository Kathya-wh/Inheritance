using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {

        public Bird()
        {
            LegNumber = 2;
            AnimalSound = "Squeek";
            IsDomestic = true;
            CommonFood = "Seeds";
        }

        public string FeatherColor { get; set; }
        public bool Speaks { get; set; }
        public string FavoriteFood { get; set; }
        public int Age { get; set; }

        public void MyBird()
        {


            MyAnimals();
            Console.WriteLine($"{FeatherColor}");
            Console.WriteLine($"{Speaks}");
            Console.WriteLine($"{Age}");
            Console.WriteLine($"{FavoriteFood}");

        }


    }
}
