using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1161
    {
        int l = 1;
        int sum = int.MinValue;
        Dictionary<int, int> d;
        public int MaxLevelSum(TreeNode root)
        {
            d = new Dictionary<int, int>() { };
            travel(root, 1);
            foreach (var key in d.Keys)
            {
                if (d[key] > sum)
                {
                    l = key;
                }
            }
            return l;
        }
        
        public void travel(TreeNode n,int level)
        {
            if (n != null) {
                if (d.ContainsKey(level)) d[level] = d[level] + n.val;
                else d[level] = n.val;
                travel(n.left, level + 1);
                travel(n.right, level + 1);
            }
   
        }

        // 01-06-2022----------------------------
        public int MaxLevelSum_R2(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            int ans = 1;
            int max = root.val;
            int level = 1;
            while(q.Count != 0)
            {
                int size = q.Count;
                int sum = 0;
                while (size > 0)
                {
                    var n = q.Dequeue();
                    sum += n.val;
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                    size--;
                }
                if(sum > max)
                {
                    max = sum;
                    ans = level; 
                }
                level++;

            }
            return ans;
        }

        //---------------------------------------
    }
}
