using System.Collections.Generic;
using System.Linq;

namespace Decorator.Toppings
{
    public class ExtraCheese : ISandwich
    {
        private readonly ISandwich _sandwich;
        public ExtraCheese(ISandwich sandwich)
        {
            _sandwich = sandwich;
        }

        public IEnumerable<string> Ingredient =>
            _sandwich.Ingredient.Concat(new[] { "extra cheese"});

        public decimal Price => _sandwich.Price + 1.0m;

        public bool IsHot => _sandwich.IsHot | false;
    }
}
