using System.Collections.Generic;
using System.Linq;

namespace Decorator.Sandwichs
{
    public class Chicken : Sandwich
    {
        public Chicken(Bread bread) : base(bread)
        {
        }

        public override IEnumerable<string> Ingredient => 
            base.Ingredient.Concat(new[] {"chicken breast", "salat",
                "tomato", "green peffer", "cucumber"});

        public override decimal Price => Bread.Price + 5.0m;
    }
}
