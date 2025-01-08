using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0429
    {
        #region Approach 1: Breadth-first Search using a Queue 09/11/2024
        public IList<IList<int>> LevelOrder(_0429Node root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Queue<_0429Node> queue = new Queue<_0429Node>();
            if (root == null) return list;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> curList = new List<int>();

                int count = queue.Count;
                while (count > 0)
                {
                    var node = queue.Dequeue();
                    curList.Add(node.val);
                    if (node.children.Count > 0)
                    {
                        foreach (var item in node.children)
                        {
                            queue.Enqueue(item);
                        }
                    }


                    count--;
                }

                list.Add(curList);

            }

            return list;
        }
        #endregion
        public class _0429Node
        {
            public int val;
            public IList<_0429Node> children;

            public _0429Node() { }

            public _0429Node(int _val)
            {
                val = _val;
            }

            public _0429Node(int _val, IList<_0429Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
