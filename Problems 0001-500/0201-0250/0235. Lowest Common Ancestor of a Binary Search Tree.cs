using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0235
    {
        #region 07/07/2024
        int n1_2024_07_07;
        int n2_2024_07_07;
        List<TreeNode> path_n1 = new List<TreeNode>();
        List<TreeNode> path_n2 = new List<TreeNode>();
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            n1_2024_07_07 = p.val;
            n2_2024_07_07 = q.val;
            helper_2024_07_07(root, new List<TreeNode>());

            TreeNode common = null;
            int l1 = 0;
            int l2 = 0;
            while (l1 < path_n1.Count && l2 < path_n2.Count && path_n1[l1].val == path_n2[l2].val)
            {
                common = path_n1[l1];
                l1++;
                l2++;
            }

            return common;


        }

        public void helper_2024_07_07(TreeNode node, List<TreeNode> list)
        {
            if (node == null) return;
            list.Add(node);

            if (node.val == n1_2024_07_07)
            {
                path_n1 = list.ToList();
            }
            if (node.val == n2_2024_07_07)
            {
                path_n2 = list.ToList();
            }

            helper_2024_07_07(node.left, list);
            helper_2024_07_07(node.right, list);
            list.RemoveAt(list.Count - 1);


        }


        #endregion
    }
}
