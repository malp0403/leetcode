using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace leetcode.Problems
{
    class _0095
    {
        #region 11/19/2023   left *right
        Dictionary<(int i, int j), List<TreeNode>> dic;
        public IList<TreeNode> GenerateTrees_2023_11_15(int n)
        {
            dic = new Dictionary<(int i, int j), List<TreeNode>>();
            return helper(1, n);

        }
        public List<TreeNode> helper(int start, int end)
        {
            if (start > end) return new List<TreeNode>() { null };
            if (start == end) return new List<TreeNode>() { new TreeNode(start) };

            List<TreeNode> list = new List<TreeNode>();

            for (int i = start; i <= end; i++)
            {
                List<TreeNode> left = helper(start, i - 1);
                List<TreeNode> right = helper(i + 1, end);

                foreach (TreeNode l in left)
                {

                    foreach (var r in right)
                    {
                        TreeNode temp = new TreeNode(i);
                        temp.left = l;
                        temp.right = r;

                        list.Add(temp);
                    }
                }
            }
            return list;

        }
        #endregion

    }
}
