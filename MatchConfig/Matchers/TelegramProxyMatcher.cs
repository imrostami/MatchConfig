using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchConfig.Matchers
{
    public class TelegramProxyMatcher:MatcherBase
    {
        private Regex _regex;

        public TelegramProxyMatcher()
            => _regex = new Regex(Patterns.TelegramProxyPattern, DefaultMatcherOptions);


        public override List<string> Match(string input)
            => _regex.Matches(input).ToMatchList();

        public override MatcherTypes MatcherType => MatcherTypes.TelegramProxy;
    }
}