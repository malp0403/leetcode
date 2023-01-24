using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_0001_500._0151_0200
{
    class _0166
    {
        #region LeetCode Solution1
        public string FractionToDecimal(int numerator, int denominator)
        {
            StringBuilder sb = new StringBuilder() { };
            // if denominator is 0-> invalid
            if (denominator == 0) return "";
            //if numerator is 0 -> 0
            if (numerator == 0) return "0";

            if (numerator < 0 ^ denominator < 0)
            {
                sb.Append('-');
            }

            long divided = Math.Abs((long)numerator);
            long divisor = Math.Abs((long)denominator);
            sb.Append(divided / divisor);

            long reminder = divided % divisor;
            if (reminder == 0) return sb.ToString();

            sb.Append(".");
            Dictionary<long, int> map = new Dictionary<long, int>() { };
            while (reminder != 0)
            {
                if (map.ContainsKey(reminder))
                {
                    sb.Insert(map[reminder], "(");
                    sb.Append(")");
                    break;
                }
                map.Add(reminder, sb.Length);
                reminder *= 10;
                sb.Append(reminder / divisor);
                reminder %= divisor;
            }

            return sb.ToString();

        }

        #endregion

        #region 12/30/2022
        public string FractionToDecimal_20221230(int n, int d)
        {
            if (n == 0) return "0";
            if (d == 0) return "";
            bool neg = (n < 0) ^ (d < 0);

            long divided = Math.Abs((long)n);
            long divisor = Math.Abs((long)(d));

            StringBuilder sb = new StringBuilder() { };
            if (neg)
            {
                sb.Append('-');
            }

            sb.Append(divided / divisor);
            long reminder = divided % divisor;
            if (reminder == 0) return sb.ToString();

            sb.Append(".");
            Dictionary<long, int> map = new Dictionary<long, int>() { };
            while (reminder != 0)
            {
                if (map.ContainsKey(reminder))
                {
                    sb.Insert(map[reminder], "(");
                    sb.Append(")");
                    return sb.ToString();
                }
                map.Add(reminder, sb.Length);
                reminder *= 10;

                sb.Append(reminder / divisor);

                reminder %= divisor;
            }
            return sb.ToString();
        }
        #endregion
    }
}
