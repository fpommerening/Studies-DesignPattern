using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Sandwichs;

namespace Decorator.Breads
{
    public class Italian : Bread
    {
        public override decimal Price { get; } = Decimal.Zero;
        public override string Name { get; } = "Italian";
    }
}
