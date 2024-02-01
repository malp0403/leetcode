using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a n-ary tree, find its maximum depth.

The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Nary-Tree input serialization is represented in their level order traversal, each group of children is separated by the null value (See examples).

 

Example 1:



Input: root = [1,null,3,2,4,null,5,6]
Output: 3
Example 2:



Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
Output: 5
 

Constraints:

The total number of nodes is in the range [0, 104].
The depth of the n-ary tree is less than or equal to 1000.
 */
#endregion

namespace leetcode.Problems_0501_1000._0551_0600
{
    internal class _0559
    {
        #region 12/08/2023
        public int MaxDepth(Node root)
        {
            int level = 0;
            if (root == null) return 0;
            Queue<Node> queu = new Queue<Node>();
            queu.Enqueue(root);

            while (queu.Count > 0)
            {
                level++;
                int c = queu.Count;
                while(c >0)
                {
                    Node temp = queu.Dequeue();
                    foreach (Node node in temp.children)
                    {
                        queu.Enqueue(node);
                    }


                    c--;
                }
            }
            return level;
        }
        #endregion
    }
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
