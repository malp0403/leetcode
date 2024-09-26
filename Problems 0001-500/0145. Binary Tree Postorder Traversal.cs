using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0145
    {
        #region Solution 1
        IList<int> ans = new List<int>() { };
        public IList<int> PostorderTraversal(TreeNode root)
        {
            ans = new List<int>() { };
            if (root == null) return ans;
            helper(root);
            return ans;
        }
        public void helper(TreeNode n)
        {
            if (n != null)
            {
                helper(n.left);
                helper(n.right);
                ans.Add(n.val);

            }
        }
        #endregion
        #region Solution2
        //******************Solution 2************************
        public IList<int> PostorderTraversal_V2(TreeNode root)
        {
            ans = new List<int>() { };
            if (root == null) return ans;
            Stack<TreeNode> s = new Stack<TreeNode>() { };
            HashSet<TreeNode> set = new HashSet<TreeNode>() { };
            TreeNode cur = root;

            while (cur != null || s.Count != 0)
            {
                while (cur != null && !set.Contains(cur))
                {
                    s.Push(cur);
                    cur = cur.left;
                }
                cur = s.Peek();
                if (cur.right == null || set.Contains(cur))
                {
                    ans.Add(cur.val);
                    set.Add(cur);
                    s.Pop();
                    if (s.Count == 0)
                    {
                        return ans;
                    }
                    cur = s.Peek();
                    cur = cur.right;
                }
                else
                {
                    set.Add(cur);
                    cur = cur.right;
                }
            }
            return ans;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            ans = new List<int>() { };

            if (root == null) return ans;
            TreeNode cur = root;
            stack.Push(cur);
            while (cur != null || stack.Count != 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                ans.Add(cur.val);
                cur = cur.right;
            }

            return ans;
        }

        #endregion
        #region Solution 3
        //******************Solution 3 using Last pointer*********************
        public IList<int> PostorderTraversal_V4(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            ans = new List<int>() { };

            if (root == null) return ans;
            TreeNode cur = root;
            TreeNode last = null;

            while (cur != null || stack.Count != 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Peek();
                if (cur.right == null || cur.right == last)
                {
                    ans.Add(cur.val);
                    last = cur;
                    stack.Pop();
                }
                else
                {
                    cur = cur.right;
                }
            }
            return ans;
        }
        #endregion
        #region Solution 4
        //******************Solution 4*********************
        //******************Morris Traversal*********************
        public IList<int> PostorderTraversal_V5(TreeNode root)
        {
            return null;

        }
        #endregion

        #region 12/16/2021
        // -----------------------12/16/2021 review-----------------------------------------------------------------
        //recusive
        public IList<int> PostorderTraversal_R_12162021(TreeNode root)
        {
            ans = new List<int>() { };
            helper_R2(root);
            return ans;
        }
        public void helper_R2(TreeNode node)
        {
            if (node != null)
            {
                helper_R2(node.left);
                helper_R2(node.right);
                ans.Add(node.val);
            }
        }
        public IList<int> PostorderTraversal_R2_iterative(TreeNode root)
        {
            HashSet<TreeNode> seen = new HashSet<TreeNode>() { };
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            ans = new List<int>() { };
            if (root == null) return ans;
            stack.Push(root);
            TreeNode curr = root;
            while (curr != null || stack.Count != 0)
            {
                while (curr != null && !seen.Contains(curr))
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Peek();

                if (curr.right == null || seen.Contains(curr))
                {
                    seen.Add(curr);
                    ans.Add(curr.val);
                    stack.Pop();
                    if (stack.Count == 0) return ans;
                    curr = stack.Peek();
                    curr = curr.right;
                }
                else
                {
                    seen.Add(curr);
                    curr = curr.right;
                }

            }
            return ans;
        }
        public IList<int> PostorderTraversal_R2_iterative2(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            TreeNode lastPointer = null;
            TreeNode curr = root;
            while (curr != null || stack.Count != 0)
            {
                if (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    var node = stack.Peek();
                    if (node.right == null || node.right == lastPointer)
                    {
                        ans.Add(node.val);
                        lastPointer = node;
                        stack.Pop();
                    }
                    else
                    {
                        curr = node.right;
                    }
                }

            }
            return ans;
        }
        #endregion

        #region 03/27/2024
        public IList<int> PostorderTraversal_2024_03_27(TreeNode root)
        {
            IList<int> res = new List<int>();

            TreeNode node = root;
            while (node != null)
            {
                if(node.right == null)
                {
                    res.Add(node.val);
                    node = node.left;
                }
                else
                {
                    var pres = node.right;
                    while(pres.left != null && pres.left != node)
                    {
                        pres = pres.left;
                    }

                    if(pres.left == null)
                    {
                        pres.left = node;
                        node = node.right;
                    }
                    else
                    {
                        res.Add(node.val);

                        node = node.left;
                        pres.left = null;
                    }
                }
            }
          
            return res.Reverse().ToList();
        }
        #endregion





    }
}
