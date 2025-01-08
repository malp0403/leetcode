using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

#region Test
/*
 
            var obj2 = new _1926();
            char[][] maze = new char[3][];
            maze[0] = new char[3] { '+', '+', '+' };
            maze[1] = new char[3] { '.', '.', '.' };
            maze[2] = new char[3] { '+', '+', '+' };

            int[] entrance = new int[2] { 1, 0 };

            var test2 =obj2.NearestExit(maze, entrance);

            char[][] maze2 = new char[1][];
            maze[0] = new char[1] { '.' };
            int[] entrance2 = new int[2] { 0, 0 };
            test2 = obj2.NearestExit(maze2, entrance2);
 */
#endregion

namespace leetcode.Problems_1501_2000
{
    internal class _1926
    {
        List<List<int>> direction = new List<List<int>>()
            {

                new List<int> { 0, 1 },
                                new List<int> { 0, -1 },
                new List<int> { 1, 0 },
                new List<int> { -1, 0 }

        };

        #region 09/28/2024
        public int NearestExit(char[][] maze, int[] entrance)
        {
            List<List<int>> direction_2024_09_28 = new List<List<int>>()
            {

                new List<int> { 0, 1 },
                                new List<int> { 0, -1 },
                new List<int> { 1, 0 },
                new List<int> { -1, 0 }

            };


            Queue<(int x, int y)> q = new Queue<(int x, int y)>();
            HashSet<(int x, int y)> visited = new HashSet<(int x, int y)>();
            q.Enqueue((entrance[0], entrance[1]));
            visited.Add((entrance[0], entrance[1]));
            int distance = 0;

            while (q.Count > 0)
            {
                int count = q.Count;
                distance++;
                while (count > 0)
                {
                    var element = q.Dequeue();

                    foreach (var i in direction_2024_09_28)
                    {

                        int x = i[0] + element.x;
                        int y = i[1] + element.y;

                        if (x < 0 || y < 0 || x >= maze.Length || y >= maze[0].Length || maze[x][y] == '+' || visited.Contains((x, y))) continue;
                        if (x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1) return count;

                        visited.Add((x, y));
                        q.Enqueue((x, y));

                    }
                    count--;


                }

            }

            return -1;


        }
        #endregion
    }
}
