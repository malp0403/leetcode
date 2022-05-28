using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _059
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < result.Length; i++)
            {
                int[] temp = new int[n];
                Array.Fill(temp, 0);
                result[i] = temp;
            }
            int up = 0;
            int left = 0;
            int right = n - 1;
            int down = n - 1;
            int count = 1;
            while (count <= n * n)
            {
                for (int i = left; i <= right; i++)
                {
                    result[up][i] = count;
                    count++;
                }
                for(int i = up + 1; i <= down; i++)
                {
                    result[i][right] = count;
                    count++;
                }
                if(right != left)
                {
                    for(int i= right-1;i >= left; i--)
                    {
                        result[down][i] = count;
                        count++;
                    }
                }
                if(down!= up)
                {
                    for (int i = down-1; i > up; i--)
                    {
                        result[i][left] = count;
                        count++;
                    }
                }
                up++;
                down--;
                left++;
                right--;
            }
            return result;

        }
    }
}
