using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    public class _0431
    {
        #region 09/12/2024 Double Link Node: prev,next,count,hashset<string> keys

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
            if (dic.ContainsKey(key))
            {
                var curNode = dic[key];
                curNode.Keys.Remove(key);
                if(curNode.Next ==tail || curNode.Next.Count > curNode.Count + 1)
                {
                    Node newNode = new Node(curNode.Count + 1);
                    AddNodeAfter(newNode, curNode);
                }

                curNode.Next.Keys.Add(key);
                dic[key] = curNode.Next;

                if (curNode.Keys.Count == 0)
                {
                    RemoveNode(curNode);
                }

            }
            else
            {
                if(head.Next == tail || head.Next.Count > 1)
                {
                    var newNode= new Node(1);
                    AddNodeAfter(newNode, head);
                }
                head.Next.Keys.Add(key);
                dic[key] = head.Next;   

            }
        }

        public void Dec(string key)
        {
            if (!dic.ContainsKey(key))
            {
                return;
            }

            var curNode = dic[key];
            curNode.Keys.Remove(key);

            if (curNode.Count > 1)
            {
                if(curNode.Prev ==head || curNode.Prev.Count < curNode.Count - 1)
                {
                    var newNode = new Node(curNode.Count - 1);
                    AddNodeAfter(newNode, curNode.Prev);
                }
                curNode.Prev.Keys.Add(key);
                dic[key] = curNode.Prev;
            }
            else
            {
                dic.Remove(key);
            }

            if (curNode.Keys.Count == 0)
            {
                RemoveNode(curNode);
            }

        }

        public string GetMaxKey()
        {
            foreach (var item in tail.Prev.Keys)
            {
                return item;
            }
            return "";
        }

        public string GetMinKey()
        {
            foreach (var item in head.Next.Keys)
            {
                return item;
            }
            return "";
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
