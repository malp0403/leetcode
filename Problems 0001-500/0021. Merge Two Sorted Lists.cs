﻿using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0021
    {
        #region answer
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode();
            var curr = head;
            while(list1 !=null || list2 != null)
            {
                if(list1 == null)
                {
                    curr.next = list2;
                    list2 = list2.next;
                }else if(list2 == null)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    if (list1.val <= list2.val)
                    {
                        curr.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        curr.next = list2;
                        list2 = list2.next;
                    }
                }
                curr = curr.next;
            }
            return head.next;

        }
        public ListNode MergeTwoLists_R2(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode() { };
            while(list1 != null && list2 != null)
            {
                if(list1.val <= list2.val)
                {
                    head.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    head.next = list2;
                    list2 = list2.next;
                }
            }
            head.next = list1 == null ? list2 : list1;
            return head.next;
        }
        #endregion

        #region 07/18/2022
        public ListNode MergeTwoLists_20220719(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode res = dummy;
            ListNode p1 = list1;
            ListNode p2 = list2;
            while (p1 != null || p2 != null)
            {
                if (p1 == null)
                {
                    dummy.next = p2;
                    p2 = null;
                }
                else if (p2 == null)
                {
                    dummy.next = p1;
                    p1 = null;
                }
                else if (p1.val < p2.val)
                {
                    dummy.next = p1;
                    dummy = dummy.next;
                    p1 = p1.next;

                }
                else
                {
                    dummy.next = p2;
                    dummy = dummy.next;
                    p2 = p2.next;
                }
            }
            return res.next;
        }
        #endregion

        #region 07/23/2023
        public ListNode MergeTwoLists_20230723(ListNode list1, ListNode list2)
        {
            ListNode answer = new ListNode();
            ListNode temp = answer;

            while(list1 !=null || list2 != null)
            {
                if(list1 == null)
                {
                    temp.next = list2;
                    break;
                }else if( list2 == null)
                {
                    temp.next = list1;
                    break;
                }else if(list1.val < list2.val)
                {
                    temp.next = list1;
                    list1 = list1.next;
                    temp = temp.next;
                }
                else
                {
                    temp.next = list2;
                    list2 = list2.next;
                    temp = temp.next;
                }
            }
            return answer.next;
        }
        #endregion

        #region 01/29/2024
        public ListNode MergeTwoLists_2024_01_29(ListNode list1, ListNode list2)
        {
            ListNode answer = new ListNode();
            ListNode list = answer;

            while(list1 != null || list2 != null)
            {
                if(list1 == null)
                {
                    list.next = list2;
                    list2 = null;
                }else if( list2 == null)
                {
                    list.next = list1;
                    list1 = null;
                }else if( list1.val < list2.val)
                {
                    list.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    list.next = list2;
                    list2 = list2.next;
                }
                list = list.next;

            }

            return answer.next;
        }
        #endregion
    }
}
