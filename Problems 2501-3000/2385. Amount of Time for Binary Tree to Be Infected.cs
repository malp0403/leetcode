using leetcode.Problems;
using leetcode.Problems_2501_3000._2351_2400;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj2 = new _2385();
//TreeNode n1 = new TreeNode(1);
//TreeNode n2 = new TreeNode(2);
//TreeNode n3 = new TreeNode(3);
//TreeNode n4 = new TreeNode(4);
//TreeNode n5 = new TreeNode(5);
//TreeNode n6 = new TreeNode(6);
//TreeNode n9 = new TreeNode(9);
//TreeNode n10 = new TreeNode(10);
//n1.left = n5;
//n1.right = n3;
//n3.left = n10;
//n3.right = n6;
//n5.right = n4;
//n4.left = n9;
//n4.right = n2;
//obj2.AmountOfTime(n1, 3);

//n1.left = n2;
//n2.left = n3;
//n3.left = n4;
//n4.left = n5;
//obj2.AmountOfTime(n1, 1);
#endregion

namespace leetcode.Problems_2501_3000._2351_2400
{
    internal class _2385
    {
        #region 09/26/2023 BFS
        public int AmountOfTime(TreeNode root, int start)
        {
            if (root == null) return 0;
            Dictionary<TreeNode, TreeNode> dic = new Dictionary<TreeNode, TreeNode>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            dic.Add(root, new TreeNode(0));
            TreeNode _start = new TreeNode(-1);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node.val == start) { _start = node; }
                if (node.left != null)
                {
                    dic.Add(node.left, node);
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    dic.Add(node.right, node);
                    queue.Enqueue(node.right);
                }
            }

            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue(_start);
            visited.Add(_start.val);
            int distance = 0;
            while (queue.Count > 0)
            {
                int total = queue.Count;
                while (total > 0)
                {
                    TreeNode temp = queue.Dequeue();
                    visited.Add(temp.val);
                    
                    if (temp.left != null && !visited.Contains(temp.left.val))
                    {
                        queue.Enqueue(temp.left);
                    }
                    if (temp.right != null && !visited.Contains(temp.right.val))
                    {
                        queue.Enqueue(temp.right);
                    }
                    if (dic.ContainsKey(temp) && dic[temp].val != 0&& !visited.Contains(dic[temp].val))
                    {
                        queue.Enqueue(dic[temp]);
                    }


                    total--;
                }
                distance++;
            }
            return distance;

        }
        #endregion
    }
}
