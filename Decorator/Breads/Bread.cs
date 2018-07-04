using System.Collections.Generic;

namespace Decorator.Sandwichs
{
    public abstract class Bread : ISandwich
    {
        public IEnumerable<string> Ingredient => new[] {$"Bread: {Name}"};

        public abstract decimal Price { get; }

        public abstract string Name { get; }

        public virtual bool IsHot { get; } = false;
    }
}
