using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0107
    {
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
                while(count != 0)
                {
                    TreeNode temp = que.Dequeue();
                    list.Add(temp.val);
                    if(temp.left != null)
                    {
                        que.Enqueue(temp.left);
                    }
                    if(temp.right != null)
                    {
                        que.Enqueue(temp.right);
                    }
                    count--;
                }
                answer.Add(list);
            }

            return answer.Reverse().ToList();
        }
    }
}
