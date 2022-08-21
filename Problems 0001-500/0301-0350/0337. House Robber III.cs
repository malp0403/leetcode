using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0337
    {
        int max = 0;
        public int Rob(TreeNode root)
        {
            int[] memory = Enumerable.Repeat(-1, 100).ToArray();


            int sum1=travel(root, true);
            int sum2 = travel(root, false);
            Console.WriteLine("sum1 : " + sum1);
            Console.WriteLine("sum2 : " + sum2);
            return Math.Max(sum1,sum2);
        }

        public int travel(TreeNode n, bool canRob)
        {
            if (n != null)
            {
                int left  =travel(n.left, !canRob);
                int right =travel(n.right, !canRob);

                return canRob ? left + right + n.val : left + right;
            }
            return 0;
        }
    }
}
