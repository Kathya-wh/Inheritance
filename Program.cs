using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var breannasBird = new Bird()
            {

                FeatherColor = "red",
                Speaks = true,
                FavoriteFood = "apples",
                Age = 1
            };

            Console.WriteLine();

            var gecko = new Reptile()
            {

                IsPoisonous = false,
                Color = "green",
                LikesWater = false,
                FavoriteFood = "insects"

            };

            Console.WriteLine("Tell me all about your animals!");
            Console.WriteLine();

            var myAnimals = new Animal[] { breannasBird, gecko };
            foreach(var animal in myAnimals)
            {

                Console.WriteLine($"How many legs does your animal have? {animal.LegNumber}");
                Console.WriteLine($"How does your animal communicate? {animal.AnimalSound}");
                Console.WriteLine($"What does your animal usually eat? {animal.CommonFood}");
                Console.WriteLine($"Can your animal live at home with you? {animal.IsDomestic}");

            }

            Console.WriteLine();

            Console.WriteLine($"How old is your cute bird? {breannasBird.Age}");
            Console.WriteLine($"What color feathers does your bird have? {breannasBird.FeatherColor}");
            Console.WriteLine($"What yummy food does your bird love? {breannasBird.FavoriteFood}");
            Console.WriteLine($"Can your bird talk? {breannasBird.Speaks}");

            Console.WriteLine();

            Console.WriteLine($"Is your gecko poisonous? {gecko.IsPoisonous}");
            Console.WriteLine($"What color is your beautiful gecko? {gecko.Color}");
            Console.WriteLine($"Can your gecko survive in water? {gecko.LikesWater}");
            Console.WriteLine($"What does your gecko enjoys eating? {gecko.FavoriteFood}");


        }
    }
}
