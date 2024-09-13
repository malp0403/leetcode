using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    public class _0431
    {
        #region 09/12/2024

        public Node head;
        public Node tail;
        Dictionary<string, Node> dic;
        public _0431()
        {
            dic= new Dictionary<string, Node>();
            head = new Node(0);
            tail = new Node(0);
            head.Next = tail;
            tail.Prev = head;
        }

        public void AddNodeAfter(Node newNode, Node prevNode)
        {
            newNode.Next = prevNode.Next;
            newNode.Prev = prevNode;

            prevNode.Next.Prev = newNode;
            prevNode.Next = newNode;
        }
        public void RemoveNode(Node node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }

        public void Inc(string key)
        {
            if()
        }

        public void Dec(string key)
        {

        }

        public string GetMaxKey()
        {

        }

        public string GetMinKey()
        {

        }
        public class Node
        {
            public int Count;
            public HashSet<string> Keys;
            public Node Prev;
            public Node Next;

            public Node(int count)
            {
                Count = count;
                Keys = new HashSet<string>();
            }
        }
        #endregion
    }
}
