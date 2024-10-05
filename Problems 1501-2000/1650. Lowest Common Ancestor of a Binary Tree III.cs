using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1650
    {
        #region solution
        public Node LowestCommonAncestor(Node p, Node q)
        {
            Stack<Node> sp = new Stack<Node>() { };
            Stack<Node> sq = new Stack<Node>() { };
            helper(p, sp);
            helper(q, sq);
            Node prev = sp.Peek();
            while (sp.Count != 0 && sq.Count != 0)
            {
                var n1 = sp.Pop();
                var n2 = sq.Pop();
                if (n1 != n2)
                {
                    return prev;
                }
                else
                {
                    prev = n1;
                }
            }
            return prev;

        }
        public void helper(Node node, Stack<Node> stack)
        {
            if (node != null)
            {
                stack.Push(node);
                helper(node.parent, stack);
            }
        }
        //********** version 2**********
        public Node LowestCommonAncestor_V2(Node p, Node q)
        {
            HashSet<Node> set1 = new HashSet<Node>() { };
            HashSet<Node> set2 = new HashSet<Node>() { };
            while (p != null || q != null)
            {
                set1.Add(p);
                set2.Add(q);
                if (set1.Contains(q))
                {

                    return q;
                }
                if (set2.Contains(p))
                {
                    return p;
                }
                p = p.parent != null ? p.parent : p;
                q = q.parent != null ? q.parent : q;
            }
            return null;

        }
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node parent;
        }
        #endregion

        #region 10/01/2024 two hashset
        public Node LowestCommonAncestor_2024_10_01(Node p, Node q)
        {
            HashSet<Node> set1 = new HashSet<Node>();
            HashSet<Node > set2 = new HashSet<Node>();
            while(p !=null || q != null)
            {
                if(p != null)
                {
                    set1.Add(p);
                }
                if(q != null)
                {
                    set2.Add(q);
                }

                if (set1.Contains(q))
                {
                    return q;
                }
                if (set2.Contains(p))
                {
                    return p;
                }
                if(p != null)
                {

                    p = p.parent;
                }
                if(q != null)
                {
                    q = q.parent;
                }
            }
            return null;
        }

        
        #endregion
    }
}
