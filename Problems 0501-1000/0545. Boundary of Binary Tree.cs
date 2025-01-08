using leetcode.Problems;
using leetcode.Recursive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0501_0550
{
    internal class _0545
    {
        #region 09/11/2023 
        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;

            if(!isLeaf(root))
            {
                list.Add(root.val);
            }

            TreeNode t = root.left;
            while(t != null)
            {
                if (!isLeaf(t))
                {
                    list.Add(t.val);
                }
                if(t.left != null)
                {
                    t = t.left;
                }
                else
                {
                    t = t.right;
                }
            }

            addleavse(list, root);

            Stack<int> stack = new Stack<int>();
            t = root.right;
            while(t != null )
            {
                if (!isLeaf(t))
                {
                    stack.Push(t.val);
                }
                if(t.right != null)
                {
                    t = t.right;
                }
                else
                {
                    t = t.left;
                }

            }

            while (stack.Count != 0)
            {
                list.Add(stack.Pop());
            }
            return list;


        }

        public bool isLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
        public void addleavse(List<int> res,TreeNode node)
        {
            if (isLeaf(node))
            {
                res.Add(node.val);
            }
            else
            {
                if (node.left !=null)
                {
                    addleavse(res, node.left);
                }
                if(node.right != null)
                {
                    addleavse(res,node.right);
                }
            }
        }

        #endregion
    }
}
