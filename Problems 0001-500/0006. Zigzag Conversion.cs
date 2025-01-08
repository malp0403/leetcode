using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace leetcode.Problems_0001_500._0001_50
{
    internal class _0006
    {
        #region 01/02/2024 LeetCode Approach 1: Simulate Zig-Zag Movement
        public string Convert_Approach1(string s, int numRows)
        {
            if (numRows == 1) return s;


            char[][] records = new char[numRows][];
            int group = (int)Math.Ceiling(s.Length / (numRows * 2 - 2.0));
            int numCols = group * (numRows - 1);

            for (int i =0; i < numRows; i++)
            {
                records[i] = Enumerable.Repeat(' ', numCols).ToArray();
            }
            int index = 0;
            int currRow = 0; 
            int currCol = 0;
          
            while (index < s.Length)
            {
                while(currRow<numRows && index < s.Length)
                {
                    records[currRow][currCol] = s[index];
                    index++;
                    currRow++;
                }

                currRow -= 2;
                currCol++;

                while(currRow > 0 && currCol< numCols && index < s.Length)
                {
                    records[currRow][currCol] = s[index];
                    currRow--;
                    currCol++;
                    index++;
                }

            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < records.Length; i++)
            {
                for (int j = 0; j < records[0].Length; j++)
                {
                    if (records[i][j] != ' ')
                    {
                        sb.Append(records[i][j]);
                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region 01/02/2024 LeetCode Approach 2: String Traversal
        public string Convert_Approach2(string s, int numRows)
        {
            if (numRows == 1) return s;

            StringBuilder sb = new StringBuilder();
            int charsInSection = 2 * (numRows - 1);

            for(int curRow =0; curRow < numRows; curRow++)
            {
                int index = curRow;

                while (index < s.Length)
                {

                    sb.Append(s[index]);


                    if(curRow !=0 && curRow != numRows - 1)
                    {
                        int temp = charsInSection - 2 * curRow;
                        int index2 = index + temp;

                        if (index2 < s.Length)
                        {
                            sb.Append(s[index2]);
                        }
                    }

                    index += charsInSection;
                }

            }

            return sb.ToString();

        }
        #endregion
    }
}
