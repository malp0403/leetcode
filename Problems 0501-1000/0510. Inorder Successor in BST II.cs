using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0510
    {
        public Node InorderSuccessor(Node x)
        {
            if (x == null) return null;
            Node res = null;
            if (x.right != null)
            {
                res = x.right;
                while (res != null && res.left !=null)
                {
                    res = res.left;
                }
                return res;
            }
            else
            {
                res = x.parent;
                while (res != null && res.val < x.val)
                {
                    res = res.parent;
                }
            }
            return res;

        }

        //01-11-2022-----------------------------------
        public Node InorderSuccessor_R2(Node x)
        {
            if (x.parent == null && x.right == null) return null;
            if (x.right != null)
            {
                x = x.right;
                while (x.left != null)
                {
                    x = x.left;
                }
                return x;
            }
            else
            {

                while (x.parent != null && x == x.parent.right) x = x.parent;
                return x.parent;

                //if (x.parent.left == x)
                //{
                //    return x.parent;
                //}
                //else
                //{
                //    while(x.parent !=null && x.parent.left != x)
                //    {
                //        x = x.parent;
                //    }
                //    return x.parent;
                //}
            }   
        }
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node parent;
            public Node(int val)
            {
                this.val = val;
            }
        }
    }

}
