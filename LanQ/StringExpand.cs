using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LanQ
{
    public static class StringExpand
    {
        public static Match Match(this string input, string pattern)
        {
            Regex regex = new Regex(input);
            return regex.Match(pattern);
        }

        public static MatchCollection Matches(this string input, string pattern)
        {
            Regex regex = new Regex(input);
            return regex.Matches(pattern);
        }

        public static bool IsMatch(this string input, string pattern)
        {
            Regex regex = new Regex(input);
            return regex.IsMatch(pattern);
        }
    }
}
