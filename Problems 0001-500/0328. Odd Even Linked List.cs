﻿using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;

#region Test
/*
 
            var obj = new _0328();
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            ListNode n5 = new ListNode(5);
            n1.next = n2;n2.next = n3;n3.next=n4;n4.next = n5;
            obj.OddEvenList_2024_09_22(n1);
 */
#endregion
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

        #region 09/16/2024
        public ListNode OddEvenList_2024_09_16(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenStart = even;

            while (even != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = even.next.next;
                even = even.next;
            }
            odd.next = evenStart;

            return head;
        }
        #endregion

        #region 09/22/2024
        public ListNode OddEvenList_2024_09_22(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenStart = even;

            while(even !=null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;

                even.next = even.next.next;
                even = even.next;
            }

            odd.next = evenStart;
            
            return head;

        }
        #endregion

    }
}
