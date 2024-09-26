using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0144
    {
        #region LeetCode Solution 1 Recursive
        //*****************Solution 1 Recursive*************************
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> answer = new List<int>() { };
            helper(root, answer);
            return answer;
        }
        public void helper(TreeNode n, IList<int> li)
        {
            if (n != null)
            {
                li.Add(n.val);
                helper(n.left, li);
                helper(n.right, li);
            }
        }
        #endregion
        #region LeetCode Solution 2 Iterative
        //*****************Solution 2 Iterative*************************
        public IList<int> PreorderTraversal_v2(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            TreeNode cur = root;
            while (cur != null || stack.Count != 0)
            {
                if (cur != null)
                {
                    ans.Add(cur.val);
                    stack.Push(cur);
                    cur = cur.left;
                }
                else
                {
                    cur = stack.Pop();
                    cur = cur.right;
                }
            }
            return ans;
        }
        #endregion

        #region LeetCode Solution 3 Iterative
        //*****************Solution 3 Iterative*************************
        public IList<int> PreorderTraversal_v3(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            stack.Push(root);
            TreeNode cur;
            while (stack.Count != 0)
            {
                cur = stack.Pop();
                if (cur == null)
                {
                    continue;
                }
                ans.Add(cur.val);
                stack.Push(cur.right);
                stack.Push(cur.left);

            }
            return ans;
        }
        #endregion

        #region LeetCode Solution 4 Morris Traversal
        //*****************Solution 4 Morris Traversal*************************
        public IList<int> PreorderTraversal_v4(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            TreeNode cur = root;
            while (cur != null)
            {
                if (cur.left == null)
                {
                    ans.Add(cur.val);
                    cur = cur.right;
                }
                else
                {
                    var pre = cur.left;
                    while (pre.right != null && pre.right != cur)
                    {
                        pre = pre.right;
                    }
                    if (pre.right == null)
                    {
                        ans.Add(cur.val);
                        pre.right = cur;
                        cur = cur.left;
                    }
                    if (pre.right == cur)
                    {
                        pre.right = null;
                        cur = cur.right;
                    }
                }
            }
            return ans;
        }

        #endregion

        #region 03/26/2024

        #endregion

        #region 03/27/2024 morris
        public IList<int> PreorderTraversal_Morris(TreeNode root)
        {
            IList<int> res = new List<int>();

            TreeNode node = root;
            while(node != null)
            {
                if(node.left == null)
                {
                    res.Add(node.val);
                    node = node.right;
                }
                else
                {
                    var pres = node.left;
                    while(pres.right !=null && pres.right != node)
                    {
                        pres = pres.right;
                    }

                    if(pres.right == null)
                    {
                        res.Add(node.val);
                        pres.right = node;
                        node = node.left;

                    }
                    else
                    {
                        pres.right = null;
                        node = node.right;
                    }
                }
            }
            return res;
        }
        #endregion


    }
}
