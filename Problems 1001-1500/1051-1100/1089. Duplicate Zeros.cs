using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

 

Example 1:

Input: arr = [1,0,2,3,0,4,5,0]
Output: [1,0,0,2,3,0,0,4]
Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
Example 2:

Input: arr = [1,2,3]
Output: [1,2,3]
Explanation: After calling your function, the input array is modified to: [1,2,3]
 

Constraints:

1 <= arr.length <= 104
0 <= arr[i] <= 9
 */
#endregion

namespace leetcode.Problems_1001_1500._1051_1100
{
    internal class _1089
    {
        #region 11/07/2023
        public void DuplicateZeros(int[] arr)
        {

            List<int> list = new List<int>();
            foreach (var item in arr)
            {
                list.Add(item);
            }

            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[index];
                if (list[index] == 0 && i+1< arr.Length)
                {
                    arr[i + 1] = list[index];
                    i++;
                }
                index++;
            }
        }
        #endregion
    }
}
