using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0099
    {
        public void RecoverTree(TreeNode root)
        {
            List<int> list = new List<int>() { };
            InOrder(root, list);
            int x = 1001;
            int y = 1001;
            bool isFirstOccurence = false;
            for(int i =0; i < list.Count-1; i++)
            {
                if(list[i]>list[i+1])
                {
                    y = list[i + 1];
                    if (!isFirstOccurence)
                    {
                        x = list[i];
                        isFirstOccurence = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            RecoverHelper(root, 2, x, y);

        }
        public void RecoverHelper(TreeNode root,int count, int x,int y)
        {
            if (root == null) return;
            if(root.val == x || root.val == y)
            {
                root.val = root.val == x ? y : x;
                count--;
                if (count == 0) return;
            }
            RecoverHelper(root.left, count, x,y);
            RecoverHelper(root.right, count, x, y);
        }
        public void InOrder(TreeNode node, List<int> list)
        {
            if (node == null) return;
            InOrder(node.left, list);
            list.Add(node.val);
            InOrder(node.right, list);
        }
    }
}
