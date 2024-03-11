using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchConfig
{
    public abstract class MatcherBase
    {
        public abstract List<string> Match(string input);
        public abstract MatcherTypes MatcherType { get; }

        public const RegexOptions DefaultMatcherOptions = RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture;
    }
}