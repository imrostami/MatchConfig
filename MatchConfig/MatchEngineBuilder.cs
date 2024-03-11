using System.Collections.Generic;
using System.Linq;

namespace MatchConfig
{
    public class MatchEngineBuilder
    {
        private List<MatcherBase> matchers;

        public MatchEngineBuilder()
        {
            matchers = new List<MatcherBase>();
        }

        public MatchEngineBuilder AppendMatch(MatcherBase matcher)
        {
            if (!matchers.Exists(f => f.MatcherType == matcher.MatcherType))
            {
                matchers.Add(matcher);
            }

            return this;
        }


        public MatchEngine Build() 
            => new MatchEngine(matchers);
    }
}