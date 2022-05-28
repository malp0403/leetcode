using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class TwoSum3
    {
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> hash = new HashSet<int>();

            return find(root, k, hash);
        }

        public Boolean find(TreeNode root, int k, HashSet<int> set)
        {
            if (root == null)
            {
                return false;
            }
            if (set.Contains(k - root.val))
            {
                return true;
            }
            set.Add(root.val);
            
            return find(root.left, k, set) || find(root.right, k, set);
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool FindTarget_R2(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>() { };
            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            if (root == null) return false;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (set.Contains(k - node.val)) return true;
                else
                {
                    set.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return false;

        }

    }

}
