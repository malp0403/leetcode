using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace leetcode.Problems_2001_2500
{
    internal class _2096
    {
        #region My Solution
        Dictionary<TreeNode, TreeNode> parents = new Dictionary<TreeNode, TreeNode>();
        int min = int.MaxValue;
        string answer = string.Empty;
        int startValue;
        int destValue;
        public string GetDrections(TreeNode root, int startValue, int destValue)
        {
            this.startValue = startValue;
            this.destValue = destValue;
            TreeNode n = root;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(n);
            TreeNode startNode = new TreeNode(startValue);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                while (count > 0)
                {
                    TreeNode temp = queue.Dequeue();
                    if(temp.val == startValue)
                    {
                        startNode = temp;
                    }
                    if (temp.right != null)
                    {
                        parents.Add(temp.right, temp);
                        queue.Enqueue(temp.right);
                    }
                    if (temp.left != null)
                    {
                        parents.Add(temp.left, temp);
                        queue.Enqueue(temp.left);
                    }
                    count--;
                }
            }

            helper(startNode, 0, new StringBuilder() { }, new HashSet<TreeNode>() { });

            return answer;


        }
        public void helper(TreeNode n, int sum, StringBuilder sb, HashSet<TreeNode> set)
        {
            if (n.val == destValue)
            {
                if (sum < min)
                {
                    answer = sb.ToString();
                }
                return;
            }
            if (set.Contains(n)) return;

            set.Add(n);

            //to up
            if (parents.ContainsKey(n))
            {
                sb.Append('U');
                helper(parents[n], sum + n.val, sb, set);
                sb.Remove(sb.Length - 1, 1);
            }
            //to right
            if (n.right != null)
            {
                sb.Append('R');
                helper(n.right, sum + n.val, sb, set);
                sb.Remove(sb.Length - 1, 1);
            }
            //to left;
            if (n.left != null)
            {
                sb.Append('L');
                helper(n.left, sum + n.val, sb, set);
                sb.Remove(sb.Length - 1, 1);
            }

            set.Remove(n);
        }
        #endregion

    }
}
