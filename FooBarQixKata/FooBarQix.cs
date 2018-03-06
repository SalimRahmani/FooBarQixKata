using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixKata
{
    public class FooBarQix
    {
        private readonly SortedDictionary<int, string> _rules = new SortedDictionary<int, string>()
        {
            { 3, "Foo"},
            { 5, "Bar"},
            { 7, "Qix"}
        };
        private const int Min = 1;
        private const int Max = 100;

        /// <summary>
        /// Transforms the provided number to a FooBarQix string. 
        /// Returns the same number if not.
        /// </summary>
        /// <param name="number">number between 1 and 100.</param>
        /// <exception cref="ArgumentException">Thrown when number is out of bounds</exception>
        /// <returns></returns>
        public string Transform(int number)
        {
            if (number < Min || number > Max)
            {
                throw new ArgumentException(number + " is out of bounds (" + Min + " to " + Max + ")");
            }

            StringBuilder stringBuilder = new StringBuilder();
            string result = string.Empty;

            foreach (KeyValuePair<int, string> entry in _rules)
            {
                if(IsDivisibleBy(number, entry.Key))
                {
                    stringBuilder.Append(entry.Value);
                }
            }

            string numberStr = number.ToString(CultureInfo.InvariantCulture);
            foreach (char figureChar in numberStr)
            {
                int figure = (int)Char.GetNumericValue(figureChar);
                if (_rules.ContainsKey(figure))
                {
                    stringBuilder.Append(_rules[figure]);
                }
            }

            result = stringBuilder.ToString();
            return string.IsNullOrEmpty(result) ? number.ToString(CultureInfo.InvariantCulture) : result;
        }

        private bool IsDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
