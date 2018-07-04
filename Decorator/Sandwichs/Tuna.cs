using System.Collections.Generic;
using System.Linq;

namespace Decorator.Sandwichs
{
    public class Tuna : Sandwich
    {
        public Tuna(Bread bread) : base(bread)
        {
            
        }

        public override IEnumerable<string> Ingredient =>
            base.Ingredient.Concat(new[] { "tuna", "salat",
                "tomato", "cucumber", "onion" });

        public override decimal Price => Bread.Price + 4m;
    }
}
