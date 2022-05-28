using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0742
    {
        Dictionary<TreeNode, TreeNode> dictionary = new Dictionary<TreeNode, TreeNode>() { };
        HashSet<TreeNode> visited = new HashSet<TreeNode>() { };
        public int FindClosestLeaf(TreeNode root, int k)
        {
            TreeNode start = null;
            TreeNode answer = null;
            travel(root, start,k);

            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(start);
            int size = 1;
            while(q.Count != 0)
            {
                size = q.Count;

                while (size > 0)
                {
                    var n = q.Dequeue();
                    visited.Add(n);
                    if (n.left == null && n.right == null)
                    {
                        answer = n;
                        break;
                    }
                    if (!visited.Contains(dictionary[n]))
                    {
                        if (dictionary.ContainsKey(n))
                        {
                            q.Enqueue(dictionary[n]);
                        }
                        else if (n.left != null)
                        {
                            q.Enqueue(n.left);
                        }
                        else if (n.right != null)
                        {
                            q.Enqueue(n.right);
                        }
                    }

                    size--;
                }
                if (answer != null) { break; }
            }
            return answer.val;
            
        }
        public int findLeaf(TreeNode node,int k,int level)
        {
            return 0;
        }
        public void travel(TreeNode node,TreeNode start,int k)
        {
            if(node != null)
            {
                if(node.val == k)
                {
                    start = node;
                }
                if(node.left != null)
                {
                    dictionary.Add(node.left, node);
                    travel(node.left,start,k);
                }
                if(node.right != null)
                {
                    dictionary.Add(node.right, node);
                    travel(node.right,start,k);
                }
            }
        }
    }
}
