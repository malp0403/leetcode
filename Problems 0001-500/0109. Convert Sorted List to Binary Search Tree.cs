using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;

#region testing

//var obj = new _0109() { };
//ListNode l0 = new ListNode(0);
//ListNode l1 = new ListNode(1);
//ListNode l2 = new ListNode(2);
//ListNode l3 = new ListNode(3);
//ListNode l4 = new ListNode(4);
//ListNode l5 = new ListNode(5);
//l0.next = l1;
//    l1.next = l2;
//    l2.next = l3;
//    l3.next = l4;
//    l4.next = l5;
//    var test123 = obj.SortedListToBST_20220816(l0);
#endregion

namespace leetcode.Problems
{
    class _0109
    {
        #region answer
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
        #endregion
        #region 01/17/2022
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
        #endregion
        #region 08/16/2022
        public TreeNode SortedListToBST_20220816(ListNode head)
        {
            return helper(head, null);
        }
        public TreeNode helper(ListNode start, ListNode end)
        {

            if (start == null) return null;
            if (start == end) return null;
            if(start.next == end) return new TreeNode(start.val);

            ListNode first = start;
            ListNode second = start;
            while (second != end && second.next != end)
            {
                first = first.next;
                second = second.next.next;
            }
            TreeNode head = new TreeNode(first.val);
            head.left = helper(start, first);
            head.right = helper(first.next, end);
            return head;

        }
        #endregion

        #region 03/20/2024
        List<int> list_2024_03_20;
        public TreeNode SortedListToBST_2024_03_20(ListNode head)
        {
            list_2024_03_20 = new List<int>();
            while(head != null)
            {
                list_2024_03_20.Add(head.val);
                head = head.next;
            }

            return helper_2024_03_20(0, list_2024_03_20.Count - 1);
        }
        public TreeNode helper_2024_03_20(int left, int right)
        {
            if(left>right) return null;
            int mid = left + (right - left)/2;

            TreeNode head = new TreeNode(list_2024_03_20[mid]);
            head.left = helper_2024_03_20(left, mid - 1);
            head.right = helper_2024_03_20(mid+1, right);

            return head;

        }
        #endregion
    }
}
