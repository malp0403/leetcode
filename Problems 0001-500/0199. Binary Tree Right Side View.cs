using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0199
    {
        #region solution
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            ans.Add(root.val);
            while (q.Count != 0)
            {
                int size = q.Count;
                TreeNode target = null;
                while (size > 0)
                {
                    TreeNode node = q.Dequeue();
                    if (node.right != null)
                    {
                        if (target == null) target = node.right;
                        q.Enqueue(node.right);
                    }
                    if (node.left != null)
                    {
                        if (target == null) target = node.left;
                        q.Enqueue(node.left);
                    }
                    size--;
                }
                if (target != null)
                {
                    ans.Add(target.val);
                }

            }
            return ans;
        }
        #endregion

        #region 06/11/2024
        public IList<int> RightSideView_2024_06_11(TreeNode root)
        {
            List<int> list = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root == null) return list;

            q.Enqueue(root);
            int level = 1;
            while (q.Count != 0)
            {
                int count = q.Count;
                while (count > 0)
                {
                    TreeNode temp = q.Dequeue();
                    if (list.Count < level)
                    {
                        list.Add(temp.val);
                    }
                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }

                    count--;
                }
                level++;

            }
            return list;
        }
        #endregion

        #region 09/23/2024
        public IList<int> RightSideView_2024_09_23(TreeNode root)
        {
            List<int> res = new List<int>();

            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root == null) return new List<int>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int count = q.Count;
                List<int> newList = new List<int>();
                int start = 1;
                while (count > 0)
                {
                    TreeNode n = q.Dequeue();
                    if (start == 1)
                    {
                        res.Add(n.val);
                    }
                    if (n.right != null)
                    {
                        q.Enqueue((TreeNode)n.right);
                    }
                    if (n.left != null)
                    {
                        q.Enqueue((TreeNode)n.left);
                    }


                    start++;
                    count--;
                }
            }

            return res;

        }
        #endregion

        #region 10/06/2024 level
        public IList<int> RightSideView_2024_10_06(TreeNode root)
        {
            IList<int> ans = new List<int>() { };

            if (root == null) return ans;

            Queue<(TreeNode node, int level)> q = new Queue<(TreeNode node, int level)>();
            q.Enqueue((root, 1));
            while (q.Count > 0)
            {
                var ele = q.Dequeue();
                if (ans.Count < ele.level)
                {
                    ans.Add(ele.node.val);
                }

                if (ele.node.right != null)
                {
                    q.Enqueue((ele.node.right, ele.level + 1));
                }
                if (ele.node.left != null)
                {
                    q.Enqueue((ele.node.left, ele.level + 1));
                }
            }

            return ans;

        }
        #endregion

        #region 10/07/2024
        public IList<int> RightSideView_2024_10_07(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;

            Queue<(int degree, TreeNode node)> q = new Queue<(int degree, TreeNode node)>();
            q.Enqueue((1, root));
            while (q.Count > 0)
            {
                var ele = q.Dequeue();
                if(ele.degree > ans.Count)
                {
                    ans.Add(ele.node.val);
                }

                if(ele.node.right != null)
                {
                    q.Enqueue((ele.degree+1,ele.node.right));
                }
                if (ele.node.left != null)
                {
                    q.Enqueue((ele.degree+1, ele.node.left));
                }
            }
            return ans;
        }
        #endregion















    }
}
