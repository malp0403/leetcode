using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0133
    {
        #region answer
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>() { };
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;

            if (!dic.ContainsKey(node))
            {

                List<Node> cloneNeighbors = new List<Node>() { };
                Node cloneTreenode = new Node(node.val, cloneNeighbors);

                dic.Add(node, cloneTreenode);
                foreach (var child in node.neighbors)
                {
                    cloneNeighbors.Add(CloneGraph(child));
                }

            }
            else
            {
                return dic[node];
            }

            return dic[node];

        }
        #endregion
        #region answer2
        public Node CloneGraph_v2(Node node)
        {
            if (node == null) return null;
            Queue<Node> queue = new Queue<Node>() { };
            queue.Enqueue(node);
            dic.Add(node, new Node(node.val, new List<Node>() { }));
            while(queue.Count != 0)
            {
                var n = queue.Dequeue();
                foreach (var child in n.neighbors)
                {
                    if (!dic.ContainsKey(child))
                    {
                        dic.Add(child, new Node(child.val, new List<Node>() { }));
                        queue.Enqueue(child);
                    }
                    dic[n].neighbors.Add(dic[child]);
                }
                
            }
            return dic[node];

        }
        #endregion
        #region 08/18/2022
        public Node CloneGraph_20220818(Node node)
        {
            if (node == null) return null;
            Dictionary<Node, Node> dic = new Dictionary<Node, Node>() { };
            Queue<Node> que = new Queue<Node>() { };
            que.Enqueue(node);
            dic.Add(node, new Node(node.val,new List<Node>() { }));
            while(que.Count != 0)
            {
                Node n = que.Dequeue();
                foreach (var child in n.neighbors)
                {
                    if (!dic.ContainsKey(child))
                    {
                        dic.Add(child, new Node(child.val));
                        que.Enqueue(child);
                      
                    }
                    dic[n].neighbors.Add(dic[child]);
                    
                }
            }
            return dic[node];
        }
        #endregion
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
    }
}
