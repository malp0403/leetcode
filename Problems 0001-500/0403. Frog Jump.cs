using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0403
    {

        Dictionary<(int index, int k), bool> dic;
        public bool CanCross(int[] stones)
        {
            dic = new Dictionary<(int index, int k), bool>();
            return helper(stones, 0, 0);
        }

        public bool helper(int[] stones, int index, int k)
        {
            if (index == stones.Length - 1) return true;
            if (dic.ContainsKey((index, k))) return dic[(index, k)];

            for (int i = k - 1; i <= k + 1; i++)
            {
                int nextJump = stones[index] + i;

                int nexPosition = Array.BinarySearch(stones, index + 1, stones.Length - index - 1, nextJump);
                if (nexPosition > 0)
                {
                    if (helper(stones, nexPosition, i))
                    {
                        dic.Add((index, k), true);
                        return true;

                    };
                }

            }
            dic.Add((index, k), false);

            return false;
        }
    }
}
