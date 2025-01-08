using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0117
    {
        #region answer
        public Node Connect(Node root)
        {
            if (root == null) return null;
            Queue<Node> quene = new Queue<Node>() { };
            quene.Enqueue(root);
            quene.Enqueue(null);
            while (quene.Count > 0)
            {
                var start = quene.Dequeue();
                while (start != null)
                {
                    if (start.left != null) quene.Enqueue(start.left);
                    if (start.right != null) quene.Enqueue(start.right);
                    var next = quene.Dequeue();
                    start.next = next;
                    start = start.next;
                }
                if (quene.Count > 0)
                {
                    quene.Enqueue(null);
                }
            }
            return root;
        }
        #endregion

        #region 08/16/2022
        public Node Connect_20220816(Node root)
        {
            return null;
            //if (root == null) return null;
            //Node start = root;
            //while (start != null)
            //{
            //    Node temp = helper_20220816(start);
            //    while (temp != null)
            //    {
            //        Node curEnd = null;
            //        if (temp.left != null && temp.right != null)
            //        {
            //            temp.left.next = temp.right;
            //            curEnd = temp.right;
            //        }
            //        else if (temp.left == null)
            //        {
            //            curEnd = temp.right;
            //        }
            //        else
            //        {
            //            curEnd = temp.left;
            //        }
            //        Node next = temp.next;
            //        while (next != null)
            //        {
            //            if (next.left == null && next.right == null)
            //            {
            //                next = next.next;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }

            //        if (next != null && curEnd !=null)
            //        {
            //            if (next.left != null)
            //            {
            //                curEnd.next = next.left;
            //            }
            //            else
            //            {
            //                curEnd.next = next.right;
            //            }
            //        }

            //        temp = next;

            //    }


            //    if(start.left != null)
            //    {
            //        start = start.left;
            //    }
            //    else
            //    {
            //        start = start.right;
            //    }
               
            //}
            //return root;
        }
        public Node helper_20220816(Node node)
        {
            if (node == null) return null;
            while(node != null)
            {
                if(node.left !=null || node.right != null) { break; }
                else { node = node.next; }
            }
            return node;
        }
        #endregion

        #region 08/17/2022
        public Node Connect_20220817(Node root)
        {
            if (root == null) return null;
            Node node = root;
            while(node != null)
            {
                Node nextValidStart = nextStart_20220817(node);

                while(node != null)
                {
                    node = nextValidNode_20220817(node);
                    if (node == null) break;
                    if(node.left != null)
                    {
                        node.left.next = node.right;
                    }
                    Node next = nextValidNode_20220817(node.next);
                    if(next != null)
                    {
                        Node tail = node.right == null ? node.left : node.right;
                        if (next.left != null)
                        {
                            tail.next = next.left;
                        }
                        else
                        {
                            tail.next = next.right;
                        }
                    }
                    node = next;
                }
                node = nextValidStart;
            }
            return root;

        }
        public Node nextStart_20220817(Node node)
        {
            while(node !=null && node.left ==null && node.right == null)
            {
                node = node.next;
            }
            if (node == null) return null;

            return node.left != null ? node.left : node.right;
        }
        public Node nextValidNode_20220817(Node node)
        {
            if (node == null) return null;
            while(node!=null && node.left == null && node.right == null)
            {
                node = node.next;
            }
            return node ;
        }
        #endregion

        #region 03/24/2024
        public MyNode Connect_2024_03_24(MyNode root)
        {
            if (root == null) return null;
            MyNode ans = root;

            Queue<MyNode> q = new Queue<MyNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int c = q.Count;
                while (c > 0)
                {
                    MyNode node = q.Dequeue();

                    node.next = c != 1 ? q.Peek() : null;
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);

                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);

                    }
                    c--;
                }
            }

            return ans;


        }
        #endregion
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
