using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
    class PrimeNumber
    {
        public int result;
        public int i;
        public int IsPrime(int n1)
        {
            i = n1 / 2;
            if (i == 1)
            {
                result = 1;
                
            }
            else if (n1 % i == 0)
            {
                result = 0;
            }
            else
            {
                i = i - 1;
                IsPrime(n1);
            }
            return result;
        }
    }
}
