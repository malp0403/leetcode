using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _63
    {
        public int UniquePathsWithObstacles(int[][] ob)
        {
            if (ob[0][0] == 1) return 0;
            int len = ob.Length;
            int rowLen = ob[0].Length;
            if (len == 1)
            {
                if (Array.IndexOf(ob[0], 1) > -1) return 0;
                else return 1;
            }
            else if (rowLen == 1) {
                for (int i = 0; i < len; i++){
                    if (ob[i][0] == 1) return 0;
                }
                return 1;
            }

            int[][] result = new int[len][];
            bool firstColob = false;
            for (int i = 0; i < len; i++) {
                var temp = new int[rowLen];
                if (i == 0) Array.Fill(temp, 1);
                else Array.Fill(temp, 0);
                if (ob[i][0] == 1) firstColob = true;
                temp[0] = !firstColob?1:0;
                result[i] = temp;
            }

            int firstRowOb = Array.IndexOf(ob[0], 1);
            if (firstRowOb > -1) {
                for (int i = firstRowOb; i < rowLen; i++) {
                    result[0][i] = 0;
                }
            }

            for (int i = 1; i < len; i++) {
                for (int j = 1; j < rowLen; j++) {
                    if ( ob[i][j] == 1) result[i][j] = 0;
                    else {
                        result[i][j] = result[i - 1][j] + result[i][j - 1];
                    }
                }
            }

            return result[len - 1][rowLen - 1];






































            //if (obstacleGrid[0][0] == 1) return 0;
            //int len = obstacleGrid.Length;
            //int rowlen = obstacleGrid[0].Length;
            //if (obstacleGrid.Length == 1) {
            //    if(Array.IndexOf(obstacleGrid[0], 1) > -1) return 0;
            //    return 1;
            //} 
            //else if (rowlen == 1) {
            //    for (int test = 0; test < len; test++) {
            //        if (obstacleGrid[test][0] == 1) return 0;
            //    }
            //    return 1;
            //}

            //int[][] result = new int[len][];
            //int i = 0;
            //while (i < len) {
            //    if (i == 0)
            //    {
            //        int[] temp = new int[rowlen];
            //        int block = Array.IndexOf(obstacleGrid, 1);
            //        if (block > -1) {
            //            for (int t = 0; t < temp.Length; t++)
            //            {
            //                if ( t > block)
            //                {
            //                    temp[t] = t < block?1:0;
            //                }
            //            }
            //        }
            //        else {
            //            for (int t = 0; t < temp.Length; t++)
            //            {
            //                    temp[t] = 1;
            //            }
            //        }

            //        result[i] = temp;
            //    }
            //    else {
            //        int[] temp2 = new int[rowlen];
            //        if (obstacleGrid[i][0] == 1) {
            //            temp2[0] = 1;
            //        }
            //        result[i] = temp2;
            //    }
            //    i++;
            //}
          
  

            //for (int x = 1; x < len; x++) {
            //    for (int y = 1; y < rowlen; y++) {
            //        if (obstacleGrid[x][y] == 1)
            //        {
            //            result[x][y] = 0;
            //        }
            //        else {
            //            result[x][y] = result[x][y - 1] + result[x - 1][y];
            //        }
            //    }
            //}
            //return result[len - 1][rowlen - 1];
        }
    }
}
