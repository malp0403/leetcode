using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2051_2100
{
    internal class _2096
    {
        #region 10/09/2023
        bool isFound_20231009 = false;
        public string GetDirections(TreeNode root, int startValue, int destValue)
        {
            string startString = "";
            find(root, new StringBuilder(), startValue, ref startString);
            isFound_20231009 = false;
            string destString = "";
            find(root, new StringBuilder(), destValue, ref destString);

            int i = 0;
            while(i<startString.Length && i < destString.Length)
            {
                if (startString[i] == destString[i])
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            string startSubString = startString.Substring(i);
            string destSubString = destString.Substring(i);
            
            StringBuilder s = new StringBuilder();
            for(int j = 0; j < startSubString.Length; j++)
            {
                s.Append("U");
            }

            return s.ToString() + destSubString;
        }
        public void find(TreeNode root, StringBuilder sb,int target,ref string outputString)
        {
            if (root == null || isFound_20231009) return;
            if(root.val == target)
            {
                outputString = sb.ToString();
                isFound_20231009 = true;
                return;
            }

            sb.Append("R");
            find(root.right, sb, target, ref outputString);
            sb.Remove(sb.Length - 1, 1);
            sb.Append("L");
            find(root.left, sb, target, ref outputString);
            sb.Remove(sb.Length - 1, 1);
        }

        #endregion
    }
}
