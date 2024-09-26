using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0206
    {
        #region Soltuion
        public ListNode ReverseList_(ListNode head)
        {
            Dictionary<ListNode, ListNode> ParentDic = new Dictionary<ListNode, ListNode>() { };

            while (head != null && head.next != null)
            {
                var tempChild = head.next;
                head.next = null;
                if (ParentDic.ContainsKey(head))
                {
                    head.next = ParentDic[head];
                }
                ParentDic.Add(tempChild, head);
                head = tempChild;
            }

            if (head != null && ParentDic.ContainsKey(head))
            {
                head.next = ParentDic[head];
            }
            return head;
        }

        public ListNode ReverseList_v2(ListNode head)
        {
            ListNode pre = null;
            ListNode curr = head;
            while (curr != null)
            {
                var temp = curr.next;
                curr.next = pre;
                pre = curr;
                curr = temp;
            }
            return pre;
        }
        #endregion

        #region Approach 1: Iterative 12/15/2021 iterative
        //**********12/15/2021 iterative***************
        public ListNode ReverseList_R2(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                var temp = head.next;

                cur.next = pre;
                pre = cur;

                cur = temp;
            }
            return pre;

        }
        #endregion

        #region 12/15/2021 recursive
        //**********12/15/2021 recursive***************
        public ListNode ReverseList_R2_recursive(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = ReverseList_R2_recursive(head.next);
            head.next.next = head;
            head.next = null;
            return p;

        }

        #endregion

        #region 08/14/2023
        public ListNode ReverseList_20230814_iter(ListNode head)
        {
            //find end
            if (head == null) return null;
            ListNode cur = head;
            ListNode prev = null;

            while (cur != null)
            {
                ListNode future = cur.next;

                cur.next = prev;

                prev = cur;
                cur = future;


            }

            return prev;


        }
        #endregion

        #region 08/14/2023 recursive  !!!!!head.next.next = head;
        public ListNode ReverseList_2023_8_14(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode newStart = ReverseList_2023_8_14(head.next);
            head.next.next = head;
            head.next = null;

            return newStart;

        }
        #endregion

        #region 06/11/2024
        public ListNode ReverseList_2024_06_11(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode temp = ReverseList_2024_06_11(head.next);
            head.next.next = head;
            head.next = null;


            return temp;
        }
        #endregion

        #region 09/22/2024 recursive head.next.next = head;
        public ListNode ReverseList_2024_09_22_re(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode node = ReverseList_2024_09_22_re(head.next);
            head.next.next = head;
            head.next = null;

            return node;
        }

        #endregion

        #region 09/22/2024 recursive head.next.next = head;
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode next = head;
            ListNode prev = null;
            while (head != null)
            {

                next = head.next;

                head.next = prev;

                prev = head;
                head = next;
            }

            return prev;

 
        }

        #endregion
    }
}
