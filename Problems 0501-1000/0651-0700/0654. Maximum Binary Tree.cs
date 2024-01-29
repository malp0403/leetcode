﻿using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You are given an integer array nums with no duplicates. A maximum binary tree can be built recursively from nums using the following algorithm:

Create a root node whose value is the maximum value in nums.
Recursively build the left subtree on the subarray prefix to the left of the maximum value.
Recursively build the right subtree on the subarray suffix to the right of the maximum value.
Return the maximum binary tree built from nums.

 

Example 1:


Input: nums = [3,2,1,6,0,5]
Output: [6,3,5,null,2,0,null,null,1]
Explanation: The recursive calls are as follow:
- The largest value in [3,2,1,6,0,5] is 6. Left prefix is [3,2,1] and right suffix is [0,5].
    - The largest value in [3,2,1] is 3. Left prefix is [] and right suffix is [2,1].
        - Empty array, so no child.
        - The largest value in [2,1] is 2. Left prefix is [] and right suffix is [1].
            - Empty array, so no child.
            - Only one element, so child is a node with value 1.
    - The largest value in [0,5] is 5. Left prefix is [0] and right suffix is [].
        - Only one element, so child is a node with value 0.
        - Empty array, so no child.
Example 2:


Input: nums = [3,2,1]
Output: [3,null,2,null,1]
 

Constraints:

1 <= nums.length <= 1000
0 <= nums[i] <= 1000
All integers in nums are unique.
All integers in nums are unique.
 */
#endregion
namespace leetcode.Problems_0501_1000._0651_0700
{
    internal class _0654
    {
        #region 12/05/2023
        int[] nums_2023_12_05;
        public TreeNode ConstructMaximumBinaryTree_2023_12_05(int[] nums)
        {
            nums_2023_12_05 = nums;

            return helper_2023_12_05(0, nums.Length - 1);
        }

        public TreeNode helper_2023_12_05(int l,int r)
        {
            if (l == r) return new TreeNode(nums_2023_12_05[l]);
            if (l > r) return null;

            int index = l;
            int max = int.MinValue;

            for(int i=l; i <= r; i++)
            {
                if (nums_2023_12_05[i] > max)
                {
                    max= nums_2023_12_05[i];
                    index = i;
                }
            }

            TreeNode left = helper_2023_12_05(l, index - 1);
            TreeNode right = helper_2023_12_05(index + 1, r);

            TreeNode cur = new TreeNode(nums_2023_12_05[index]);
            cur.left = left;
            cur.right = right;

            return cur;
        }
        #endregion
    }
}
