using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0094
    {


        public IList<int> PostorderTraversal_11(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };

            TreeNode cur = root;
            TreeNode last = null;
            while(stack.Count != 0)
            {
               if(cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                else
                {
                    cur = stack.Peek();
                    if(cur.right == null || cur.right == last)
                    {
                        ans.Add(cur.val);                        
                        last = cur;
                        stack.Pop();
                        if (stack.Count == 0) return ans;
                        cur = stack.Peek();
                        cur = cur.right;

                    }
                    else
                    {
                        stack.Push(cur.right);
                        cur = cur.right;
                    }
                }
            }
            
            return ans;

        }

         
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            travel(root,ans);
            return ans;
        }
        public void travel(TreeNode n,IList<int> list)
        {
            if (n != null)
            {
                travel(n.left,list);
                list.Add(n.val);
                travel(n.right,list);
            }
        }
        //*************Solution 2 Stack***************
        public IList<int> InorderTraversal_v2(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            TreeNode cur = root;
            while(cur !=null || stack.Count != 0)
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

        //*************Solution 3 Morris Traversal***************
        public IList<int> InorderTraversal_v3(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
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
                        pre.right = cur;
                        cur = cur.left;
                    }
                    else
                    {
                        ans.Add(cur.val);
                        pre.right = null;
                        cur = cur.right;
                    }
                }
            }
            return ans;
          
        }
    }
}
