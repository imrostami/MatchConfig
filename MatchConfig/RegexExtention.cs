using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchConfig
{
    public static class RegexExtention
    {
        public static List<string> ToMatchList(this MatchCollection matchs)
            => matchs.Cast<Match>()
                .Select(f => f.Value.Trim())
                .ToList();
    }
}