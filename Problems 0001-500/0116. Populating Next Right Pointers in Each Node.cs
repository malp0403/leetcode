using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0116
    {
        #region BFS
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
        #endregion
        #region O(1)
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
        #endregion
        #region 08/16/2022
        public Node Connect_20220816(Node root)
        {
            if (root == null) return null;
            Queue<Node> que = new Queue<Node>() { };
            que.Enqueue(root);
            while(que.Count != 0)
            {
                int count = que.Count;
                while(count != 0)
                {
                    Node temp = que.Dequeue();
                    temp.next = que.Peek();
                    if(temp.left != null)
                    {
                        que.Enqueue(temp.left);
                    }
                    if(temp.right != null)
                    {
                        que.Enqueue(temp.right);
                    }
                    count--;
                }
            }
            return root;
        }

        public Node Connect_20220816v2(Node root)
        {
            if (root == null) return null;
            Node node = root;
            while(node != null)
            {
                Node nextStart = node.left;
                while(node != null && nextStart !=null)
                {
                    node.left.next = node.right;
                    if (node.next != null)
                    {
                        node.right.next = node.next.left;
                    }
                    node = node.next;
                }
                node = nextStart;
            }
            return root;
        }
        #endregion

        #region 03/24/2024
        public MyNode Connect_2024_03_24(MyNode root)
        {
            if (root == null) return null;
            MyNode ans = root;
            
            Queue<MyNode> q = new Queue<MyNode> ();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int c = q.Count;
                while(c > 0)
                {
                    MyNode node = q.Dequeue();

                    node.next = c != 1 ? q.Peek() : null;
                    if(node.left != null)
                    {
                        q.Enqueue(node.left);

                    }
                    if(node.right != null)
                    {
                        q.Enqueue(node.right);

                    }
                    c--;
                }
            }

            return ans;


        }
        #endregion
    }
    public class MyNode
    {
        public int val;
        public MyNode left;
        public MyNode right;
        public MyNode next;
        private int v;

        public MyNode() { }

        public MyNode(int _val)
        {
            val = _val;
        }

        public MyNode(int _val, int v) : this(_val)
        {
            this.v = v;
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
