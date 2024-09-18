using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1701_1750
{
    internal class _1740
    {
        #region 10/17/2023

        public int FindDistance(TreeNode root, int p, int q)
        {
            string sp = "";
            string sq = "";
            helper(root, p, false,new StringBuilder(), ref sp);
            helper(root, q, false, new StringBuilder(), ref sq);

            while(sp.Length >0 && sq.Length>0 && sp[0] == sq[0])
            {
                sp = sp.Substring(1);
                sq = sq.Substring(1);
            }

            return sp.Length + sq.Length;

        }
        public bool helper(TreeNode node, int val, bool found, StringBuilder sb,ref string refStr)
        {
            if (node == null) return false;
            if (found)
            {
                return true;
            }
            if (node.val == val)
            {
                found = true;
                refStr = sb.ToString();
                return found;
            }

            if (node.right != null)
            {
                sb.Append("R");
                helper(node.right, val, found, sb,ref refStr);
                sb.Remove(sb.Length - 1, 1);
            }
            if (node.left != null)
            {
                sb.Append("L");
                helper(node.left, val, found, sb,ref refStr);
                sb.Remove(sb.Length - 1, 1);
            }
            return found;

        }
        #endregion

    }
}