﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0246
    {
        #region 07/08/2024
        public bool IsStrobogrammatic(string num)
        {
            int L = num.Length;

            int mid = num.Length / 2 - 1;

            for (int i = 0; i <= mid; i++)
            {
                if (num[i] == '0')
                {
                    if (num[L - i - 1] != '0') return false;
                }
                else if (num[i] == '8')
                {
                    if (num[L - i - 1] != '8') return false;
                }
                else if (num[i] == '1')
                {
                    if (num[L - i - 1] != '1') return false;
                }
                else if (num[i] == '6')
                {
                    if (num[L - i - 1] != '9') return false;
                }
                else if (num[i] == '9')
                {
                    if (num[L - i - 1] != '6') return false;
                }
                else
                {
                    return false;
                }
            }
            if (L % 2 == 1)
            {
                if (num[L / 2] == '0' || num[L / 2] == '8' || num[L / 2] == '1')
                    return true;
                return false;
            }
            else
            {
                return true;
            }



        }
        #endregion

    }
}
