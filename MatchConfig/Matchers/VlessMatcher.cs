using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchConfig.Matchers
{
    public class VlessMatcher:MatcherBase
    {
        private Regex _regex;

        public VlessMatcher()
            => _regex = new Regex(Patterns.VlessPattern, DefaultMatcherOptions);


        public override List<string> Match(string input)
            => _regex.Matches(input).ToMatchList();

        public override MatcherTypes MatcherType => MatcherTypes.Vless;
    }
}