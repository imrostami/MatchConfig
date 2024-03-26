using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchConfig.Matchers
{
    public class TrojanMatcher:MatcherBase
    {
        private Regex _regex;

        public TrojanMatcher()
            => _regex = new Regex(Patterns.TrojanPattern, DefaultMatcherOptions);


        public override List<string> Match(string input)
            => _regex.Matches(input).ToMatchList().Distinct().ToList();


        public override MatcherTypes MatcherType => MatcherTypes.Trojan;
    }
}