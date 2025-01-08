using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    public class TreeNode
    {

        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class _0938
    {
        public int sum = 0;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if( root.val >= low && root.val <= high)
            {
                sum += root.val;
            }
  
            if(root.left != null)
            {
                RangeSumBST(root.left, low, high);
            }

            if(root.right != null)
            {
                RangeSumBST(root.right, low, high);
            }
            return sum;
        }

        //---12/14/2021
        public int RangeSumBST_v2(TreeNode root, int low, int high) {
            int sum = 0;
            if (root == null) return 0;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            while (q.Count != 0)
            {
                TreeNode node = q.Dequeue();
                if (node.val >= low && node.val <= high) sum += node.val;
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            return sum;
        }
        //---12/14/2021
        public int RangeSumBST_v3(TreeNode root, int low, int high)
        {
            int sum = 0;
            if (root == null) return 0;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            while (q.Count != 0)
            {
                TreeNode node = q.Dequeue();
                if (node.val >= low && node.val <= high) sum += node.val;
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            return sum;
        }
    }
}
