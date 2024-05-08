using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using leetcode.Class;

namespace leetcode.Problems
{
    class _0148
    {
        #region LeetCode Approach 1: Top Down Merge Sort
        public ListNode SortList_app1(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode mid = getMid_app1(head);
            ListNode left = SortList_app1(head);
            ListNode right = SortList_app1(mid);
            return Merge_App1(left, right);
        }
        public ListNode Merge_App1(ListNode node1, ListNode node2)
        {
            ListNode res = new ListNode();
            ListNode dummy = res;
            while (node1 != null && node2 != null)
            {
                if (node1.val < node2.val)
                {
                    dummy.next = node1;
                    node1 = node1.next;
                    dummy = dummy.next;
                }
                else
                {
                    dummy.next = node2;
                    node2 = node2.next;
                    dummy = dummy.next;
                }
            }

            dummy.next = node1 != null ? node1 : node2;
            return res.next;

        }

        public ListNode getMid_app1(ListNode node)
        {
            ListNode midPrev = null;
            while (node != null && node.next != null)
            {
                midPrev = (midPrev == null) ? node : midPrev.next;
                node = node.next.next;
            }
            ListNode mid = midPrev.next;
            midPrev.next = null;
            return mid;
        }
        #endregion

        #region Solution
        public ListNode SortList_(ListNode head)
        {
            SortedDictionary<int, List<ListNode>> dic = new SortedDictionary<int, List<ListNode>>() { };
            int min = Int32.MaxValue;
            while (head != null)
            {
                min = Math.Min(min, head.val);
                if (dic.ContainsKey(head.val))
                {
                    dic[head.val].Add(head);
                }
                else
                {
                    dic.Add(head.val, new List<ListNode>() { head });
                }
                head = head.next;
            }
            var n = new ListNode();
            var answer = n;
            foreach (var item in dic.Keys)
            {
                var li = dic[item];
                foreach (var ele in li)
                {
                    n.next = ele;
                    n = n.next;
                }
            }
            n.next = null;
            return answer.next;

        }

        #endregion

        #region 03/27/2024
        public ListNode SortList_2024_03_27(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode mid = getMid_2024_03_27(head);
            ListNode left = SortList_2024_03_27(head);
            ListNode right = SortList_2024_03_27(mid);
            return Merge_2024_03_27(left, right);
        }
        public ListNode Merge_2024_03_27(ListNode node1, ListNode node2)
        {
            ListNode res = new ListNode();
            ListNode dummy = res;
            while(node1 != null && node2 != null)
            {
                if(node1.val < node2.val)
                {
                    dummy.next = node1;
                    node1 = node1.next;
                    dummy = dummy.next;
                }
                else
                {
                    dummy.next = node2;
                    node2 = node2.next;
                    dummy = dummy.next;
                }
            }

            dummy.next = node1 != null ? node1 : node2;
            return res.next;

        }

        public ListNode getMid_2024_03_27(ListNode node)
        {
            ListNode midPrev = null;
            while(node != null && node.next != null)
            {
                midPrev = (midPrev == null) ? node : midPrev.next;
                node = node.next.next;
            }
            ListNode mid = midPrev.next;
            midPrev.next = null;
            return mid;
        }

        #endregion
    }
}
