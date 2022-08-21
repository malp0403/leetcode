using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1762
    {
        public int[] FindBuildings(int[] heights)
        {
            int max = 0;
            List<int> ans = new List<int>() { };
            for(int i=heights.Length-1; i >= 0; i--)
            {
                if(heights[i] > max)
                {
                    ans.Add(i);
                    max = heights[i];
                }
            }
            ans.Sort();
            return ans.ToArray();
        }
    }
}
