using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0700
    {
        #region 09/23/2024
        public TreeNode SearchBST_2024_09_23(TreeNode root, int val)
        {
  
            while(root != null)
            {
                if(root.val == val)
                {
                    return root;
                }else if(root.val > val)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }


            return null;
        }
        #endregion
    }
}
