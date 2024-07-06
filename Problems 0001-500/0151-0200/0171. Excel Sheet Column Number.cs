using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0171
    {
        #region 08/14/2023
        public int TitleToNumber_08142023(string columnTitle)
        {
            int total = 0;
            int index = 0;
            while(index< columnTitle.Length)
            {
                char a = columnTitle[index];
                int temp = a - 'A' + 1;
                total = total * 26 + temp;
                index++;
            }
            return total;


        }
        #endregion

        #region 04/15/2024
        public int TitleToNumber_2024_08_14(string columnTitle)
        {
            int total = 0;
           
            int p = 0;
            while(p<columnTitle.Length)
            {
                total = total * 26 + columnTitle[p] - 'A' + 1;

                p++;
            }
            return total;
        }
            #endregion
        }
    }
