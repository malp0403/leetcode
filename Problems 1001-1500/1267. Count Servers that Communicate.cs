using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 You are given a map of a server center, represented as a m * n integer matrix grid, where 1 means that on that cell there is a server and 0 means that it is no server. Two servers are said to communicate if they are on the same row or on the same column.

Return the number of servers that communicate with any other server.

 

Example 1:



Input: grid = [[1,0],[0,1]]
Output: 0
Explanation: No servers can communicate with others.
Example 2:



Input: grid = [[1,0],[1,1]]
Output: 3
Explanation: All three servers can communicate with at least one other server.
Example 3:



Input: grid = [[1,1,0,0],[0,0,1,0],[0,0,1,0],[0,0,0,1]]
Output: 4
Explanation: The two servers in the first row can communicate with each other. The two servers in the third column can communicate with each other. The server at right bottom corner can't communicate with any other server.
 

Constraints:

m == grid.length
n == grid[i].length
1 <= m <= 250
1 <= n <= 250
grid[i][j] == 0 or 1
 */
#endregion

namespace leetcode.Problems_1001_1500._1251_1300
{
    internal class _1267
    {
        #region 11/04/2023 first loop count total computer in row/col; second loop count connected computer;
        public int CountServers_20231104(int[][] grid)
        {
            int[] row = Enumerable.Repeat(0,grid.Length).ToArray();
            int[] cols = Enumerable.Repeat(0, grid[0].Length).ToArray();
            for (int i = 0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        row[i]++;
                        cols[j]++;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (row[i]>=2 || cols[j] >= 2)
                        {
                            count++;
                        }

                    }
                }
            }
            return count;
        }
        #endregion
    }
}
