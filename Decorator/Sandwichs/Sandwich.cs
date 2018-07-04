using System.Collections.Generic;

namespace Decorator.Sandwichs
{
    public abstract class Sandwich : ISandwich
    {
        protected Bread Bread { get; }

        protected Sandwich(Bread bread)
        {
            Bread = bread;
        }

        public virtual IEnumerable<string> Ingredient => Bread.Ingredient;

        public abstract decimal Price { get; }

        public bool IsHot { get; } = false;
    }
}
