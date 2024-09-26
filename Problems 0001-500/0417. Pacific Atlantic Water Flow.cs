using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Question
/*
 There is an m x n rectangular island that borders both the Pacific Ocean and Atlantic Ocean. The Pacific Ocean touches the island's left and top edges, and the Atlantic Ocean touches the island's right and bottom edges.

The island is partitioned into a grid of square cells. You are given an m x n integer matrix heights where heights[r][c] represents the height above sea level of the cell at coordinate (r, c).

The island receives a lot of rain, and the rain water can flow to neighboring cells directly north, south, east, and west if the neighboring cell's height is less than or equal to the current cell's height. Water can flow from any cell adjacent to an ocean into the ocean.

Return a 2D list of grid coordinates result where result[i] = [ri, ci] denotes that rain water can flow from cell (ri, ci) to both the Pacific and Atlantic oceans.

 

Example 1:


Input: heights = [[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]
Output: [[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]
Explanation: The following cells can flow to the Pacific and Atlantic oceans, as shown below:
[0,4]: [0,4] -> Pacific Ocean 
       [0,4] -> Atlantic Ocean
[1,3]: [1,3] -> [0,3] -> Pacific Ocean 
       [1,3] -> [1,4] -> Atlantic Ocean
[1,4]: [1,4] -> [1,3] -> [0,3] -> Pacific Ocean 
       [1,4] -> Atlantic Ocean
[2,2]: [2,2] -> [1,2] -> [0,2] -> Pacific Ocean 
       [2,2] -> [2,3] -> [2,4] -> Atlantic Ocean
[3,0]: [3,0] -> Pacific Ocean 
       [3,0] -> [4,0] -> Atlantic Ocean
[3,1]: [3,1] -> [3,0] -> Pacific Ocean 
       [3,1] -> [4,1] -> Atlantic Ocean
[4,0]: [4,0] -> Pacific Ocean 
       [4,0] -> Atlantic Ocean
Note that there are other possible paths for these cells to flow to the Pacific and Atlantic oceans.
Example 2:

Input: heights = [[1]]
Output: [[0,0]]
Explanation: The water can flow from the only cell to the Pacific and Atlantic oceans.
 

Constraints:

m == heights.length
n == heights[r].length
1 <= m, n <= 200
0 <= heights[r][c] <= 105
 */
#endregion

#region Test
//test
//int[][] heigths = new int[5][];
//heigths[0] = new int[5] { 1, 2, 2, 3, 5 };
//            heigths[1] = new int[5] {3, 2, 3, 4, 4 };
//            heigths[2] = new int[5] { 2,4,5,3,1};
//            heigths[3] = new int[5] { 6, 7, 1, 4, 5 };
//            heigths[4] = new int[5] { 5, 1, 1, 2, 4 };

//            int[][] heigths2 = new int[3][];
//heigths2[0] = new int[2] { 1,1};
//            heigths2[1] = new int[2] { 1, 1 };
//            heigths2[2] = new int[2] { 1, 1 };
#endregion

namespace leetcode.Problems
{
    class _0417
    {
        #region Solution
        bool[][] Pacific;
        bool[][] Atlantic;
        int[][] _heights;
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){ 0,1},
        new List<int>(){ 0,-1},
        new List<int>(){ -1,0},
        new List<int>(){ 1,0}
        };
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            _heights = heights;
            Pacific = new bool[heights.Length][];
            Atlantic = new bool[heights.Length][];
            for (int x = 0; x < heights.Length; x++)
            {
                Pacific[x] = Enumerable.Repeat<bool>(false, heights[0].Length).ToArray();
                Atlantic[x] = Enumerable.Repeat<bool>(false, heights[0].Length).ToArray();
            }
            IList<IList<int>> result = new List<IList<int>>() { };
            //visited = resetVisited();
            int j = 0;
            while (j < _heights[0].Length)
            {
                Search(0, j, _heights[0][j], Pacific);
                j++;
            }
            int i = 1;
            while (i < _heights.Length)
            {
                Search(i, 0, _heights[i][0], Pacific);
                i++;
            }

            //visited = resetVisited();
            j = 0;
            while (j < _heights[0].Length)
            {
                Search(_heights.Length - 1, j, _heights[_heights.Length - 1][j], Atlantic);
                j++;
            }
            i = 0;
            while (i < _heights.Length)
            {
                Search(i, _heights[0].Length - 1, _heights[i][_heights[0].Length - 1], Atlantic);
                i++;
            }

            for (int z = 0; z < Pacific.Length; z++)
            {
                for (int y = 0; y < Pacific[0].Length; y++)
                {
                    if (Pacific[z][y] == true && Atlantic[z][y] == true)
                    {
                        result.Add(new List<int>() { z, y });
                    }
                }
            }


            return result;

        }
        public void Search(int row, int col, int prevHeight, bool[][] visited)
        {
            if (row < 0 || row >= _heights.Length || col < 0 || col >= _heights[0].Length
                || visited[row][col] || _heights[row][col] < prevHeight) return;
            visited[row][col] = true;
            foreach (var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                Search(r, c, _heights[row][col], visited);
            }
        }
        #endregion

        #region 09/05/2024
        public IList<IList<int>> PacificAtlantic_2024_09_05(int[][] heights)
        {
            IList<IList<int>> ans = new List<IList<int>>();

            int[][] total = new int[heights.Length][];
            HashSet<(int r, int c)> seen_p = new HashSet<(int r, int c)>();
            HashSet<(int r, int c)> seen_a = new HashSet<(int r, int c)>();
            Queue<(int row, int col)> queue_p = new Queue<(int row, int col)>();
            Queue<(int row, int col)> queue_a = new Queue<(int row, int col)>();
            int ROW = heights.Length;
            int COL = heights[0].Length;
            for (int i = 0; i < ROW; i++)
            {
                queue_p.Enqueue((i, 0));
                queue_a.Enqueue((i, COL - 1));

                seen_p.Add((i, 0));
                seen_a.Add((i, COL - 1));

                total[i] = Enumerable.Repeat(0, COL).ToArray();
            }

            for (int i = 0; i < COL; i++)
            {
                if(!seen_p.Contains((0, i)))
                {
                    queue_p.Enqueue((0,i));

                }
                if (!seen_a.Contains((ROW - 1, i)))
                {
                    queue_a.Enqueue((ROW - 1, i));
                }

                seen_p.Add((0, i));
                seen_a.Add((ROW - 1, i));
            }


            bfs(queue_p, heights, total, seen_p);
            bfs(queue_a, heights, total, seen_a);

            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (total[i][j] == 2)
                    {
                        ans.Add(new List<int> { i, j });
                    }
                }
            }
            return ans;


        }

        public void bfs(Queue<(int row, int col)> queue, int[][] heights, int[][] total, HashSet<(int r, int c)> seen)
        {
            List<List<int>> dir = new List<List<int>>()
            {
                new List<int>(){1,0},
                                new List<int>(){-1,0},
                new List<int>(){0,1},
                new List<int>(){0,-1}
            };

            while (queue.Count > 0)
            {
                var ele = queue.Dequeue();
                 
                total[ele.row][ele.col]++;
                seen.Add((ele.row,ele.col));
                foreach (var item in dir)
                {
                    int r = ele.row + item[0];
                    int c = ele.col + item[1];
                    if (r < 0 || r >= heights.Length || c < 0 || c >= heights[0].Length || seen.Contains((r, c))) continue;
                    if (heights[r][c] < heights[ele.row][ele.col]) continue;

                    queue.Enqueue((r, c));
                    seen.Add((r, c));

                }
            }
        }
        #endregion
    }
}
