using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOopDataStructuresDesignPatterns
{
    public class ExtensionMethods
    {
    }

    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
    //var result = "Hello".IsNullOrEmpty();  // Output: False

    public static class IntegerExtenstions 
    {
        public static bool IsEven(this int number) 
        {
            return number % 2 == 0;
        }

        public static bool IsNull(this int? number)
        {
            return number == null;
        }
    }

}
