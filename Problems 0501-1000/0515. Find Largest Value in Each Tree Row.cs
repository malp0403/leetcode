using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0515
    {
        public IList<int> LargestValues(TreeNode root)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>() { };
            travel(root, 0, dic);
            IList<int> li = new List<int>() { };
            foreach (var key in dic.Keys)
            {
                li.Add(dic[key]);
            }
            return li;
        }

        public void travel(TreeNode n,int level, SortedDictionary<int,int> d)
        {
            if(n != null)
            {
                if (d.ContainsKey(level)){
                    d[level] = Math.Max(n.val, d[level]);
                }
                else
                {
                    d[level] = n.val;
                }
                travel(n.right, level + 1, d);
                travel(n.left, level + 1, d);
            }
        }

        //01-08-2022---------------------------
        public IList<int> LargestValues_R2(TreeNode root)
        {
           
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int size = q.Count;
                int max = Int32.MinValue;
                while (size > 0)
                {
                    TreeNode n = q.Dequeue();
                    max = Math.Max(n.val, max);
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                    size--;
                }
                ans.Add(max);
            }
            return ans;
        }
        //---------------------
    }
}
