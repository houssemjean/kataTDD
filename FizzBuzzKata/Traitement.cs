using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzKata;

namespace FizzBuzzKata
{
    public static class Traitement
    {
        public static string getNumbers() {
            string result = String.Empty;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        result += " " + "FizzBuzz";
                    else
                        result += " " + "Fizz";
                }
                else
                    if (i % 5 == 0)
                    result += " " + "Buzz";
                else
                    result += " " + i.ToString();
            }
            return result.Trim();
        }
    }
}
