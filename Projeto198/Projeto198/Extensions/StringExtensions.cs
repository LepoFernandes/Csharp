using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto198.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string ThisObj, int count)
        {
            if (ThisObj.Length <= count)
            {
                return ThisObj;
            }
            else
            {
              return ThisObj.Substring(0, count) + "...";
            }
        }
    }
}
