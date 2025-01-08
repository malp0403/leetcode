using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0082
    {
        #region answer
        public ListNode DeleteDuplicates(ListNode head)
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

        #region 03/09/2024
        public ListNode DeleteDuplicates_2024_03_09(ListNode head)
        {
            ListNode answer = new ListNode();
            ListNode prev = null;

            bool firstEncouter = false;
            bool AgainEncouter = false;
            

            while(head != null)
            {
                if(prev == null)
                {
                    firstEncouter = true;
                }
                else
                {
                    if (head.val != prev.val)
                    {
                        if(firstEncouter)
                        {
                            if (!AgainEncouter)
                            {
                                answer.next = head;
                                
                            }
       
                            firstEncouter = true;
                            AgainEncouter = false;
                        }
                    }
                    else
                    {
                        AgainEncouter = true;
                    }
                }

                prev = head;
                head = head.next;
            }

            if (!AgainEncouter)
            {
                answer.next = prev;
                answer.next.next = null;
            }
            else
            {
                answer.next = null;
            }
            return answer.next;
        }
        #endregion
    }
}
