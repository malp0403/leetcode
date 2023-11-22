using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Xml.Schema;
#region Examples
/*
 The chess knight has a unique movement, it may move two squares vertically and one square horizontally, or two squares horizontally and one square vertically (with both forming the shape of an L). The possible movements of chess knight are shown in this diagaram:

A chess knight can move as indicated in the chess diagram below:


We have a chess knight and a phone pad as shown below, the knight can only stand on a numeric cell (i.e. blue cell).


Given an integer n, return how many distinct phone numbers of length n we can dial.

You are allowed to place the knight on any numeric cell initially and then you should perform n - 1 jumps to dial a number of length n. All jumps should be valid knight jumps.

As the answer may be very large, return the answer modulo 109 + 7.

 

Example 1:

Input: n = 1
Output: 10
Explanation: We need to dial a number of length 1, so placing the knight over any numeric cell of the 10 cells is sufficient.
Example 2:

Input: n = 2
Output: 20
Explanation: All the valid number we can dial are [04, 06, 16, 18, 27, 29, 34, 38, 40, 43, 49, 60, 61, 67, 72, 76, 81, 83, 92, 94]
Example 3:

Input: n = 3131
Output: 136006598
Explanation: Please take care of the mod.
 

Constraints:

1 <= n <= 5000
 */
#endregion
namespace leetcode.Problems
{
    class _0935
    {
        #region 11/13/2023 DFS cause TLE
        List<List<int>> directions = new List<List<int>>() {

            new List<int>(){2,1 },
                        new List<int>(){2,-1 },
            new List<int>(){-2,1 },
            new List<int>(){ -2,-1},
            new List<int>(){1,2 },
            new List<int>(){ 1,-2},
            new List<int>(){ -1,2},
            new List<int>(){ -1,-2}

        };
        long mode = (long)1e9 + 7;
        long total = 0;
        public int KnightDialer(int n)
        {
            int[][] boards = new int[4][];
            boards[0] = new int[3] { 1, 2, 3 };
            boards[1] = new int[3] { 4, 5, 6 };
            boards[2] = new int[3] { 7, 8, 9 };
            boards[3] = new int[3] { -1, 0, -1 };
            if (n == 1) return 10;
            for(int i =0; i < 4; i++)
            {
                for(int j =0; j < 3; j++)
                {
                    if (boards[i][j] != -1)
                    {
                        dfs(i, j, n - 1, boards);
                    }
                }
            }
            return (int)total;
        }
        public void dfs(int r,int c,int count,int[][] boards)
        {
            if(count == 0)
            {
                total = (total+1) % mode;
                return;
            }
            foreach (var item in directions)
            {
                int row = r + item[0];
                int col = c + item[1];
                if (row < 0 || row > 4 || col < 0 || col > 3 || boards[row][col] == -1) continue;
                dfs(row, col, count - 1, boards);
            }
        }

        #endregion

        #region MyRegion
        public int KnightDialer_20231113_solution2(int n)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            dic.Add(1, new List<int>() { 6, 8 });
            dic.Add(2, new List<int>() { 7, 9 });
            dic.Add(3, new List<int>() { 4, 8 });
            dic.Add(4, new List<int>() { 3, 9, 0 });
            dic.Add(6, new List<int>() { 0, 1, 7 });
            dic.Add(7, new List<int>() { 2, 6 });
            dic.Add(8, new List<int>() { 1, 3 });
            dic.Add(9, new List<int>() { 2, 4 });
            dic.Add(0, new List<int>() { 4, 6 });

            if (n == 1) return 10;
            long[] arr = Enumerable.Repeat((long)0, 10).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i != 5 ? 1 : 0;
            }
            long sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = 0;
                long[] temp = Enumerable.Repeat((long)0, 10).ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] != 0)
                    {
                        sum = (sum + dic[j].Count * arr[j]) % mode;
                        foreach (var item in dic[j])
                        {
                            temp[item] = (arr[j] + temp[item]) % mode;
                        }
                    }
                }
                arr = temp;

            }

            return (int)sum;



        }

        #endregion
    }
}
