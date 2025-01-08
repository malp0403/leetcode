using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0313
    {
        #region  07/22/2024  remember to skip value larger than int.maxvalue
        public int NthSuperUglyNumber(int n, int[] primes)
        {
            if (n == 1) return 1;
            PriorityQueue<(double val, int index), double> queue = new PriorityQueue<(double val, int index), double>();
            queue.Enqueue((1, 0), 1);
            (double val, int index) num = (1, 0);
            while (n > 0)
            {
                num = queue.Dequeue();
                //Console.WriteLine(num + " ---  " + n);
                for (int i = num.index; i < primes.Length; i++)
                {
                    double val = num.val * primes[i];
                    if (val > int.MaxValue) continue;
                    queue.Enqueue((num.val * primes[i], i), num.val * primes[i]);
                }


                n--;
            }
            return (int)num.val;
        }
        #endregion

        #region MyRegion

        #endregion

    }
}
