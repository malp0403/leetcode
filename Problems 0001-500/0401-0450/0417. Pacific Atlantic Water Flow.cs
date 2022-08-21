using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

namespace leetcode.Problems
{
    class _0417
    {
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
            j = 0 ;
            while (j < _heights[0].Length)
            {
                Search(_heights.Length-1, j, _heights[_heights.Length - 1][j], Atlantic);
                j++;
            }
            i = 0;
            while (i < _heights.Length)
            {
                Search(i, _heights[0].Length-1, _heights[i][_heights[0].Length - 1], Atlantic);
                i++;
            }

            for(int z = 0; z < Pacific.Length; z++)
            {
                for(int y=0; y < Pacific[0].Length; y++)
                {
                    if(Pacific[z][y] == true && Atlantic[z][y] == true)
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
            foreach(var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                Search(r, c, _heights[row][col], visited);
            }
        }

    }
}
