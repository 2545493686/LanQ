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
        public static string Trim(this string text, string startTrim, string endTrim)
        {
            return text.TrimStart(startTrim.ToCharArray()).TrimEnd(endTrim.ToCharArray());
        }
    }
}
