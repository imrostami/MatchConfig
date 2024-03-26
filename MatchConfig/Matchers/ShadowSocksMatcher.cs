using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchConfig.Matchers
{
    public class ShadowSocksMatcher:MatcherBase
    {
        private Regex _regex;

        public ShadowSocksMatcher() 
            => _regex = new Regex(Patterns.ShadowSocksPattern,DefaultMatcherOptions);


        public override List<string> Match(string input)
            => _regex.Matches(input).ToMatchList().Distinct().ToList();

        public override MatcherTypes MatcherType => MatcherTypes.ShadowSocks;
    }
}