using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const string BUZZ = "Buzz";
        private const string FIZZ = "Fizz";

        public string Calculate(int p)
        {
            if (isBuzz(p)) return BUZZ;
            if (isFizz(p)) return FIZZ;
            return p.ToString();
        }

        private static bool isFizz(int p)
        {
            return p % 3 == 0;
        }

        private static bool isBuzz(int p)
        {
            return p % 5 == 0;
        }
    }
}
