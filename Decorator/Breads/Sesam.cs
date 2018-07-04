using System;
using Decorator.Sandwichs;

namespace Decorator.Breads
{
    public class Sesam : Bread
    {
        public override decimal Price { get; } = Decimal.Zero;
        public override string Name { get; } = "Sesam";
    }
}
