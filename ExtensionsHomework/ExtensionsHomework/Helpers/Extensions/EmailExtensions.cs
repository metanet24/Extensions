using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensionsHomework.Helpers.Extensions
{
    public static class EmailExtensions
    {
        public static bool ContainsAtSymbol(this string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string pattern = @"@";

            var res= Regex.IsMatch(email, pattern);
            
            return res;
        }



        public static bool ContainsSpaceInMiddle(this string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string pattern = @"^[^@\s]+ \S+";

            return Regex.IsMatch(email, pattern);
        }
    }
}
