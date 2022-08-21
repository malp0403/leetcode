using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1027
    {
        public int LongestArithSeqLength(int[] nums)
        {
            Dictionary<int, Dictionary<int, int>> dic = new Dictionary<int, Dictionary<int, int>>() { };

            for(int i=0; i < nums.Length; i++)
            {
                dic.Add(i,new Dictionary<int, int>() { });
            }
            int max = 0;

            for(int i=0; i < nums.Length-1; i++)
            {
                for(int j=i+1; j < nums.Length; j++)
                {
                    int gap = nums[j] - nums[i];
                    int count = dic[i].ContainsKey(gap) ? dic[i][gap] + 1 : 1;
                    var currentDic = dic[j];
                    if (currentDic.ContainsKey(gap)) currentDic[gap] = count;
                    else currentDic.Add(gap, count);
                    max = Math.Max(max, count);
                }
            }
            return max+1;


 
        }
    }
}
