using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You are given an integer array nums​​​ and an integer k. You are asked to distribute this array into k subsets of equal size such that there are no two equal elements in the same subset.

A subset's incompatibility is the difference between the maximum and minimum elements in that array.

Return the minimum possible sum of incompatibilities of the k subsets after distributing the array optimally, or return -1 if it is not possible.

A subset is a group integers that appear in the array with no particular order.

 

Example 1:

Input: nums = [1,2,1,4], k = 2
Output: 4
Explanation: The optimal distribution of subsets is [1,2] and [1,4].
The incompatibility is (2-1) + (4-1) = 4.
Note that [1,1] and [2,4] would result in a smaller sum, but the first subset contains 2 equal elements.
Example 2:

Input: nums = [6,3,8,1,3,1,2,2], k = 4
Output: 6
Explanation: The optimal distribution of subsets is [1,2], [2,3], [6,8], and [1,3].
The incompatibility is (2-1) + (3-2) + (8-6) + (3-1) = 6.
Example 3:

Input: nums = [5,3,3,6,3,3], k = 3
Output: -1
Explanation: It is impossible to distribute nums into 3 subsets where no two elements are equal in the same subset.
 

Constraints:

1 <= k <= nums.length <= 16
nums.length is divisible by k
1 <= nums[i] <= nums.length
 */
#endregion

#region Test
/*
             var obj = new _1681() { };
            obj.MinimumIncompatibility(new int[] { 6, 3, 8, 1, 3, 1, 2, 2 }, 4);
 */
#endregion

namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1681
    {
        #region 10/17/2023 DFS
        int min = int.MaxValue;
        int setLimit = 0;
        public int MinimumIncompatibility(int[] nums, int k)
        {
            List<(int total,int[] arr)> list = new List<(int total, int[] arr)>();
            setLimit = nums.Length / k;
            for(int i =0; i < k; i++)
            {
                list.Add((0,Enumerable.Repeat(0, 17).ToArray()));
            }
            int[] temp = Enumerable.Repeat(0, 17).ToArray();
            temp[nums[0]] = 1;

            list[0] = (1, temp);
            dfs(1, nums, list, 0);
            return min != int.MaxValue? min:-1;
        }
        public void dfs(int index, int[] nums, List<(int total, int[] arr)> list,int listIndex)
        {
            if (index >= nums.Length)
            {
                // cal the total difference;
                min = Math.Min(min, cal(list));
                return;
            }

            // open a new subSet
            if(listIndex < list.Count - 1)
            {
                list[listIndex + 1].arr[nums[index]] = 1;
                list[listIndex + 1] = (1, list[listIndex + 1].arr);

                dfs(index + 1, nums, list, listIndex + 1);

                list[listIndex + 1].arr[nums[index]] = 0;
                list[listIndex + 1] = (0, list[listIndex + 1].arr);
            }

            for (int i=0; i <= listIndex; i++)
            {
                int val = nums[index];
                //if value is not present and total subset is less than setLimit
                if (list[i].arr[val] == 0 && list[i].total < setLimit)
                {
                    list[i].arr[val] = 1;
                    list[i] = (list[i].total + 1, list[i].arr);
                 
                    dfs(index + 1, nums, list, listIndex);

                    list[i].arr[val] = 0;
                    list[i] = (list[i].total -1, list[i].arr);
                }
            }
            
        }

        public int cal(List<(int total, int[] arr)> list)
        {
            int sum = 0;

            foreach (var item in list)
            {
                int minIndex = 0;
                while(item.arr[minIndex] ==0)
                {
                    minIndex++;
                }
                int maxIndex = 16;
                while (item.arr[maxIndex] == 0)
                {
                    maxIndex--;
                }
                sum += (maxIndex - minIndex);
            }

            return sum;
        }

        #endregion
    }
}
