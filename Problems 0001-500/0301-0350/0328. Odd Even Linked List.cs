using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0328
    {
        #region Solution
        public ListNode OddEvenList_(ListNode head)
        {
            if (head == null) return null;
            ListNode nodeOdd = head;

            ListNode nodeEven = head.next;
            if (nodeEven == null) return head;
            ListNode nextNode = nodeEven;
            while (nodeEven.next != null)
            {
                nodeOdd.next = nodeEven.next;
                nodeOdd = nodeOdd.next;

                if (nodeOdd.next != null)
                {
                    nodeEven.next = nodeOdd.next;
                    nodeEven = nodeEven.next;
                }
                else
                {
                    nodeEven.next = null;
                }

            }
            nodeOdd.next = nextNode;

            return head;
        }

        public ListNode OddEvenList_v2(ListNode head)
        {
            if (head == null) return null;
            ListNode nodeOdd = head;
            ListNode nodeEven = head.next;
            ListNode nextNode = nodeEven;
            while (nodeEven != null && nodeEven.next != null)
            {
                nodeOdd.next = nodeEven.next;
                nodeOdd = nodeOdd.next;

                nodeEven.next = nodeOdd.next;
                nodeEven = nodeEven.next;

            }
            nodeOdd.next = nextNode;

            return head;
        }
        #endregion

        #region 01/12/2022
        //01-12-2022---------------------------------
        public ListNode OddEvenList_R2(ListNode head)
        {
            if (head == null) return head;
            ListNode first = head;
            ListNode second = head.next;
            ListNode second2 = second;
            while (second != null && second.next != null)
            {
                first.next = second.next;
                first = first.next;
                second.next = first.next;
                second = second.next;
            }
            first.next = second2;
            return head;
        }
        #endregion

        #region 09/05/2023
        public ListNode OddEvenList_20230905(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null) return head;
            ListNode p1 = head;
            ListNode p2 = head.next;
            ListNode evenStart = p2;

            while (p2 != null && p2.next != null)
            {
                ListNode temp = p2.next;

                p1.next = temp;
                p1 = p1.next;
                p2.next = temp.next;
                p2 = p2.next;

            }
            p1.next = evenStart;
            return head;
        }

        #endregion

        #region 07/25/2024
        public ListNode OddEvenList_2024_07_25(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode p1 = head;
            ListNode p2 = head.next;
            ListNode evenStart = p2;

            while(p2 != null && p2.next !=null)
            {
                ListNode temp = p2.next;

                p1.next = temp;
                p1 = p1.next;

                p2.next = temp.next;
                p2 = p2.next;

            }
            p1.next = evenStart;

            return head;
            
        }

        #endregion

    }
}
