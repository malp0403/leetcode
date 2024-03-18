using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0082
    {
        #region LeetCode Approach 1: Sentinel Head + Predecessor  0(1)
        public ListNode DeleteDuplicates_Approach1(ListNode head)
        {
            ListNode result = new ListNode();
            ListNode temp = result;

            while(head != null)
            {
                if(head.next !=null && head.val == head.next.val)
                {
                    while(head.next !=null && head.val == head.next.val)
                    {
                        head = head.next;
                    }
                    //preset
                    temp.next = head.next;
                }
                else
                {
                    temp = temp.next;
                }
                head = head.next;
            }
            return result.next;
        }

            #endregion
            #region answer
            public ListNode DeleteDuplicates_(ListNode head)
        {
            if (head == null) return null;
            //check head is duplicate;
            ListNode temp = new ListNode();
            ListNode answer  = temp;

            while(head != null)
            {
                if(head.next ==null || (head.next != null && head.next.val != head.val))
                {
                    temp.next = new ListNode(head.val);
                    temp = temp.next;
                }
                while(head.next !=null && head.next.val == head.val)
                {
                    head = head.next;
                }

                head = head.next;

            }
            return answer.next;
        }

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
        #endregion

        #region 08/10/2022
        public ListNode DeleteDuplicates_20220810(ListNode head)
        {
            ListNode res = new ListNode();
            ListNode resTemp = res;
            ListNode prev = new ListNode(101);
            while(head != null)
            {
                if(isValid(head,prev))
                {
                    resTemp.next = head;
                    resTemp = resTemp.next;
                }
                prev = head;
                head = head.next;
                
            }
            resTemp.next = null;
            return res.next;
        }
        public bool isValid(ListNode head,ListNode prev)
        {
            if (head == null) return true;
            if(head.next != null)
            {
                return head.val != prev.val && head.val != head.next.val;
            }
            else
            {
                return head.val != prev.val;
            }
        }
        #endregion

        #region 03/13/2024
        public ListNode DeleteDuplicates_2024_04_19(ListNode head)
        {
            if (head == null) return null;
            ListNode answer = new ListNode();
            ListNode temp = answer;
            Dictionary<int, int> records = new Dictionary<int, int>();
            ListNode prev = null;
            while(head != null)
            {
                if (records.ContainsKey(head.val))
                {
                    records[head.val]++;
                }
                else
                {
                    records.Add(head.val, 1);
                }

                if (prev != null && head.val != prev.val)
                {
                    if (records[prev.val] == 1)
                    {
                        temp.next = prev;
                        temp = temp.next;
                    }
                }

                prev = head;
                head = head.next;

            }
            if (records[prev.val] == 1)
            {
                temp.next = prev;
                temp = temp.next;
            }
   
                temp.next = null;


            return answer.next;
        }


        #endregion
    }
}
