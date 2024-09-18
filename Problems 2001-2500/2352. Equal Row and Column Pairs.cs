using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question
/*
 Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) such that row ri and column cj are equal.

A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).

 

Example 1:


Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
Output: 1
Explanation: There is 1 equal row and column pair:
- (Row 2, Column 1): [2,7,7]
Example 2:


Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
Output: 3
Explanation: There are 3 equal row and column pairs:
- (Row 0, Column 0): [3,1,2,2]
- (Row 2, Column 2): [2,4,2,2]
- (Row 3, Column 2): [2,4,2,2]
 

Constraints:

n == grid.length == grid[i].length
1 <= n <= 200
1 <= grid[i][j] <= 105
 */
#endregion

namespace leetcode.Problems_2001_2500
{
    internal class _2352
    {
        #region 09/17/2024 count total during Column loop
        public int EqualPairs(int[][] grid)
        {
            Dictionary<string, (int r,int c)> dic = new Dictionary<string, (int r, int c)>();

            for(int i = 0; i < grid.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for(int j=0;j < grid[i].Length; j++)
                {
                    sb.Append(grid[i][j].ToString());
                    sb.Append("#");
                }
                string key =sb.ToString();
                if (dic.ContainsKey(key))
                {
                    dic[key] = (dic[key].r+1, 0);
                }
                else
                {
                    dic.Add(key, (1,0));
                }
            }
            int sum = 0;

            for (int i = 0; i < grid[0].Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < grid.Length; j++)
                {
                    sb.Append(grid[j][i].ToString());
                    sb.Append("#");
                }
                string key = sb.ToString();
                if (dic.ContainsKey(key))
                {
                    sum += dic[key].r;
                }
                
            }
            return sum;

        }
        #endregion
    }
}
