﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0138
    {
        #region Recursive
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>() { };
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            if (!dic.ContainsKey(head))
            {
                Node clone = new Node(head.val);
                dic.Add(head, clone);
                dic[head].next = CopyRandomList(head.next);
                dic[head].random = CopyRandomList(head.random);
            }
            return dic[head];
        }
        #endregion

        #region 08/18/2022
        public Node CopyRandomList_20220818(Node head)
        {
            Dictionary<Node, Node> dic1 = new Dictionary<Node, Node>() { };
            if (head == null) return null;
            Queue<Node> q = new Queue<Node>() { };
            dic1.Add(head, new Node(head.val));
            q.Enqueue(head);
            while (q.Count != 0)
            {
                Node n = q.Dequeue();
                if (n.next != null)
                {
                    if (!dic1.ContainsKey(n.next))
                    {
                        dic1.Add(n.next, new Node(n.next.val));
                        q.Enqueue(n.next);

                    }
                    dic1[n].next = dic1[n.next];

                }
                if (n.random != null)
                {
                    if (!dic1.ContainsKey(n.random))
                    {
                        dic1.Add(n.random, new Node(n.random.val));
                        q.Enqueue(n.random);
                    }

                    dic1[n].random = dic1[n.random];

                }
            }
            return dic[head];
        }
        public Node CopyRandomList_20220818v2(Node head)
        {
            if (head == null) return null;
            return null;
        }

        #endregion

        #region 03/26/2024
        public Node CopyRandomList_2024_03_26(Node head)
        {
            Dictionary<Node, Node> dic = new Dictionary<Node, Node>();

            if (head == null) return null;

            Node copyHead = new Node(head.val);
            dic.Add(head, copyHead);
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(head);

            while (q.Count > 0)
            {
                Node n = q.Dequeue();
                if (n.next != null)
                {
                    q.Enqueue(n.next);

                    if (!dic.ContainsKey(n.next))
                    {
                        dic.Add(n.next, new Node(n.next.val));

                    }
                    dic[n].next = dic[n.next];
                }
                if (n.random != null)
                {
                    if (!dic.ContainsKey(n.random))
                    {
                        dic.Add(n.random, new Node(n.random.val));

                    }
                    dic[n].random = dic[n.random];
                }
            }

            return copyHead;


        }
        #endregion

        #region 10/06/2024 watch out!  the node value may be duplicate
        public Node CopyRandomList_2024_10_06(Node head)
        {
            Node key = head;
            Dictionary<Node, Node> dic = new Dictionary<Node, Node>();

            if (head == null) return null;
            while (head != null)
            {
                if (!dic.ContainsKey(head))
                {
                    dic.Add(head, new Node(head.val));
                }

                if (head.next != null)
                {
                    if (!dic.ContainsKey(head.next))
                        dic.Add(head.next, new Node(head.next.val));

                    dic[head].next = dic[head.next];

                }


                if (head.random != null)
                {
                    if (!dic.ContainsKey(head.random))
                        dic.Add(head.random, new Node(head.random.val));

                    dic[head].random = dic[head.random];
                }
                head = head.next;
            }

            return dic[key];

        }
        #endregion











        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
        #region test
        //_0138.Node n7 = new _0138.Node(7);
        //_0138.Node n13 = new _0138.Node(13);
        //_0138.Node n11 = new _0138.Node(11);
        //_0138.Node n10 = new _0138.Node(10);
        //_0138.Node n1 = new _0138.Node(1);

        //n7.next = n13;
        //    n13.next = n11;
        //    n11.next = n10;
        //    n10.next = n1;
        //    n7.random = null;
        //    n13.random = n7;
        //    n11.random = n1;
        //    n10.random = n11;
        //    n1.random = n7;
        #endregion
    }
}
