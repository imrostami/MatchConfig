using System.Collections.Generic;

namespace MatchConfig
{
    public class MatchEngineResult
    {
        public List<string> MatchData { get; set; }
        public MatcherTypes MatchType { get; set; }

        public MatchEngineResult(List<string> matchData, MatcherTypes matchType)
        {
            MatchData = matchData;
            MatchType = matchType;
        }
    }
}