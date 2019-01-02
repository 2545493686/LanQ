using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanQ
{
    public static class ListExpand
    {
        public static bool HasOneSameItem(this IEnumerable thisCollection, IEnumerable beFoundList)
        {
            foreach (var thisItem in thisCollection)
            {
                foreach (var beFoundItem in beFoundList)
                {
                    if (beFoundItem == thisItem)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
