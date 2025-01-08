using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0319
    {
        public int BulbSwitch(int n)
        {
            Boolean[] array = Enumerable.Repeat(false, n).ToArray();
            for(int j=1; j <= n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if ((i + 1) % j == 0)
                    {
                        array[i] = !array[i];
                    }
                }
            }

            int count = 0;
            foreach (var item in array)
            {
                if (item) count++;
            }

            return count;
            
        }

    }
}
