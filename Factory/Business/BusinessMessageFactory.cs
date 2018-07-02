using System;
using System.Collections.Generic;
using System.Linq;
using Edifact;

namespace Business
{
    public class BusinessMessageFactory
    {
        private readonly IBusinessMessageFactory[] _factories;

        public BusinessMessageFactory(IEnumerable<IBusinessMessageFactory> factories)
        {
            _factories = factories.ToArray();
        }

        public IBusinessMessage GetMessage(IEdifactMessage edimsg)
        {
            var matchingFactory = _factories.FirstOrDefault(x => x.Predicate(edimsg));
            if (matchingFactory != null)
            {
                return matchingFactory.GetMessage(edimsg);
            }
            throw new NotSupportedException($"There no matching factory for {edimsg.MessageId} - {edimsg.Version}");
        }
    }
}
