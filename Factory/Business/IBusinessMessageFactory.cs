using System;
using Edifact;

namespace Business
{
    public interface IBusinessMessageFactory
    {
        Predicate<IEdifactMessage> Predicate { get; }

        IBusinessMessage GetMessage(IEdifactMessage edifactMessage);
    }
}
