using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0529
    {
        List<List<int>> directions = new List<List<int>>()
        {
                    new List<int>(){ 0,-1},
                new List<int>(){ 0,1},
            new List<int>(){ -1,0},
        new List<int>(){ -1,-1},
             new List<int>(){ -1,1},
             new List<int>(){ 1,0},
             new List<int>(){ 1,-1},
             new List<int>(){ 1,1},
};
        bool[][] visited;
        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            visited = new bool[board.Length][];
            for (int i = 0; i < board[0].Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, board[0].Length).ToArray();
            }

            Queue<(int r, int c)> q = new Queue<(int r, int c)>() { };
            q.Enqueue((click[0], click[1]));
            visited[click[0]][click[1]] = true;

            while (q.Count != 0)
            {
                int size = q.Count;
                while (size > 0)
                {
                    var dir = q.Dequeue();
                    if (board[dir.r][dir.c] == 'M')
                    {
                        board[dir.r][dir.c] = 'X';
                        return board;
                    }
                    else
                    {
                        int cnt = countMine(dir.r, dir.c, board);
                        if (cnt > 0)
                        {
                            board[dir.r][dir.c] = cnt.ToString()[0];
                        }
                        else
                        {
                            board[dir.r][dir.c] = 'B';
                            foreach (var d in directions)
                            {
                                int row = dir.r + d[0];
                                int col = dir.c + d[1];
                                if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || visited[row][col]) continue;

                                visited[row][col] = true;
                                q.Enqueue((row, col));

                            }
                        }
                    }
                    size--;
                }
            }
            return board;
        }

        public int countMine(int r, int c, char[][] board)
        {
            int sum = 0;
            foreach (var dir in directions)
            {
                int row = r + dir[0];
                int col = c + dir[1];
                if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || visited[row][col]) continue;
                if (board[row][col] == 'M') sum++;
            }
            return sum;
        }

    }
}
