using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0251
    {
        #region 07/08/2024
        int row = 0;
        int column = 0;
        int[][] _vec;
        public _0251(int[][] vec)
        {
            _vec = vec;
            while (row < _vec.Length && _vec[row].Length == 0)
            {
                row++;
            }
        }

        public int Next()
        {
            int number = _vec[row][column];

            if(column == _vec[row].Length-1)
            {
                row++;
               while(row < _vec.Length && _vec[row].Length == 0)
                {
                    row++;
                }
                column = 0;
            }
            else
            {
                column++;
            }
            return number;
        }

        public bool HasNext()
        {
            if (row >= _vec.Length) return false;
            return true;
        }
        #endregion
    }
}
