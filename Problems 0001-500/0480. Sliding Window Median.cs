using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test
/*
         var obj = new _0480();
            obj.MedianSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 },3);
 
 */
#endregion

namespace leetcode.Problems_0001_500
{
    internal class _0480
    {
        #region Approach 2: Two Heaps (Lazy Removal); careful overflow
        public double[] MedianSlidingWindow(int[] _nums, int k)
        {
            double[] nums = _nums.Select(x => (double)x).ToArray();
            Dictionary<double, int> dic = new Dictionary<double, int>();
            List<double> ans = new List<double>();
            PriorityQueue<double, double> lo = new PriorityQueue<double, double>();
            PriorityQueue<double, double> hi = new PriorityQueue<double, double>();

            int i = 0;
            while (i < k)
            {
                lo.Enqueue(nums[i], -1.0*nums[i]);
                i++;
            }
            for(int j = 0; j < k / 2; j++)
            {
                double temp = lo.Dequeue();
                hi.Enqueue(temp, temp);
            }
            
            while (true)
            {
                if(k % 2 == 1)
                {
                    ans.Add(lo.Peek());
                }
                else
                {
                    ans.Add((lo.Peek()*0.5 + hi.Peek() * 0.5));
                }

                if (i >= nums.Length) { break; }

                double out_num = nums[i - k];
                double in_num = nums[i++];
                int balance = 0;

                balance += (out_num <= lo.Peek()) ? -1 : 1;
                if(dic.ContainsKey(out_num))
                {
                    dic[out_num]++;
                }
                else
                {
                    dic.Add(out_num, 1);
                }

                if(lo.Count >0 && in_num <= lo.Peek())
                {
                    balance++;
                    lo.Enqueue(in_num,-in_num);
                }
                else
                {
                    balance--;
                    hi.Enqueue(in_num, in_num);
                }

                if (balance < 0)
                {
                    double temp = hi.Dequeue();
                    lo.Enqueue(temp, -temp);
                    balance++;
                }
                if(balance > 0)
                {
                    double temp = lo.Dequeue();
                    hi.Enqueue(temp, temp);
                    balance--;
                }

                while (dic.ContainsKey(lo.Peek()))
                {
                    dic[lo.Peek()]--;
                    if (dic[lo.Peek()]==0){
                        dic.Remove(lo.Peek());
                    }
                    lo.Dequeue();
                }

                while(hi.Count>0 && dic.ContainsKey(hi.Peek()))
                {
                    dic[hi.Peek()]--;
                    if (dic[hi.Peek()] == 0)
                    {
                        dic.Remove(hi.Peek());
                    }
                    hi.Dequeue();
                }


            }

            return ans.ToArray();
            


        }
        #endregion
    }
}
