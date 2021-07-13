using System;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Console;
namespace ExtensionMethods{

public enum Brades{F=0, D=1, C=2, B=3, A=4};

public static class ExtensionClass
        {
            public static bool ContainsNumber(this String s)
            {
                return Regex.IsMatch(s, @"\d");
            }

            public static int WordCount(this String str)
            {
                return str.Split(new char[]{'','.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            public static bool IsNumeric(this string inputString)
            {
                return decimal.TryParse(inputString, out decimal result);
            }

            //public static GRades minPassing = Gardes.D
        }

}