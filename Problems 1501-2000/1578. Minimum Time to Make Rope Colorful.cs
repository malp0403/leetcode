using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Alice has n balloons arranged on a rope. You are given a 0-indexed string colors where colors[i] is the color of the ith balloon.

Alice wants the rope to be colorful. She does not want two consecutive balloons to be of the same color, so she asks Bob for help. Bob can remove some balloons from the rope to make it colorful. You are given a 0-indexed integer array neededTime where neededTime[i] is the time (in seconds) that Bob needs to remove the ith balloon from the rope.

Return the minimum time Bob needs to make the rope colorful.

 

Example 1:


Input: colors = "abaac", neededTime = [1,2,3,4,5]
Output: 3
Explanation: In the above image, 'a' is blue, 'b' is red, and 'c' is green.
Bob can remove the blue balloon at index 2. This takes 3 seconds.
There are no longer two consecutive balloons of the same color. Total time = 3.
Example 2:


Input: colors = "abc", neededTime = [1,2,3]
Output: 0
Explanation: The rope is already colorful. Bob does not need to remove any balloons from the rope.
Example 3:


Input: colors = "aabaa", neededTime = [1,2,3,4,1]
Output: 2
Explanation: Bob will remove the ballons at indices 0 and 4. Each ballon takes 1 second to remove.
There are no longer two consecutive balloons of the same color. Total time = 1 + 1 = 2.
 

Constraints:

n == colors.length == neededTime.length
1 <= n <= 105
1 <= neededTime[i] <= 104
colors contains only lowercase English letters.
 */
#endregion
namespace leetcode.Problems_1501_2000._1551_1600
{
    internal class _1578
    {
        #region 10/19/2023 one way pass with if else

        public int MinCost(string colors, int[] neededTime)
        {
            char curColor = ' ';
            int curSum = 0;
            int curMax = 0;
            int answer = 0;
            for(int i=0; i < colors.Length; i++)
            {
                if (colors[i] != curColor)
                {
                    answer += (curSum - curMax);
                    curColor = colors[i];
                    curSum = neededTime[i];
                    curMax = neededTime[i];

                }
                else
                {
                    curSum += neededTime[i];
                    curMax = Math.Max(curMax, neededTime[i]);
                }
                
            }

            answer += (curSum - curMax);

            return answer;
        }

        #endregion

        #region 10/19/2023

        public int MinCost_simplerOneway(string colors, int[] neededTime)
        {
            int answer = 0;
            int curMax = 0;

            for(int i =0; i < colors.Length; i++)
            {
                if(i>0 && colors[i] != colors[i - 1])
                {
                    curMax = 0;
                }

                answer += Math.Min(curMax, neededTime[i]);
                curMax = Math.Max(curMax, neededTime[i]);
            }
            return answer;
        }

        #endregion
    }
}
