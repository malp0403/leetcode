using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500
{
    internal class _1143
    {
        #region 09/29/2024 Approach 1: Memoization; use first letter or skip
        int max_2024_09_29 = 0;
        string s1_2024_09_29;
        string s2_2024_09_29;
        Dictionary<(int i, int j), int> dic_2024_09_29;
        public int LongestCommonSubsequence_app1(string text1, string text2)
        {
            s1_2024_09_29 = text1;
            s2_2024_09_29 = text2;
            dic_2024_09_29 = new Dictionary<(int i, int j), int>();
            return helper_2024_09_29(0, 0);


        }

        public int helper_2024_09_29(int i, int j)
        {
            if (i == s1_2024_09_29.Length || j == s2_2024_09_29.Length)
            {
                return 0;
            }
            if (dic_2024_09_29.ContainsKey((i, j))) return dic_2024_09_29[(i, j)];


            int option1 = helper_2024_09_29(i + 1, j);
            int indx = s2_2024_09_29.IndexOf(s1_2024_09_29[i], j);
            int option2 = 0;
            if(indx != -1)
            {
                option2 = 1 + helper_2024_09_29(i + 1, indx + 1);
            }

            int max = Math.Max(option1, option2);

            dic_2024_09_29.Add((i, j), max);
            return max;

        }
        #endregion

        #region 09/29/2024  Approach 2: Improved Memoization; compare first letter the same or not

        #endregion

        #region 09/29/2024 Approach 3: Dynamic Programming Bottom up
        public int longestCommonSubsequence_app3Bu(String text1, String text2)
        {

            //// Make a grid of 0's with text2.length() + 1 columns 
            //// and text1.length() + 1 rows.
            //int[][] dpGrid = new int[text1.length() + 1][text2.length() + 1];

            //// Iterate up each column, starting from the last one.
            //for (int col = text2.length() - 1; col >= 0; col--)
            //{
            //    for (int row = text1.length() - 1; row >= 0; row--)
            //    {
            //        // If the corresponding characters for this cell are the same...
            //        if (text1.charAt(row) == text2.charAt(col))
            //        {
            //            dpGrid[row][col] = 1 + dpGrid[row + 1][col + 1];
            //            // Otherwise they must be different...
            //        }
            //        else
            //        {
            //            dpGrid[row][col] = Math.max(dpGrid[row + 1][col], dpGrid[row][col + 1]);
            //        }
            //    }
            //}

            //// The original problem's answer is in dp_grid[0][0]. Return it.
            //return dpGrid[0][0];
            return 0;
        }
        #endregion
    }
}
