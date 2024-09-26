using leetcode.Class;
using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Text;

#region Test Data

//ListNode n1 = new ListNode(1);
//ListNode n2 = new ListNode(2);
//ListNode n3 = new ListNode(3);
//ListNode n4 = new ListNode(4);
//ListNode n5 = new ListNode(5);
//n1.next = n2; n2.next = n3; n3.next = n4; n4.next = n5;

//var obj = new _0025();
//obj.ReverseKGroup_20230724(n1, 2);
#endregion
namespace leetcode.Problems
{
    class _0025
    {
        #region Attempt
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode newHead = head;
            int count = k;
            while(newHead != null && count !=0)
            {
                newHead = newHead.next;
                count--;
            }
            if (count != 0) return head;

            ListNode cur = head;
            ListNode prev = null;

            count = k;
            while(count != 0)
            {
                ListNode temp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = temp;
                count--;
            }

            head.next = ReverseKGroup(cur, k);

            return prev;
        }
        #endregion

        #region 07/23/2023
        public ListNode ReverseKGroup_20230723(ListNode head, int k)
        {
            ListNode answer = new ListNode();
            ListNode temp = answer;
            while (true)
            {
                List<ListNode> list = helper_20230723(head, k);
                answer.next = list[0];
                answer = list[1];
                if (list[2] == null) break;
                head = list[2];
                
            }
            return temp.next;
        }
        public List<ListNode> helper_20230723(ListNode node, int k)
        {

            int remain = k;
            ListNode head = node;
            while(head != null && remain != 0)
            {
                remain--;
                head = head.next;
            }
            if (remain > 0) return new List<ListNode>() { node, null, null};

            ListNode prev = null;
            ListNode cur = node;
            ListNode future = null;
            ListNode end = node;
            while(k != 0)
            {
                future = cur.next;
                cur.next = prev;

                prev = cur;
                cur = future;
                k--;
            }

            return new List<ListNode>() { prev, end, head };

        }

        #endregion

        #region 07/24/2023
        public ListNode ReverseKGroup_20230724(ListNode head, int k)
        {
            ListNode answer = new ListNode();

            ListNode prev = null;
            ListNode cur = head;
            ListNode end = head;
            ListNode future = null;
            int count = k;
            int remain = k;
            while (head !=null && remain != 0)
            {
                head = head.next;
                remain--;
            }
            if (remain > 0) return cur;

            while (true)
            {
                k--;
                future = cur.next;
                cur.next = prev;
                prev = cur;
                cur = future;
                if (k == 0) break;
            }

            answer.next = prev;
            end.next = ReverseKGroup_20230724(future, count);


            return answer.next;




        }
        #endregion

        #region 01/29/2024
        public ListNode ReverseKGroup_2024_01_29(ListNode head, int k)
        {
            ListNode answer = new ListNode();

            ListNode nextHead = null;
            ListNode prev = null;
            ListNode cur = head;
            ListNode end = head;

            int remains = k;
            ListNode temp = head;
            while(temp != null && remains != 0)
            {
                temp = temp.next;
                remains--;
            }

            if (remains > 0) return head;


            int count = k;
            while (true)
            {
                count--;
                nextHead = cur.next;
                cur.next = prev;
                prev = cur;
                cur = nextHead;

                if (count == 0) break;
            }

            answer.next = prev;
            end.next = ReverseKGroup(nextHead, k);

            return answer.next;
        }

        #endregion

    }
}
