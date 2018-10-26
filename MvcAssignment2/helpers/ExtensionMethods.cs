using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAssignment2.helpers
{
    public  static class ExtensionMethods
    {
        public static string CheckInt(this string str)
        {
            var newstr = "";
            foreach (var i in str)
            {
                if (char.IsDigit(i))
                {
                    newstr += i;
                }
            }
            return newstr;
        }

        
    }
}