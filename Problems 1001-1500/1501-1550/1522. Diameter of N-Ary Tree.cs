using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1522
    {
        int d = 0;
        public int Diameter(Node root)
        {
            travel(root);
            return d;
        }

        public int travel(Node n)
        {
            if (n == null) return 0;
            List<int> list = new List<int>() {0,0 };
            foreach(var node in n.children)
            {
                int max = travel(node);
                if(max> list[0])
                {
                    list[0] = max;
                    list.Sort();
                }
            }

            d = Math.Max(list[0] + list[1], d);
            return list[1];

        }

        //01-05-2022
        public int helper(Node n)
        {
            if (n == null) return 0;
            int height1 = 0; int height2 = 0;
            foreach (var c in n.children)
            {
                int height= helper(c) + 1;
                if(height > height1)
                {
                    height2 = height1;
                    height1 = height;
                }else if(height > height2)
                {
                    height2 = height;
                }
                d = Math.Max(height1 + height2, d);
            }
            return height1;
        }
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
                val = 0;
                children = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                children = new List<Node>();
            }

            public Node(int _val, List<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
