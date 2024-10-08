using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0023
    {
        #region 07/19/2022
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 1) return lists[0];
            ListNode d = null;
            for (int i = 0; i < lists.Length; i++)
            {
                d = helper(d, lists[i]);
            }
            return d;
        }
        public ListNode helper(ListNode p1, ListNode p2)
        {
            ListNode dummy = new ListNode();
            ListNode res = dummy;
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
        public ListNode MergeKLists_(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            ListNode answer = lists[0];
            for (int i = 1; i < lists.Length; i++)
            {
                answer = helper_20230723(answer, lists[i]);
            }
            return answer;
        }
        public ListNode helper_20230723(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            ListNode t = answer;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    t.next = l2; break;
                }
                else if (l2 == null)
                {
                    t.next = l1; break;
                }
                else if (l1.val < l2.val)
                {
                    t.next = l1;
                    l1 = l1.next;
                    t = t.next;
                }
                else
                {
                    t.next = l2;
                    l2 = l2.next;
                    t = t.next;
                }
            }
            return answer.next;
        }
        #endregion

        #region 07/23/2023 Merge with Divide and conquer attempt; beware of the inteval gap inside loop;i += interval * 2  &  interval *= 2;

        public ListNode MergeKLists_20230723_DivideConquer(ListNode[] lists)
        {
            int amount = lists.Length;
            int interval = 1;
            while (interval < amount)
            {
                for (int i = 0; i < amount - interval;)
                {
                    lists[i] = helper_2024_01_29(lists[i], lists[i + interval]);
                    i += interval * 2;
                }
                interval *= 2;
            }
            return amount > 0 ? lists[0] : null;
        }
        #endregion

        #region 01/29/2024 merge with intervel
        public ListNode MergeKLists_2024_01_29(ListNode[] lists)
        {
            int amount = lists.Length;
            int interval = 1;
            while (interval < amount)
            {
                for (int i = 0; i < amount - interval; i += interval * 2)
                {
                    lists[i] = helper_2024_01_29(lists[i], lists[i + interval]);
                }
                interval *= 2;
            }
            return amount > 0 ? lists[0] : null;
        }

        public ListNode helper_2024_01_29(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            ListNode temp = answer;
            while (l1 != null || l1 != null)
            {
                if (l1 == null)
                {
                    temp.next = l2;
                    l2 = null;
                }
                else if (l2 == null)
                {
                    temp.next = l1;
                    l1 = null;
                }
                else if (l1.val < l2.val)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    l2 = l2.next;
                }
                temp = temp.next;
            }
            return answer.next;
        }

        #endregion

        #region 10/07/2024  Merge with Divide And Conquer
        public ListNode MergeKLists_2024_10_07(ListNode[] lists)
        {
            int amount = lists.Length;
            int intervel = 1;
            while (intervel < amount)
            {
                for (int i = 0; i < amount - intervel; i += intervel * 2)
                {
                    lists[i] = helper_2024_10_06(lists[i], lists[i + intervel]);
                }
                intervel *= 2;
            }
            return amount > 0 ? lists[0] : null;
        }
        public ListNode helper_2024_10_06(ListNode l1, ListNode l2)
        {
            ListNode n1 = new ListNode();
            ListNode n2 = n1;


            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    n2.next = l2; break;
                }
                else if (l2 == null)
                {
                    n2.next = l1; break;
                }
                else if (l1.val < l2.val)
                {
                    n2.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    n2.next = l2;
                    l2 = l2.next;
                }
                n2 = n2.next;
            }

            return n1.next;
        }
        #endregion
    }
}
