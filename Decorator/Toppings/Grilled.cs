using System.Collections.Generic;
using System.Linq;

namespace Decorator.Toppings
{
    public class Grilled : ISandwich
    {
        private readonly ISandwich _sandwich;
        public Grilled(ISandwich sandwich)
        {
            _sandwich = sandwich;
        }

        public IEnumerable<string> Ingredient =>_sandwich.Ingredient;

        public decimal Price => _sandwich.Price + 0.5m;

        public bool IsHot => true;
    }
}
