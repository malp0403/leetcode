using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an array of positive integers arr (not necessarily distinct), return the 
lexicographically
 largest permutation that is smaller than arr, that can be made with exactly one swap. If it cannot be done, then return the same array.

Note that a swap exchanges the positions of two numbers arr[i] and arr[j]

 

Example 1:

Input: arr = [3,2,1]
Output: [3,1,2]
Explanation: Swapping 2 and 1.
Example 2:

Input: arr = [1,1,5]
Output: [1,1,5]
Explanation: This is already the smallest permutation.
Example 3:

Input: arr = [1,9,4,6,7]
Output: [1,7,4,6,9]
Explanation: Swapping 9 and 7.
 

Constraints:

1 <= arr.length <= 104
1 <= arr[i] <= 104
 */
#endregion
namespace leetcode.Problems_1001_1500._1051_1100
{
    internal class _1053
    {
        #region 11/07/2023
        public int[] PrevPermOpt1(int[] arr)
        {
            for(int i = arr.Length-2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    int j = arr.Length - 1;
                    while (arr[j] >= arr[i] || arr[j - 1] == arr[j]) j--;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    break;
                }
            }
            return arr;
        }
        #endregion
    }
}
