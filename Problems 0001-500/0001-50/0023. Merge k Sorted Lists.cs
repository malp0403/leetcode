using leetcode.Class;
using System;
using System.Collections.Generic;
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
            for(int i =0; i < lists.Length; i++)
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

        #region 07/23/2023 Merge with Divide and conquer attempt

        public ListNode MergeKLists_20230723_DivideConquer(ListNode[] lists)
        {
            int amount = lists.Length;
            int intervel = 1;
            while (intervel < amount)
            {
                for (int i = 0; i < amount - intervel;)
                {
                    lists[i] = helper_20230723(lists[i], lists[i + intervel]);
                    i += intervel * 2;
                }

                intervel *= 2;
            }
            return amount >0?lists[0]:null;
        }
        #endregion
    }
}
