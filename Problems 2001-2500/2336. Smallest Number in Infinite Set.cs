using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500
{
    internal class _2336
    {
        #region 2024/09/28
        PriorityQueue<int, int> q;
        HashSet<int> contains;
        public _2336()
        {
            q = new PriorityQueue<int, int>();
            contains = new HashSet<int>();
            for(int i =1; i <= 1000; i++)
            {
                q.Enqueue(i, i);
                contains.Add(i);
            }
        }

        public int PopSmallest()
        {
            int num = q.Dequeue();
            contains.Remove(num);
            return num;
        }

        public void AddBack(int num)
        {
            if (contains.Contains(num)) return;
            contains.Add(num);
            q.Enqueue(num,num);
        }
        #endregion
    }
}
