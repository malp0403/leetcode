using leetcode.Class;
using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

#region Test
//var obj = new _0061() { };
//ListNode n1 = new ListNode(1);
//ListNode n2 = new ListNode(2);
//ListNode n3 = new ListNode(3);
//ListNode n4 = new ListNode(4);
//ListNode n5 = new ListNode(5);
//n1.next = n2;

//var res1 = obj.rotota_solution2(n1, 1);
#endregion
namespace leetcode.Problems
{
    class _0061
    {

        #region Solution
        public ListNode RotateRight(ListNode head, int k)
        {
            ListNode end = head;
            int total = 1;
            while (end != null && end.next != null)
            {
                total++;
                end = end.next;
            }
            k = k % total;
            if (k == 0) return head;

            int count = 1;
            ListNode temp = head;
            while (count != total - k)
            {
                count++;
                temp = temp.next;
            }
            ListNode newHead = temp.next;
            end.next = head;
            temp.next = null;
            return newHead;

        }
        #endregion

        #region 02/29/2024
        public ListNode RotateRight_2024_02_29(ListNode head, int k)
        {
            int total = 0;
            ListNode temp = head;
            ListNode prevHead = head;
            ListNode prevEnd = null;
            while(temp != null)
            {
                total++;
                temp = temp.next;
                if(temp.next == null)
                {
                    prevEnd = temp;
                }
            }

            if(total == 0 || k % total ==0) return head;
            int remaing =total -  k % total;

            ListNode newHead = head;
            while(remaing != 0)
            {
                newHead = newHead.next;
                remaing--;
            }

            ListNode temp2 = newHead;
            int total_temp = total;

            while(total_temp >= 2)
            {
               
                temp2.next = temp2.next != null ? temp2.next : head;
                temp2 = temp2.next;
                total_temp--;
            }

            temp2.next = null;

            return newHead;


        }

        public ListNode rotota_solution2(ListNode head, int k)
        {
            int total = 0;
            ListNode temp = head;
            ListNode prevHead = head;
            ListNode prevEnd = null;
            while (temp != null)
            {
                total++;
                temp = temp.next;
                if (temp != null && temp.next == null)
                {
                    prevEnd = temp;
                }
            }

            if (total == 0 || k % total == 0) return head;
            int remaing = total - k % total;

            ListNode newHead = head;
            ListNode newHeadParent = head;
            while (remaing != 0)
            {
                newHead = newHead.next;
                remaing--;
                if(remaing == 1)
                {
                    newHeadParent = newHead;
                }
            }

            prevEnd.next = prevHead;
            newHeadParent.next = null;

            return newHead;
        }
        #endregion

    }
}
