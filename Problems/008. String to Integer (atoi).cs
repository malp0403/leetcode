using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _008
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            if (s.Length == 0) return 0;
            char c = s[0];
            if (!char.IsDigit(c) && (c != '-' && c != '+')) return 0;
            else
            {
                if (c == '-' || c == '+')
                {
                    if (s.Length == 1) return 0;
                    if (!char.IsDigit(s[1])) return 0;
                    int i = 1;
                    long res = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        res = (Int64.Parse(s[i].ToString()) + res * 10);
                        i++;
                        if (c == '-')
                        {
                            if ((0 - res) < Int32.MinValue)
                            {
                                res = Int32.MinValue;
                                break;
                            }
                        }
                        if (c == '+')
                        {
                            if ((res) > Int32.MaxValue)
                            {
                                res = Int32.MaxValue;
                                break;
                            }
                        }

                    }

                    return c != '-' ? (int)res : (int)(0 - res);
                }
                else
                {
                    int i = 0;
                    long res = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        res = (Int64.Parse(s[i].ToString()) + res * 10);
                        i++;
                        if (res > Int32.MaxValue)
                        {
                            res = Int32.MaxValue;
                            break;
                        }
                    }
                    return (int)res;
                }
            }
        }
    }
}
