using System.Collections.Generic;

namespace Decorator
{
    public interface ISandwich
    {
        IEnumerable<string> Ingredient { get; }

        decimal Price { get; }

        bool IsHot { get; }
    }
}
