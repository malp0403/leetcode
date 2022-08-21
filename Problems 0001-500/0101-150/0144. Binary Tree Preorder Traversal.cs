using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0144
    {
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
        //*****************Solution 2 Iterative*************************
        public IList<int> PreorderTraversal_v2(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            TreeNode cur= root;
            while (cur!=null || stack.Count != 0)
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
                if(cur == null)
                {
                    continue;
                }
                ans.Add(cur.val);
                stack.Push(cur.right);
                stack.Push(cur.left);
               
            }
            return ans;
        }

        //*****************Solution 4 Morris Traversal*************************
        public IList<int> PreorderTraversal_v4(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            TreeNode cur = root;
            while(cur != null)
            {
                if(cur.left == null)
                {
                    ans.Add(cur.val);
                    cur = cur.right;
                }
                else
                {
                    var pre = cur.left;
                    while(pre.right !=null && pre.right != cur)
                    {
                        pre = pre.right;
                    }
                    if(pre.right == null)
                    {
                        ans.Add(cur.val);
                        pre.right = cur;
                        cur = cur.left;
                    }
                    if(pre.right == cur)
                    {
                        pre.right = null;
                        cur = cur.right;
                    }
                }
            }
            return ans;















            while (cur != null)
            {
                if(cur.left == null)
                {
                    ans.Add(cur.val);
                    cur = cur.right;
                }
                else
                {
                    var pre = cur.left;
                    while(pre.right !=null && pre.right != cur)
                    {
                        pre = pre.right;
                    }

                    if(pre.right == null)
                    {
                        ans.Add(cur.val);
                        pre.right = cur;
                        cur = cur.left;
                    }
                    else
                    {
                        pre.right = null;
                        cur = cur.right;
                    }
                }


            }
            return ans;
        }


    }
}
