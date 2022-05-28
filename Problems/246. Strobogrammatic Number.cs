using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _246
    {
        public bool IsStrobogrammatic(string num)
        {
            int l = 0;
            int r = num.Length - 1;
            while (l <= r)
            {
                if (l == r)
                {
                    if (num[l] != '1' && num[l] != '8' && num[l] != '0') return false;
                    break;
                }
                else if (num[l] == '6' && num[r] == '9') { l++; r--; }
                else if (num[l] == '9' && num[r] == '6') { l++; r--; }
                else if (num[l] == '1' && num[r] == '1') { l++; r--; }
                else if (num[l] == '8' && num[r] == '8') { l++; r--; }
                else if (num[l] == '0' && num[r] == '0') { l++; r--; }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
