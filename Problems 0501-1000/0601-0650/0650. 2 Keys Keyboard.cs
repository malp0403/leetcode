using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 There is only one character 'A' on the screen of a notepad. You can perform one of two operations on this notepad for each step:

Copy All: You can copy all the characters present on the screen (a partial copy is not allowed).
Paste: You can paste the characters which are copied last time.
Given an integer n, return the minimum number of operations to get the character 'A' exactly n times on the screen.

 

Example 1:

Input: n = 3
Output: 3
Explanation: Initially, we have one character 'A'.
In step 1, we use Copy All operation.
In step 2, we use Paste operation to get 'AA'.
In step 3, we use Paste operation to get 'AAA'.
Example 2:

Input: n = 1
Output: 0
 */
#endregion
namespace leetcode.Problems_0501_1000._0601_0650
{
    internal class _0650
    {
        #region 12/04/2023
        int max_2023_12_04 = int.MaxValue;
        public int MinSteps(int n)
        {
            helper_2023_12_04(n, 1, 0, false, 0);
            return max_2023_12_04;
        }
        public void helper_2023_12_04(int target, int curCount,int curCopy,bool isPrevCopy,int operations)
        {
            if (curCount > target)
            {
                return;
            }

            if(curCount == target)
            {
                max_2023_12_04 = Math.Min(max_2023_12_04, operations);
                return;
            }
            //if previous is copy, dont make sense to copy again. 
            if (!isPrevCopy)
            {
                helper_2023_12_04(target, curCount, curCount, true, operations + 1);
            }
            //if curCopy is not 0 then can paste
            if(curCopy != 0)
            {
                helper_2023_12_04(target, curCount + curCopy, curCopy, false, operations + 1);
            }

        }
        #endregion
    }
}
