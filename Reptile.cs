using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            LegNumber = 4;
            AnimalSound = "zzzzzzt";
            IsDomestic = false;
            CommonFood = "insects";

        }

        public bool IsPoisonous { get; set; }
        public string Color { get; set; }
        public bool LikesWater { get; set; }
        public string FavoriteFood { get; set; }

        public void MyReptiles()
        {
            MyAnimals();
            Console.WriteLine($"{IsPoisonous}");
            Console.WriteLine($"{Color}");
            Console.WriteLine($"{LikesWater}");
            Console.WriteLine($"{FavoriteFood}");


        }
















    }
}
