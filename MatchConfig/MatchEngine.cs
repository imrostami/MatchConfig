using System.Collections.Generic;
using System.Linq;

namespace MatchConfig
{
    public class MatchEngine
    {
        private List<MatcherBase> _matcher;
        public MatchEngine(List<MatcherBase> matcher)
        {
            _matcher = matcher;
        }

        public delegate void MatchResult(List<MatchEngineResult> result , string messageText);

        public event MatchResult MatchAvailable;


        public List<MatchEngineResult> GetMatches(string data)
        {
            List<MatchEngineResult> results = new List<MatchEngineResult>();

            if (!string.IsNullOrEmpty(data))
            {
                foreach (var matcher in _matcher)
                {
                    var matcherResult = matcher.Match(data);
                    results.Add(new MatchEngineResult(matcherResult, matcher.MatcherType));
                }
            }
            if (results.Any() && MatchAvailable != null)
            {
                MatchAvailable(results , messageText:data);
            }


            return results;
        }



    }
}