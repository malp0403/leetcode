using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0107
    {
        #region Solution
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> answer = new List<IList<int>>() { };
            if (root == null) return answer;
            Queue<TreeNode> que = new Queue<TreeNode>() { };
            que.Enqueue(root);
            while (que.Count != 0)
            {
                int count = que.Count;
                IList<int> list = new List<int>() { };
                while (count != 0)
                {
                    TreeNode temp = que.Dequeue();
                    list.Add(temp.val);
                    if (temp.left != null)
                    {
                        que.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        que.Enqueue(temp.right);
                    }
                    count--;
                }
                answer.Add(list);
            }

            return answer.Reverse().ToList();
        }
        #endregion

        #region 03/20/2024
        public IList<IList<int>> LevelOrderBottom_2024_03_20(TreeNode root)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            if (root == null) return answer;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            while(q.Count != 0)
            {
                int count = q.Count;
                IList<int> list = new List<int>() { };  
                while(count != 0)
                {
                    TreeNode node = q.Dequeue();
                    list.Add(node.val);
                    if(node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }


                    count--;
                }
                answer.Add(list);
            }
            return answer.Reverse().ToList();
        }
        #endregion

    }
}
