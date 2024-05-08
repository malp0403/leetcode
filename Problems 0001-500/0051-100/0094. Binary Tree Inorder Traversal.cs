using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0094
    {

        #region answer
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
        #endregion
        #region solution 1
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            travel(root,ans);
            return ans;
        }
        public void travel(TreeNode n, IList<int> list)
        {
            if (n != null)
            {
                travel(n.left, list);
                list.Add(n.val);
                travel(n.right, list);
            }
        }
        #endregion
        #region solution 2
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
        #endregion
        #region solution 3
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
        #endregion

        #region 08/12/2022
        public IList<int> InorderTraversal_20220812(TreeNode root)
        {
            IList<int> answer = new List<int>() { };
            helper_20220812(root, answer);
            return answer;
        }
        public void helper_20220812(TreeNode node, IList<int> answer)
        {
            if (node == null) return;
            if (node.left == null && node.right == null)
            {
                answer.Add(node.val);
                return;
            }
            helper_20220812(node.left, answer);
            answer.Add(node.val);
            helper_20220812(node.right, answer);
        }
        #endregion

        #region 03/18/2024
        List<int> answer_2024_03_18;
        public IList<int> InorderTraversal_2024_03_18(TreeNode root)
        {
            answer_2024_03_18 = new List<int>();
            helper_2024_03_18(root);

            return answer_2024_03_18;
        }

        public void helper_2024_03_18(TreeNode head)
        {
            if (head == null) return;
       
            helper_2024_03_18(head.left);
            answer_2024_03_18.Add(head.val);
            helper_2024_03_18(head.right);

        }
        #endregion
    }
}
