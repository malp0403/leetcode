using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0250
    {
        #region 07/08/2024 DFS
        int count = 0;
        public int CountUnivalSubtrees_2024_07_08(TreeNode root)
        {
            isUni(root);

            return count;
        }

        public bool isUni(TreeNode node)
        {
            if (node == null) return true;
            else 
            {
                bool left = isUni(node.left);
                int leftValu = node.left != null ? node.left.val : node.val;
                bool right = isUni(node.right);
                int rightValu = node.right != null ? node.right.val : node.val;

                if (left && right && node.val == leftValu && node.val == rightValu) {

                    count++;
                    return true;
                }

                return false;
            }
        }
        #endregion
    }
}
