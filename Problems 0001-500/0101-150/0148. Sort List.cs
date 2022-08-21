using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;

namespace leetcode.Problems
{
    class _0148
    {
        public ListNode SortList(ListNode head)
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
    }
}
