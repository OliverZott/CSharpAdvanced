using System;
using System.Linq;

namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static string Shorten(this string stringValue, int numberOfWords)
        {
            var words = stringValue.Split(' ');

            if (words.Length <= numberOfWords)
                return stringValue;

            var result = new string[numberOfWords];
            var i = 0;
            while (i < numberOfWords)
            {
                result[i] = words[i];
                i++;
            }

            return string.Join(' ', result) + " ...";
        }


        public static string Shorten2(this string stringValue, int numberOfWords)
        {

            switch (numberOfWords)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException(nameof(numberOfWords)+ "WTF", "Value has to be > 0");
                case 0:
                    return "";
                default:
                {
                    var words = stringValue.Split(' ');
                    return words.Length < numberOfWords ? stringValue : string.Join(' ', words.Take(numberOfWords));
                }
            }
        }

    }
}