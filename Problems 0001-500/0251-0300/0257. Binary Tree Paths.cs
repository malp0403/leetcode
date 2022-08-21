using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0257
    {
        IList<string> ans;
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            ans = new List<string>() { };
            helper(root, "");
            return ans;
        }
        public void helper(TreeNode node,string s)
        {
            if(node != null)
            {
                string temp = s.Length ==0 ?node.val.ToString() :s + "->" + node.val;
                if (node.left == null && node.right == null) {
                    ans.Add(temp);
                }
                else
                {
                    helper(node.left, temp);
                    helper(node.right, temp);
                }
            }
        }
    }
}
