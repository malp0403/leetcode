using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region examples
/*
 Example 1:

Input: nums = [1,1,1]
Output: 1
Explanation: The only good way to split nums is [1] [1] [1].
Example 2:

Input: nums = [1,2,2,2,5,0]
Output: 3
Explanation: There are three good ways of splitting nums:
[1] [2] [2,2,5,0]
[1] [2,2] [2,5,0]
[1,2] [2,2] [5,0]
Example 3:

Input: nums = [3,2,1]
Output: 0
Explanation: There is no good way to split nums.
 */
#endregion

namespace leetcode.Problems_1501_2000._1701_1750
{
    internal class _1712
    {
        #region 10/17/2023 TLE
        public int WaysToSplit_20231017_TLE(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int total = 0;
            for(int i =0;i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prefix[i] = nums[i];
                }
                else
                {
                    prefix[i] = prefix[i - 1] + nums[i];
                }
                total += nums[i];
            }
            int count = 0;

            for(int i =0; i < nums.Length - 1; i++)
            {
               for(int j = i + 1; j < nums.Length - 2; j++)
                {
                    int mid = prefix[j] - prefix[i];
                    int right = total - prefix[j];
                    if(mid >= prefix[i] && mid <= right)
                    {
                        Console.WriteLine(i + " , " + j + " , " );
                        count++;
                    }
                }
            }

            return count;
        }
        #endregion

        #region 10/17/2023 using Binary search to avoid TLE 
        public int WaysToSplit(int[] nums)
        {
            int modulo = 1000000007;
            int[] prefix = new int[nums.Length];
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prefix[i] = nums[i];
                }
                else
                {
                    prefix[i] = prefix[i - 1] + nums[i];
                }
                total += nums[i];
            }
            int count = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left_bound = helper_binary_leftBound(i + 1, prefix, total);
                int right_bound = helper_binary_rightBound(i + 1, prefix, total);
                if (left_bound > right_bound || left_bound == -1 || right_bound == -1) continue;
                int add = right_bound - left_bound + 1;
                count = (count + add) % modulo;
    


            }

            return count;
        }

        public int helper_binary_leftBound(int startIndex, int[] prefix,int total)
        {
            int l = startIndex;
            int r = prefix.Length - 1;
            int answer = -1;
            while(l < r)
            {
                int mid = l + (r - l) / 2;
                if (prefix[mid] - prefix[startIndex-1] >= prefix[startIndex - 1])
                {
                    answer = mid;
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return answer;

        }

        public int helper_binary_rightBound(int startIndex, int[] prefix, int total)
        {
            int l = startIndex;
            int r = prefix.Length - 1;
            int answer = -1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (total - prefix[mid] >= prefix[mid] - prefix[startIndex-1])
                {
                    answer = mid;
                    l = mid+1;
                }
                else
                {
                    r = mid;
                }
            }
            return answer;

        }


        #endregion
    }
}
