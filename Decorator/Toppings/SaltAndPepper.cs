using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator.Toppings
{
    public class SaltAndPepper : ISandwich
    {
        private readonly ISandwich _sandwich;
        public SaltAndPepper(ISandwich sandwich)
        {
            _sandwich = sandwich;
        }

        public IEnumerable<string> Ingredient => _sandwich.Ingredient.Concat(new[] {"salt and pepper"});

        public decimal Price => _sandwich.Price + decimal.Zero;

        public bool IsHot => _sandwich.IsHot | false;
    }
}
