using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0337
    {
        #region solution
        int max = 0;
        public int Rob(TreeNode root)
        {
            int[] memory = Enumerable.Repeat(-1, 100).ToArray();


            int sum1 = travel(root, true);
            int sum2 = travel(root, false);
            Console.WriteLine("sum1 : " + sum1);
            Console.WriteLine("sum2 : " + sum2);
            return Math.Max(sum1, sum2);
        }

        public int travel(TreeNode n, bool canRob)
        {
            if (n != null)
            {
                int left = travel(n.left, !canRob);
                int right = travel(n.right, !canRob);

                return canRob ? left + right + n.val : left + right;
            }
            return 0;
        }
        #endregion

        #region 07/25/2024
        Dictionary<(TreeNode root, bool isRob),int> dic;

        public int Rob_2024_07_25(TreeNode root)
        {
            dic = new Dictionary<(TreeNode root, bool isRob), int>();
            return Math.Max(helper(root, false), helper(root, true));
        }

        public int helper(TreeNode root, bool canRob)
        {
            if (root == null) return 0;

            if (dic.ContainsKey((root,canRob)))
            {
                return dic[(root, canRob)];
            }

            int val = 0;
            if (canRob)
            {
                val = root.val + helper(root.right,false)+ helper(root.left,false);
            }
            val = Math.Max(val, helper(root.right, true) + helper(root.left, true));

            dic.Add((root, canRob), val);

            return val;
        }


        #endregion
    }
}
