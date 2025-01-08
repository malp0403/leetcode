using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace leetcode.Problems
{
    class _0083
    {

        #region MyRegion
        public ListNode DeleteDuplicates(ListNode head)
        {

            ListNode result = head;
            while(result != null && result.next != null)
            {
                if(result.next.val == result.val)
                {
                    result.next = result.next.next;
                }
                else
                {
                    result = result.next;
                }
            }

            return head;
        }
            #endregion
            #region answer
            public ListNode DeleteDuplicates_(ListNode head)
        {
            HashSet<int> seen = new HashSet<int>() { };
            ListNode temp = new ListNode();
            ListNode answer = temp;
            while(head != null)
            {
                if (!seen.Contains(head.val))
                {
                    temp = new ListNode(head.val);
                    temp = temp.next;
                    seen.Add(head.val);
                }
                head = head.next;
            }
            return answer;
        }
        public ListNode DeleteDuplicates_v2(ListNode head)
        {
            ListNode curr = head;
            while(curr != null && curr.next != null)
            {
                if(curr.next.val == curr.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }
            return head;
        }
        #endregion

        #region 12/27/2021
        //-------------12-27-2021---------------
        public ListNode DeleteDuplicates_R3(ListNode head)
        {
            ListNode pre = null;
            ListNode ans = new ListNode();
            ListNode temp = ans;
            while(head != null)
            {
                if(pre ==null || head.val != pre.val)
                {
                    temp.next = head;
                    temp = temp.next;
                    pre = head;
                }
                else
                {
                    temp.next = null;
                }
                head = head.next;
            }
            return ans.next;
        }
        public ListNode DeleteDuplicates_R3_v2(ListNode head)
        {

            ListNode ans = head;
            while (head != null && head.next !=null)
            {
                if(head.val != head.next.val)
                {
                    head = head.next;
                }
                else
                {
                    head.next = head.next.next;
                }
            }
            return ans;
        }
        #endregion

        #region 08/10/2022
        public ListNode DeleteDuplicates_20220810(ListNode head)
        {
            ListNode res = new ListNode(101);
            ListNode temp = res;
            while(head != null)
            {
                if(head.val != temp.val)
                {
                    res.next = head;
                    res = res.next;
                }
                head = head.next;
            }
            temp.next = null;

            return res.next;
        }
        #endregion

        #region 03/13/2024
        public ListNode DeleteDuplicates_2024_03_13(ListNode head)
        {
            if (head == null) return null;
            ListNode result = new ListNode();
            ListNode temp = result;
            ListNode prev = null;

            while(head != null)
            {
                if(prev == null || head.val != prev.val)
                {
                    temp.next = head;
                    temp = temp.next;
                }


                prev = head;
                head = head.next;
            }
            if(temp.val != prev.val)
            {
                temp.next = prev;
                temp = temp.next;
            }
            temp.next = null;

            return result.next;
        }

        #endregion
        //public class ListNode
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int val = 0, ListNode next = null)
        //    {
        //        this.val = val;
        //        this.next = next;
        //    }
        //}
    }
}
