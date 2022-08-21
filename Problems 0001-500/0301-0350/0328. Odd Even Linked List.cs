using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0328
    {
        public ListNode OddEvenList(ListNode head)
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

                if(nodeOdd.next != null)
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

        //01-12-2022---------------------------------
        public ListNode OddEvenList_R2(ListNode head)
        {
            if (head == null) return head;
            ListNode first = head;
            ListNode second = head.next;
            ListNode second2 = second;
            while(second !=null &&  second.next != null)
            {
                first.next = second.next;
                first = first.next;
                second.next = first.next;
                second = second.next;
            }
            first.next = second2;
            return head;
        }
    }
}
