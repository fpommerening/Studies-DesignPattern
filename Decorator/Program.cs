using System;
using Decorator.Breads;
using Decorator.Sandwichs;
using Decorator.Toppings;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISandwich sandwich = new Chicken(new Sesam());
            sandwich = new ExtraCheese(sandwich);
            sandwich = new SaltAndPepper(sandwich);
            sandwich = new Grilled(sandwich);


            if (sandwich.IsHot)
            {
                Console.WriteLine("Caution - HOT");
            }
            Console.WriteLine(string.Join(Environment.NewLine, sandwich.Ingredient));
            Console.WriteLine($"Price: {sandwich.Price:C}");

            Console.ReadLine();
        }
    }
}
