using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1801_1850
{
    internal class _1838
    {
        #region 10/11/2023 greedy
        int min = int.MaxValue;
        int max = int.MinValue;
        public int MaxFrequency(int[] nums, int k)
        {
            // find maxValue
            int maxHeight = 1;
            foreach (var item in nums)
            {
                maxHeight= Math.Max(maxHeight, item);
            }
            //count each value occurence
            int[] counts = Enumerable.Repeat(0, maxHeight + 1).ToArray();
            foreach (var item in nums)
            {
                counts[item]++;
            }

            long[] records = Enumerable.Repeat((long)0, maxHeight + 1).ToArray();

            for(int i = 1; i < records.Length; i++)
            {
                int c = counts[i]!=0? counts[i] : 0;
                records[i] = records[i - 1] + c * i;
            }

            int answer = 0;
            int accumulateWidth = 0;
            for(int i =1; i < records.Length; i++)
            {
                accumulateWidth = accumulateWidth +(counts[i] != 0 ? counts[i] : 0);
                long areas = accumulateWidth * i;
                if(areas - records[i] <= k)
                {
                    answer = accumulateWidth;
                }
                else
                {
                    break;
                }
            }
            return answer;        
        }
        public void helper(int[] nums,int remains)
        {
            if(remains == 0)
            {

                return;
            }

            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] < max)
                {
                    nums[i]++;
                    helper(nums, remains - 1);
                    nums[i]--;
                }
            }
        }
        public int cal(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int max = 1;
            foreach (var item in nums)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                    max = Math.Max(dic[item], max);
                }
                else
                {
                    dic.Add(item, max);
                }
            }
            return 0;
        }
        #endregion
    }
}
