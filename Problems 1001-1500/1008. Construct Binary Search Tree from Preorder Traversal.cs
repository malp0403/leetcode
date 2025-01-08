using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1008
    {
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        int preIndx = 0;
        //*************** with Inorder Map***************
        public TreeNode BstFromPreorder(int[] preorder)
        {
            int[] inorder = new int[preorder.Length];
            Array.Copy(preorder, inorder,preorder.Length);
            Array.Sort(inorder);
            for (int i = 0; i < inorder.Length; i++)
            {
                d.Add(inorder[i], i);
            }

            return helper(0, preorder.Length, preorder);
        }
        public TreeNode helper(int l, int r, int[] preorder)
        {
            if (l == r) return null;

            int val = preorder[preIndx];
            preIndx++;

            int index = d[val];
            TreeNode n = new TreeNode(val);
            n.left = helper(l, index,preorder);
            n.right = helper(index + 1, r, preorder);
            return n;
        }
        //************ with lower or upper bound******************
        public TreeNode BstFromPreorder_V2(int[] preorder)
        {
            return helper_V2(Int16.MinValue, Int16.MaxValue,preorder);
        }
        public TreeNode helper_V2(int lower, int higher,int[] preorder)
        {
            if (preIndx == preorder.Length) return null;
            int val = preorder[preIndx];
            if (lower > val || val > higher) return null;

            preIndx++;
            TreeNode root = new TreeNode(val);
            root.left = helper_V2(lower, val, preorder);
            root.right = helper_V2(val, higher, preorder);
            return root;
        }
        //************ Iterative******************
        public TreeNode BstFromPreorder_V3(int[] preorder)
        {
            if (preorder.Length == 0) return null;
            Stack<TreeNode> q = new Stack<TreeNode>() { };
            TreeNode root = new TreeNode(preorder[0]);
            q.Push(root);
            for(int i =1; i < preorder.Length; i++)
            {
                var node = q.Peek();
                var n = new TreeNode(preorder[i]);
                while(q.Count !=0 && q.Peek().val < n.val)
                {
                    q.Pop();
                }
                if (node.val < n.val) node.right = n;
                else node.left = n;
                q.Push(n);
            }
            return root;
        }
    }
}
