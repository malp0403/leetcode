using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0257
    {
        #region Solution
        IList<string> ans;
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            ans = new List<string>() { };
            helper(root, "");
            return ans;
        }
        public void helper(TreeNode node, string s)
        {
            if (node != null)
            {
                string temp = s.Length == 0 ? node.val.ToString() : s + "->" + node.val;
                if (node.left == null && node.right == null)
                {
                    ans.Add(temp);
                }
                else
                {
                    helper(node.left, temp);
                    helper(node.right, temp);
                }
            }
        }
        #endregion

        #region 07/09/2024
        IList<string> answer_2024_07_09;
        public IList<string> BinaryTreePaths_2024_07_09(TreeNode root)
        {
            answer_2024_07_09 = new List<string>();
            dfs(root, new List<int>());
            return answer_2024_07_09;
        }
        public void dfs(TreeNode node,List<int> list)
        {
            if (node == null) return;
            if(node !=null && node.right == null && node.left == null)
            {
                list.Add(node.val);
                answer_2024_07_09.Add(string.Join("->", list));
                list.RemoveAt(list.Count - 1);
                return;
            }
            list.Add(node.val);
                dfs(node.left, list);
                dfs(node.right, list);         
            list.RemoveAt(list.Count - 1);
        }
        #endregion
    }
}
