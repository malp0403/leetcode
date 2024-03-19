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

        #region 03/18/2024
        public IList<TreeNode> GenerateTrees(int n)
        {
            return helper_2024_03_18(1, n);
        }

        public List<TreeNode> helper_2024_03_18(int left, int right)
        {
            if (left > right) return new List<TreeNode>() { null };

            List<TreeNode> list = new List<TreeNode>();
            for (int i = left; i <= right; i++)
            {
                List<TreeNode> l = helper_2024_03_18(left, i - 1);
                List<TreeNode> r = helper_2024_03_18(i + 1, right);

                foreach (var item in l)
                {
                    foreach (var item2 in r)
                    {
                        TreeNode temp = new TreeNode(i);
                        temp.left = item;
                        temp.right = item2;
                        list.Add(temp);
                    }
                }
            }

            return list;
        }


        #endregion
    }
}
