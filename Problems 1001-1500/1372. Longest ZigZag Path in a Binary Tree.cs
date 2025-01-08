using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500
{
    internal class _1372
    {
        #region Approach: Depth First Search 09/22/2024
        int max_2024_09_22 = 0;
        Dictionary<(TreeNode, int), int> dic_2024_09_22;
        public int LongestZigZag(TreeNode root)
        {
            helper_2024_09_22(root, true, 0);
            helper_2024_09_22(root, false, 0);
            return max_2024_09_22;

        }
        public void helper_2024_09_22(TreeNode node, bool goLeft,int steps)
        {
            if (node == null) return;
            max_2024_09_22 = Math.Max(max_2024_09_22, steps);

            if (goLeft)
            {
                helper_2024_09_22(node.left, false, steps + 1);
                helper_2024_09_22(node.right,true,1);
            }
            else
            {
                helper_2024_09_22(node.right, true, steps + 1);
                helper_2024_09_22(node.left, false, 1);
            }
        }
        #endregion

    }
}
