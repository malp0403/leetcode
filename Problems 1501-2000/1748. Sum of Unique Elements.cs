using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1748
    {
        public int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>() { };
            int sum = 0;
            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num)) dictionary[num]++;
                else dictionary.Add(num, 1);
            }
            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] == 1) sum++;
            }
            return sum;
        }
    }
}
