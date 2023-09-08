using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0473
    {
        #region 09/05/2023 DFS; sort the list from large to small
        List<int> nums;
        int[] sums;
        int possibleSqureSide;
        public bool Makesquare(int[] matchsticks)
        {
            nums = matchsticks.ToList();
            sums = Enumerable.Repeat(0, 4).ToArray();
            int sum = 0;
            for(int i =0;i< matchsticks.Length; i++)
            {
                sum += matchsticks[i];
            }
            if (sum % 4 != 0) return false;
            possibleSqureSide = sum / 4;
            nums.Sort((a, b) => { return b - a; }); 
            return dfs(0);

        }
        public bool dfs(int index)
        {
            if(index == nums.Count)
            {
                return sums[0] == sums[1] && sums[1] == sums[2] && sums[2] == sums[3];
            }

            int element = nums[index];

            for(int i =0; i < 4; i++)
            {
                if ((sums[i] + element) <= possibleSqureSide)
                {
                    sums[i] += element;
                    if (dfs(index + 1))
                    {
                        return true;
                    }
                    sums[i] -= element;
                }
            }
            return false;
        }
        #endregion

    }
}
