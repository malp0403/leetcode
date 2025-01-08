using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0051
    {
        #region answer
        HashSet<int> columns = new HashSet<int>() { };
        HashSet<int> dialog = new HashSet<int>() { };
        HashSet<int> antiDialog = new HashSet<int>() { };
        IList<IList<string>> answer = new List<IList<string>>(){};
        public IList<IList<string>> SolveNQueens(int n)
        {
            int[][] matrix = new int[n][];
            for(int i =0; i < n; i++)
            {
                matrix[i] = Enumerable.Repeat(0, n).ToArray();
            }
            backtracking(0, matrix);
            return answer;
        }
        public void backtracking(int row,int[][] matrix)
        {
            if(row >= matrix.Length)
            {
                answer.Add(convert(matrix));
                return;
            }
            for(int i = 0; i < matrix[0].Length; i++)
            {
                if(!columns.Contains(i) 
                    && !dialog.Contains(row-i)
                    && !antiDialog.Contains(row + i))
                {
                    columns.Add(i);
                    dialog.Add(row - i);
                    antiDialog.Add(row + i);
                    matrix[row][i] = 1;
                    backtracking(row + 1, matrix);
                    columns.Remove(i);
                    dialog.Remove(row - i);
                    antiDialog.Remove(row + i);
                    matrix[row][i] = 0;
                }
            }
        }
        public List<string> convert(int[][] matrix)
        {
            List<string> res = new List<string>() { };
            for (int i =0;i < matrix.Length; i++)
            {
                StringBuilder sb = new StringBuilder() { };
                for(int j=0; j < matrix[0].Length; j++)
                {
                    sb.Append(matrix[i][j] == 1 ? "Q" : ".");
                }
                res.Add(sb.ToString());
            }
            return res;
        }

        #endregion

        #region 02/27/2024
       
        #endregion
    }
}
