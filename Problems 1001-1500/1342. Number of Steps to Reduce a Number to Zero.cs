using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500._1301_1350
{
    internal class _1342
    {
        #region 11/03/2023 Math
        public int NumberOfSteps(int num)
        {
            int steps = 0;
            while(num != 0)
            {
                if(num %2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }
                steps++;
            }
            return steps;
        }
        #endregion

        #region Bit Manipulation

        #endregion
    }
}
