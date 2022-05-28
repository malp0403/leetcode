using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1265
    {
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            Stack<ImmutableListNode> stack = new Stack<ImmutableListNode>() { };
            if (head == null) return;
            ImmutableListNode node = head;
            stack.Push(node);
            while (true)
            {
                node = node.GetNext();
                if (node == null) break;
                stack.Push(node);
            }

            while (stack.Count != 0)
            {
                node = stack.Pop();
                node.PrintValue();
            }



        }

        //12-31-2021------------
        public void PrintLinkedListInReverse_R2(ImmutableListNode head)
        {
            if (head == null)
            {
                return;
            }
            PrintLinkedListInReverse_R2(head.GetNext());
            head.PrintValue();
        }
    }
    class ImmutableListNode
    {
        public void PrintValue() { } // print the value of this node.
        public ImmutableListNode GetNext() { return new ImmutableListNode(); } // return the next node.
    }
}
