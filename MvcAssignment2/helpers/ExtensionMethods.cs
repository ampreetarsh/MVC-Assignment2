using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAssignment2.helpers
{
    public  static class ExtensionMethods
    {
        public static string ToDigitsOnly(this string str)
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

        public static int ToAge(this DateTimeOffset dateOfBirth) {
            var today = DateTime.Today;
            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
    }
}