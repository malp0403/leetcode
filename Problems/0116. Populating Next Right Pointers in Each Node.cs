using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0116
    {
        //***************BFS***********************
        public MyNode Connect(MyNode root)
        {
            if (root == null) return null;
            MyNode ans = root;
            Queue<MyNode> q = new Queue<MyNode>() { };
            root.next = null;
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int size = q.Count;
                MyNode pre = null;
                while (size > 0)
                {
                    MyNode n = q.Dequeue();
                    if(n.left != null && n.right !=null)
                    {
                        if(pre != null)
                        {
                            pre.next = n.left;
                        }
                        n.left.next = n.right;
                        n.right.next = null;
                        pre = n.right;
                        q.Enqueue(n.left);
                        q.Enqueue(n.right);
                    }
                    size--;
                }
            }
            return ans;
        }

        //*******************O(1)*******************
        public MyNode Connect_V2(MyNode root)
        {
            if (root == null) return null;
            MyNode leftmost = root;
            MyNode head;
            while(leftmost.left != null)
            {
                head =leftmost;
                while(head != null)
                {
                    head.left.next = head.right;
                    if(head.next != null)
                    {
                        head.right.next = head.next.left;
                    }
                    head = head.next;
                }
                leftmost = leftmost.left;
                
            }
            return root;
        }
    }
    public class MyNode
    {
        public int val;
        public MyNode left;
        public MyNode right;
        public MyNode next;

        public MyNode() { }

        public MyNode(int _val)
        {
            val = _val;
        }

        public MyNode(int _val, MyNode _left, MyNode _right, MyNode _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
