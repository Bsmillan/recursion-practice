using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
    class SumOfNumbers
    {
       public int result;

        public int sumOfRange(int num)
        {
            if (num == 1)
            {
                return (1);
            }
            else
            {
                result = num + sumOfRange(num - 1);
            }
            return (result);
        }
    }
}
