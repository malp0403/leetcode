using leetcode.Class;
using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0872
    {
        #region Approach 1: Depth First Search 09/22/2024
        public bool LeafSimilar_2024_09_22(TreeNode root1, TreeNode root2)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            helper_2024_09_22(root1, list1);
            helper_2024_09_22(root2, list2);

            if (list1.Count != list2.Count) { return false; }
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i]) { return false; }
            }

            return true;


        }
        public void helper_2024_09_22(TreeNode node, List<int> list)
        {
            if (node == null) return;
            if (node.left == null && node.right == null)
            {
                list.Add(node.val); return;
            }

            helper_2024_09_22(node.left, list);
            helper_2024_09_22(node.right, list);

        }
        #endregion
    }
}
