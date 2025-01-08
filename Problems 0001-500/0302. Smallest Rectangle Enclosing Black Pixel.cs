using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0302
    {

        #region 07/22/2024
        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;
        List<List<int>> dir;
        public int MinArea_2024_07_22(char[][] image, int x, int y)
        {
            dir = new List<List<int>>() {
                    new List<int>(){1,0},
                        new    List<int>(){-1,0},
                   new  List<int>(){0,1},
                    new List<int>(){0,-1}
                    };
            up = x; down = x;
            left = y; right = y;
            image[x][y] = '0';
            helper_2024_07_22(x, y, image);
            return (down - up + 1) * (right - left + 1);

        }
        public void helper_2024_07_22(int x, int y, char[][] image)
        {

            up = Math.Min(up, x);
            down = Math.Max(down, x);
            left = Math.Min(left, y);
            right = Math.Max(right, y);

            foreach (var item in dir)
            {
                int r = x + item[0];
                int c = y + item[1];
                if (r < 0 || r >= image.Length || c < 0 || c >= image[0].Length) continue;
                if (image[r][c] == '0') continue;
                image[r][c] = '0';
                helper_2024_07_22(r, c, image);
            }
        }

        #endregion


    }
}
