using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0102
    {
        #region Approach 1: Recursion
        IList<IList<int>> answer_1 = new List<IList<int>>();
        public IList<IList<int>> LevelOrder_1(TreeNode root) { 
            if(root == null) return answer_1;
            helper(root, 0);
            return answer_1;
        }
        public void helper(TreeNode node, int level)
        {
            if(level == answer_1.Count)
            {
                answer_1.Add(new List<int>());
            }
            answer_1[level].Add(node.val);

            if(node.left != null)
            {
                helper(node.left, level + 1);
            }
            if (node.right != null)
            {
                helper(node.right, level + 1);
            }
        }
        #endregion

        #region Approach 2: Iteration
        public IList<IList<int>> LevelOrder_2(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            IList<IList<int>> answer = new List<IList<int>>() { };
            if (root == null) return answer;

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int count = queue.Count;
                List<int> list = new List<int>();
                while (count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if (node != null)
                    {
                        list.Add(node.val);
                        if (node.left != null)
                            queue.Enqueue(node.left);
                        if (node.right != null)
                            queue.Enqueue(node.right);
                    }
                    count--;

                }

                answer.Add(list);

            }
            return answer;
        }
        #endregion

        #region answer
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> answer = new List<IList<int>>() { };
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            if (root == null) return answer;
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int size = q.Count;
                IList<int> list = new List<int>() { };
                while(size > 0)
                {
                    TreeNode n = q.Dequeue();
                    list.Add(n.val);
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                    size--;
                }
                answer.Add(list);
            }
            return answer;
        }
        #endregion

        #region 01/12/2022
        //01-12-2022
        public IList<IList<int>> LevelOrder_R2(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>() { };
            if (root == null) return ans;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            while (q.Count != 0)
            {
                IList<int> list = new List<int>() { };
                int size = q.Count;
                while(size > 0)
                {
                    var n = q.Dequeue();
                    list.Add(n.val);
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                    size--;
                }
                ans.Add(list);
            }
            return ans;
        }
        #endregion

        #region 08/12/2022
        public IList<IList<int>> LevelOrder_20220812(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>() { };
            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            if (root == null) return result;

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int count = queue.Count;
                IList<int> list = new List<int>() { };
                while(count > 0)
                {
                    TreeNode cur = queue.Dequeue();
                    list.Add(cur.val);
                    if(cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if(cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                    count--;
                }
                result.Add(list);
            }
            return result;


            
        }
        #endregion

        #region 03/18/2024
        public IList<IList<int>> LevelOrder_2024_03_18(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            IList<IList<int>> answer= new List<IList<int>>() { };
            if (root == null) return answer;

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int count = queue.Count;
                List<int> list = new List<int>();
                while (count>0)
                {
                    TreeNode node = queue.Dequeue();
                    if(node != null)
                    {
                        list.Add(node.val);
                        if(node.left != null)
                        queue.Enqueue(node.left);
                        if(node.right != null)
                        queue.Enqueue(node.right);
                    }
                    count--;

                }
       
                    answer.Add(list);
               
            }
            return answer;
        }
        #endregion
    }
}
