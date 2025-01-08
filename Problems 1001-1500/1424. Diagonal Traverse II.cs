using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1424
    {
        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            List<List<int>> directions = new List<List<int>>()
            {
                new List<int>(){ 1,0},
                new List<int>(){0,1}
            };
            HashSet<string> visited = new HashSet<string>() { };
            Queue<List<int>> q = new Queue<List<int>>() { };
            q.Enqueue(new List<int>() { 0, 0 });
            List<int> output = new List<int>() { };
            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                output.Add( nums[cur[0]][cur[1]] );

                foreach (var dir in directions)
                {
                    int i = cur[0] + dir[0];
                    int j = cur[1] + dir[1];
                    if (i < nums.Count && j < nums[i].Count && !visited.Contains(i + " " + j))
                    {
                        q.Enqueue(new List<int>() { i,j});
                        visited.Add(i + " " + j);
                    }
                }
            }

            return output.ToArray();
          
        }
    }
}
