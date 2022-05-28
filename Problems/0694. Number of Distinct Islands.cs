using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0694
    {
        /// <summary>
        /// 1. compare coordinate
        /// 2. compare Key(pair,par)
        /// 3. compare path-> top,down,left,right
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>

        public int NumDistinctIslands(int[][] grid)
        {
            _grid = grid;
            visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, grid[0].Length).ToArray();
            }
            HashSet<string> set = new HashSet<string>() { };

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1 && !visited[i][j])
                    {
                        var island = "";

                        expand(i, j, ref island, "0");
                        set.Add(island);
                    }
                }
            }
            return set.Count;
        }

        public void expand(int row, int col, ref string name, string dir)
        {
            if (row < 0 || row >= _grid.Length || col < 0 || col >= _grid[row].Length || _grid[row][col] == 0) return;
            if (visited[row][col]) return;

            visited[row][col] = true;

            name += dir;
            expand(row + 1, col, ref name, "D");
            expand(row - 1, col, ref name, "U");
            expand(row, col + 1, ref name, "R");
            expand(row, col - 1, ref name, "L");

            name += "0";
        }

        //01-12-2022----------------------------------------
        bool[][] visited;
        int[][] _grid;
        List<List<int>> directions = new List<List<int>>() {
            new List<int>(){ 1,0},
            new List<int>(){ -1,0},
            new List<int>(){ 0,1},
            new List<int>(){ 0,-1},
        };
        public int NumDistinctIslands_R2(int[][] grid)
        {
            _grid = grid;
            visited = new bool[grid.Length][];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, grid[0].Length).ToArray();
            }
            List<List<List<int>>> islands = new List<List<List<int>>>() { };

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1 && !visited[i][j])
                    {
                        List<List<int>> island = helper_R2(i, j);

                        //move island to top left;
                        int minCol = grid[0].Length - 1;
                        foreach (var e in island)
                        {
                            minCol = Math.Min(minCol, e[1]);
                        }
                        foreach (var e in island)
                        {
                            e[0] = e[0] - i;
                            e[1] = e[1] - minCol;
                        }
                        if (isUnique(island, islands))
                        {
                            islands.Add(island);
                        }
                    }
                }
            }
            return islands.Count;
        }
        public List<List<int>> helper_R2(int row, int col)
        {
            List<List<int>> ans = new List<List<int>>() { };
            ans.Add(new List<int>() { row, col });
            visited[row][col] = true;
            foreach (var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                if (r < 0 || r >= _grid.Length || c < 0 || c >= _grid[0].Length || visited[r][c] || _grid[r][c] == 0) continue;
                ans.AddRange(helper_R2(r, c));
            }
            return ans;
        }
        public bool isUnique(List<List<int>> island, List<List<List<int>>> islands)
        {
            for (int i = 0; i < islands.Count; i++)
            {
                if (isEqual(island, islands[i])) return false;
            }
            return true;
        }
        public bool isEqual(List<List<int>> island1, List<List<int>> island2)
        {
            if (island1.Count != island2.Count) return false;
            for (int i = 0; i < island1.Count; i++)
            {
                if (island1[i][0] != island2[i][0] || island1[i][1] != island2[i][1]) return false;
            }
            return true;
        }
       
    }
}
