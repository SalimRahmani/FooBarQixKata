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

        public string Transform(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string result = string.Empty;

            foreach (int key in _rules.Keys)
            {
                if(IsDivisibleBy(number, key))
                {
                    stringBuilder.Append(_rules[key]);
                }

                string numberStr = number.ToString(CultureInfo.InvariantCulture);
                if(numberStr.Contains(key.ToString()))
                {
                    foreach(var figure in numberStr)
                    {
                        if(figure.Equals(key.ToString()[0]))
                        {
                            stringBuilder.Append(_rules[key]);
                        }
                    }
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
