using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0931
    {
        //Top Down*************************
        Dictionary<int, int[]> dic = new Dictionary<int, int[]>() { };
        public int MinFallingPathSum(int[][] matrix)
        {
            int[] ans = dp(matrix.Length - 1, matrix);
            int min = Int16.MaxValue;
            for(int i =0; i < ans.Length; i++)
            {
                min = Math.Min(min, ans[i]);
            }
            return min;
        }
        public int[] dp(int h,int[][] matrix)
        {
            if (h == 0) return matrix[0];
            if (!dic.ContainsKey(h))
            {
                int[] arr = Enumerable.Repeat(0, matrix[0].Length).ToArray();
                int[] temp = dp(h - 1, matrix);
                for (int i = 0; i < arr.Length; i++)
                {
                    int first = i - 1 >= 0 ? temp[i - 1]+matrix[h][i] : Int16.MaxValue ;
                    int second = temp[i]+matrix[h][i];
                    int third = i + 1 < matrix[0].Length ? temp[i + 1] + matrix[h][i] : Int16.MaxValue;
                    arr[i] = Math.Min(first, second) > third ? third : Math.Min(first, second);
                }
                dic.Add(h, arr);
            }
            return dic[h];
        }

        //Bottom up***********************************
        public int MinFallingPathSum_BU(int[][] matrix)
        {
            int[] arr = matrix[0];
            if (matrix.Length > 1) 
            {
                for(int i =1; i < matrix.Length; i++)
                {
                    int[] temp = Enumerable.Repeat(0, matrix[0].Length).ToArray();
                    for(int j=0; j < matrix[0].Length; j++)
                    {
                       int first = j == 0 ? Int16.MaxValue : arr[j - 1] + matrix[i][j];
                        int second = arr[j] + matrix[i][j];
                        int third = j == matrix[0].Length - 1 ? Int16.MaxValue : arr[j + 1] + matrix[i][j];
                        int res = Math.Min(first, second) > third ? third : Math.Min(first, second);
                        temp[j] = res;
                    }
                    arr = temp;
                    
                }
            }

            int min = Int16.MaxValue;
            for(int i=0; i < arr.Length; i++)
            {
                min = Math.Min(arr[i], min);
            }
            return min;
        }
    }
}
