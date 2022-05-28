using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0109
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            List<int> list = new List<int>() { };
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            list.Sort();
            return helper(0, list.Count - 1, list);
        }
        public TreeNode helper(int low, int high, List<int> list)
        {
            if (low > high) return null;
            int p = (low + high) / 2;
            TreeNode root = new TreeNode(list[p]);
            root.left = helper(low, p - 1,list);
            root.right = helper(p + 1, high, list);
            return root;
        }
        //01-17-2022------------------------------------
        public TreeNode SortedListToBST_R2(ListNode head)
        {
            List<int> list = new List<int>() { };
            while(head != null)
            {
                list.Add(head.val);head = head.next;
            }
            return inorder(0, list.Count, list);

        }
        public TreeNode inorder(int low , int high, List<int> list)
        {
            if (low == high) return null;
            int mid = low + (high - low) / 2;
            TreeNode root = new TreeNode(list[mid]);
            root.left = inorder(low, mid,list);
            root.right = inorder(mid+1,high, list);
            return root;
        }
    }
}
