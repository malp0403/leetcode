using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _006
    {
        public string Convert(string s, int numRows)
        {
            int[][] x = new int[numRows][];
            int row = 0;
            int col = 0;
            for(int i =0; i <s.Length; i++)
            {
                if(col % (numRows-1) == 0)
                {
                    x[row][col] = s[i];
                    row++;
                    if(row == numRows)
                    {
                        col++;
                        row = 0;
                    }
                }
                else
                {
                    x[numRows -1 - col % 4][col] = s[i];
                    col++;
                }
            }
            
            for(int i =0; i < x.Rank; i++)
            {
                for(int j=0; j < x.Length; j++)
                {
                    Console.WriteLine(x[i][j]);
                }
            }
            


            return "";
        }

        public string Convert_v2(string s, int numRows)
        {
            if (numRows == 1) return s;
            int cycle = 2 * (numRows - 1);
            string result = string.Empty;

            for (int i = 0; i < numRows; i++)
            {
                int multi = 0;
                while (multi * cycle + i < s.Length)
                {
                    result += s[multi * cycle + i];
                    if (i % (numRows - 1) != 0)
                    {
                        if (multi * cycle + (cycle - i) < s.Length)
                        {
                            result += s[multi * cycle + (cycle - i)];
                        }
                    }
                    multi++;
                    Console.WriteLine(result);
                }
            }
            return result;
        }
    }
}
