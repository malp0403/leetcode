using System;
using System.Collections.Generic;
using System.Text;
using leetcode.BinarySearch;
using leetcode.Class;

#region Test Data
//ListNode n1 = new ListNode(1);
//ListNode n2 = new ListNode(1);
//ListNode n3 = new ListNode(0);
//ListNode n4 = new ListNode(0);
//ListNode n5 = new ListNode(1);
//n1.next = n2;
//    n2.next = n3;
//    n3.next = n4;
//    n4.next = n5;
#endregion

namespace leetcode.Problems
{
    class _0234
    {
        #region Solution
        public bool IsPalindrome_tst(ListNode head)
        {
            List<int> li = new List<int>() { };
            while (head != null)
            {
                li.Add(head.val);
                head = head.next;
            }
            int l = 0;
            int r = li.Count - 1;
            while (l < r)
            {
                if (li[l] != li[r])
                {
                    return false;
                }
                l--;
                r++;
            }
            return true;
        }

        //***************O(1) space *************
        public bool IsPalindrome_V2(ListNode head)
        {
            if (head == null) return true;

            ListNode firsthalf = findFirstHalf(head);
            ListNode secondHalf = reverseNode(firsthalf.next);

            bool result = true;
            var p1 = head;
            var p2 = secondHalf;
            while (result && p2 != null)
            {
                if (p1.val != p2.val) result = false;
                p1 = p1.next;
                p2 = p2.next;
            }
            firsthalf.next = reverseNode(secondHalf);
            return result;
        }

        public ListNode findFirstHalf(ListNode node)
        {
            ListNode slow = node;
            ListNode fast = node;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public ListNode reverseNode(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;

            }
            return prev;
        }
        #endregion

        #region 09/04/2023
        public bool IsPalindrome_20230904(ListNode head)
        {
            if (head == null) return true;
            ListNode firsthalf = endofFirstHalf_20230904(head);
            ListNode secondhalf = reverse_20230904(firsthalf.next);

            ListNode p1 = head;
            ListNode p2 = secondhalf;
            bool result = true;
            while(result && p2 != null)
            {
                if (p1.val != p2.val) return false;
                p1 = p1.next;
                p2 = p2.next;
            }
            return result;


        }

        public ListNode reverse_20230904(ListNode node)
        {
            ListNode pre = null;
            ListNode cur = node;
            while(cur != null)
            {
                ListNode future = cur.next;
                cur.next = pre;

                pre = cur;
                cur = future;
            }
            return pre;
        }

        public ListNode endofFirstHalf_20230904(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while(fast.next !=null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }

        #endregion

        #region 07/07/2024
        public bool IsPalindrome_2024_07_07(ListNode head)
        {
            if (head == null) return false;
            ListNode firsthalf = firsthalf_2024_07_07(head);
            ListNode secondhalf = reverse_2024_07_07(firsthalf.next);

            ListNode p1 = head;
            ListNode p2 = secondhalf;
            while(p2 != null)
            {
                if (p1.val != p2.val) return false;
                p1 = p1.next;
                p2 = p2.next;
            }
            return true;
        }

        public ListNode firsthalf_2024_07_07(ListNode node)
        {
            ListNode fast = node;
            ListNode slow = node;
            while(fast.next !=null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }

        public ListNode reverse_2024_07_07(ListNode node)
        {
            ListNode pre = null;
            ListNode cur = node;
            while(cur != null)
            {
                ListNode future = cur.next;
                cur.next = pre;

                pre = cur;
                cur = future;
            }

            return pre;
        }

        #endregion

    }
}
