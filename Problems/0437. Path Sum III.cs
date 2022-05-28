using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0437
    {
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        int count = 0;
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;
            travel(root, targetSum, root.val);
            return count;
        }

        public void travel(TreeNode cur, int k, int preTotal)
        {
            if (cur == null) return;
            int curSum = preTotal + cur.val;
            if (curSum == k) count++;
            if (d.ContainsKey(curSum - k))
            {
                count += d[curSum - k];
            }
            if (d.ContainsKey(curSum)) d[curSum]++;
            else d.Add(curSum, 1);

            travel(cur.left, k, curSum);
            travel(cur.right, k, curSum);

            if (d[curSum] == 1) d.Remove(curSum);
            else { d[curSum]--; }
        }


    }
}
