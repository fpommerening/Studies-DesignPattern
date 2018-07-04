using System.Collections.Generic;
using System.Linq;

namespace Decorator.Sandwichs
{
    public class Salami : Sandwich
    {
        public Salami(Bread bread) : base(bread)
        {
            
        }

        public override IEnumerable<string> Ingredient =>
            base.Ingredient.Concat(new[] {"salami", "salat",
                "tomato", "green peffer", "onion"});

        public override decimal Price => Bread.Price + 4.5m;
    }
}
