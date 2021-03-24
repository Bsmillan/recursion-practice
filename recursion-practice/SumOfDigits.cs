using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
    class SumOfDigits
    {
        public int result;

        public int SumDigits(int num)
        {
            if( num == 0){
                result = 0;
            }
            else
            {
                result = (num % 10) + (num / 10);
            }

            return result;
        }
    }
}
