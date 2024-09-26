using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0168
    {
        #region 08/13/2023
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();
    

            while(columnNumber  > 0)
            {
                columnNumber--;


                sb.Append((char)('A' + columnNumber % 26));
                columnNumber = columnNumber / 26;

            }
            return new string(sb.ToString().Reverse().ToArray());

        }
        #endregion

        #region 04/15/2024
        public string ConvertToTitle_2024_04_15(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();
            while(columnNumber > 0)
            {
                columnNumber--;
                sb.Append((char)('A' + columnNumber % 26));
                columnNumber = columnNumber / 26;
            }
            return new string(sb.ToString().Reverse().ToArray());
        }

            #endregion
        }
    }
