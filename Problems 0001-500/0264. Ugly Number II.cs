using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0264
    {
        #region 07/09/2024
        public int NthUglyNumber(int n)
        {
            PriorityQueue<long, long> queue = new PriorityQueue<long, long>();
            queue.Enqueue(1, 1);

            HashSet<long> visit = new HashSet<long>();

            long temp = 1;
            while (n !=0)
            {
                temp = queue.Dequeue();
       
                if (!visit.Contains(temp * 2))
                {
                    queue.Enqueue(temp * 2, temp * 2);
                    visit.Add(temp * 2);
                }
                if (!visit.Contains(temp * 3))
                {
                    queue.Enqueue(temp * 3, temp * 3);
                    visit.Add(temp * 3);
                }
                if (!visit.Contains(temp * 5))
                {
                    queue.Enqueue(temp * 5, temp * 5);
                    visit.Add(temp * 5);
                }
 
                n--;
            }
            return (int)temp;
           
        }
        #endregion
    }
}
