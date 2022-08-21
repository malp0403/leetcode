﻿using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0092
    {
        #region answer;
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode answer = head;
            Stack<ListNode> stack = new Stack<ListNode>() { };
            int count = 1;
            ListNode prev = null;
            ListNode next = null;
            while (answer != null && count <= right)
            {
                if(count < left) { prev = answer; }
                else
                {
                    stack.Push(answer);
                }
                if (count == right)
                {
                    next = answer.next;
                }
                answer = answer.next;
                count++;
            }
            if(left == 1)
            {
                head = stack.Peek();
            }
            while(stack.Count != 0)
            {
                var temp = stack.Pop();
                if (prev == null) {
                    prev = temp;
                }
                else
                {
                    prev.next = temp;
                    prev = prev.next;
                }
                

               
            }
            prev.next = next;
            return head;
        }
        #endregion

        #region 08/11/2022
        public ListNode ReverseBetween_20220811(ListNode head, int left, int right)
        {
            if (left == right || head ==null || head.next ==null) return head;

            ListNode result = head;
            int count = 1;
            ListNode beforeRev = null;
            while(count !=left && head != null)
            {
                beforeRev = head;
                head = head.next;
                count++;
            }
            ListNode newEnd = head;
            ListNode prev = null;
            ListNode cur = head;
            while(count != (right+1))
            {
                ListNode temp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = temp;
                count++;
            }

            newEnd.next = cur;
            if (left == 1) return prev;

            if(beforeRev != null)
            {
                beforeRev.next = prev;
            }
          


            return result;
            

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
