using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000
{
    internal class _2462
    {
        #region 2024/09/28   https://blog.csdn.net/level_code/article/details/131411428
        public long TotalCost_2024_09_28(int[] costs, int k, int candidates)
        {
            int n = costs.Length;
            int left = candidates;
            int right = costs.Length - candidates;
            long total = 0;
       
            PriorityQueue<(int x, int y), (int x,int y)> priorityQueue = new PriorityQueue<(int x, int y), (int x, int y)>(
                Comparer<(int x, int y)>.Create((a, b) => a.y==b.y?(a.x-b.x):a.y-b.y));

            if (right < left) right = left;
            for(int i =0; i < left; i++)
            {
                priorityQueue.Enqueue((i, costs[i]), (i,costs[i]));
            }
            for(int i = right;i < n; i++)
            {
                priorityQueue.Enqueue((i, costs[i]), (i,costs[i]));
            }

            while (k > 0)
            {
                var ele= priorityQueue.Dequeue();
                total += ele.y;

                if (left < right)
                {
                    if(ele.x < left)
                    {
                        
                        priorityQueue.Enqueue((left, costs[left]), (left, costs[left]));
                        left++;
                    }
                    else
                    {
                        right--;
                        priorityQueue.Enqueue((right, costs[right]), (right, costs[right]));

                    }

                }





                k--;
            }

            return total;

            

        }
        #endregion
    }
}
