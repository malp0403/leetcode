using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0740
    {
        int max = 0;
        SortedDictionary<int, int> dic = new SortedDictionary<int, int>() { };
        public int DeleteAndEarn(int[] nums)
        {
            dic = new SortedDictionary<int, int>() { };
            foreach (var num in nums)
            {
                if (!dic.ContainsKey(num)) dic.Add(num, 1);
                else dic[num]++;
            }
            List<int> list = new List<int>(dic.Keys);
            backtracking(0,list, 0);

            return max;
            
        }

        public void backtracking(int indx, List<int> list,int sum)
        {
            if(indx >= list.Count)
            {
                return;
            }

            for(int i = indx; i< list.Count; i++)
            {
                var future = sum + dic[list[i]] * list[i];
                if (i < list.Count-1 && list[i] +1 == list[i + 1])
                {
                    i++;
                    backtracking(i, list, sum);
                }
                sum = future;
            }
            max = Math.Max(sum, max);
        }
        // 01-23-2022-----------------------------------
        public int DeleteAndEarn_R2(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, 10000).ToArray();
            foreach (var num in nums)
            {
                arr[num]++;
            }

            int avoid = 0;
            int use = 0;
            int pre = -1;
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    int m = Math.Max(avoid, use);
                    if (i != pre+1)
                    {
                        use = m + i * arr[i];
                        avoid = m;
                    }
                    else
                    {
                        use = avoid + m;
                        avoid = m;
                    }
                    pre = i;
                }
            }
            return Math.Max(avoid, use);
        }
        public void helper_R2(int indx,List<int> list,int sum)
        {
            if(indx >= list.Count)
            {
                return;
            }
            for(int i = indx; i < list.Count; i++)
            {
                int f= sum + list[i] * dic[list[i]];
                if (i < list.Count-1 && list[i] +1 == list[i + 1])
                {
                    i++;
                    helper_R2(i, list, sum);
                }
                sum = f;
            }
            max = Math.Max(sum, max);
        }
    }
}
