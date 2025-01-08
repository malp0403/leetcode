using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Question
/*
 Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

 

Example 1:

Input: arr = [1,2,2,1,1,3]
Output: true
Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
Example 2:

Input: arr = [1,2]
Output: false
Example 3:

Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
Output: true
 

Constraints:

1 <= arr.length <= 1000
-1000 <= arr[i] <= 1000
 */
#endregion
namespace leetcode.Problems_1001_1500._1201_1250
{
    internal class _1207
    {
        #region 09/17/2024
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }

            HashSet<int> set = new HashSet<int>();

            foreach (var item in dic.Keys)
            {
                if (set.Contains(dic[item])) { return false; }
                set.Add(dic[item]);
            }
            return true;
        }
        #endregion
    }
}
