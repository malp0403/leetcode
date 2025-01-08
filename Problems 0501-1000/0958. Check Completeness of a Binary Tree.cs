using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0958
    {
        int? max=null;
        public bool IsCompleteTree(TreeNode root)
        {
            return travel(root, 1);
        }
        public bool travel(TreeNode n, int level) {
            if (n != null)
            {
                var l = travel(n.left, level + 1);
                var r = travel(n.right, level + 1);
                return l && r;
            }
            else
            {
                if(max == null)
                {
                    max = level;
                }
                else
                {
                    if(level < max)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
