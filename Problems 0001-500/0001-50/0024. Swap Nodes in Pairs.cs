using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0024
    {
        #region *************Recursive***********************

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode temp = head.next.next;
            ListNode  first = head;
            ListNode second = head.next;
            second.next = first;
            first.next = SwapPairs(temp);
            return second;
        }
        #endregion

        #region ***************Iterative*************************
        public ListNode SwapPairs_V2(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode dummy = new ListNode(-1);
            dummy.next = head;

            ListNode prevNode = dummy;
            while (head != null && head.next != null)
            {
                ListNode first = head;
                ListNode second = head.next;

                prevNode.next = second;
                first.next = second.next;
                second.next = first;

                prevNode = first;
                head = first.next;

            }
            return dummy.next;

        }
        #endregion

        #region 07/19/2022
        public ListNode SwapPairs_20220719(ListNode head)
        {
            ListNode dummy = new ListNode();
            ListNode res = dummy;
            while(head != null && head.next != null)
            {
                ListNode temp = head.next.next;
                dummy.next = head.next;
                dummy = dummy.next;
                dummy.next = head;
                dummy = dummy.next;
                head = temp;
            }
            dummy.next = head;

            return res.next;
        }
        #endregion

        #region 01/29/2024 Rec
        public ListNode SwapPairs_2024_01_29_Rec(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode first = head;
            ListNode second = head.next;

            first.next = SwapPairs_2024_01_29_Rec(second.next);
            second.next = first;
            return second;
        }
        #endregion

        #region 01/29/2024 Iterative
        public ListNode SwapPairs_2024_01_29_Iter(ListNode head)
        {
            ListNode dummy = new ListNode();
            dummy.next = head;

            ListNode prev = dummy;

            while(head != null || head.next != null)
            {
                ListNode first = head;
                ListNode second = head.next;

                //swapping
                prev.next = second;
                first.next = second.next;
                second.next = first;

                prev = first;
                head = first.next;


            }

            return dummy.next;

           
        }
        #endregion
    }
}
