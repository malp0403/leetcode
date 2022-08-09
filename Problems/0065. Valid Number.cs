using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0065
    {
        #region answer
        public bool IsNumber(string s)
        {
            bool isDigitSeen = false;
            bool isExponentSeen = false;
            bool isDotSeen = false;
            for(int i =0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    isDigitSeen = true;
                }
                else if( s[i] =='e' || s[i] == 'E')
                {
                    if (!isDigitSeen || isExponentSeen) return false;
                    isExponentSeen = true;
                    isDigitSeen = false;
                }else if(s[i] =='+' || s[i] == '-')
                {
                    if(i>0 && s[i-1] !='e' && s[i-1] != 'E')
                    {
                        return false;
                    }
                }else if(s[i] == '.')
                {
                    if(isDotSeen || isExponentSeen)
                    {
                        return false;
                    }
                    isDotSeen = true;
                }
                else
                {
                    return false;
                }
            }
            return isDigitSeen;
        }
        #endregion
        #region 08/08/2022
        public bool IsNumber_20220808(string s)
        {
            bool isDecimalAllow = true;
            bool isDotappear = false;
            bool isPlusallow = true;
            bool isEallow = true;
            for (int i = 0; i < s.Length; i++)
            {
                char key = s[i];
                if (key == '-' || key == '+')
                {
                    if (!isPlusallow) return false;
                    if (i + 1 >= s.Length)
                    {
                        return false;
                    }
                    else
                    {
                        if (!char.IsDigit(s[i + 1]))
                        {
                            if (s[i + 1] == '.') continue;
                            return false;
                        }
                    }
                }
                else if (key == 'e' || key == 'E')
                {
                    if (!isEallow) return false;
                    isEallow = false;
                    isDecimalAllow = false;
                    isPlusallow = true;
                    if (i + 1 >= s.Length)
                    {
                        return false;
                    }
                    else if (i + 1 < s.Length)
                    {
                        if (s[i + 1] != '-' && s[i + 1] != '+' && !char.IsDigit(s[i + 1]))
                        {
                            return false;
                        };
                    }
                    if (i - 1 < 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (s[i - 1] == '.')
                        {
                            if (i - 2 < 0 || !char.IsDigit(s[i - 2]))
                            {
                                return false;
                            }
                        }
                    }
                }
                else if (key == '.')
                {
                    if (isDotappear) return false;
                    isDotappear = true;
                    if (!isDecimalAllow) return false;
                    bool hasLeftDigit = i - 1 >= 0 && char.IsDigit(s[i - 1]);
                    bool hasRightDigit = i + 1 < s.Length && char.IsDigit(s[i + 1]);
                    if (!hasLeftDigit && !hasRightDigit)
                    {
                        return false;
                    }
                    if (i + 1 < s.Length && !char.IsDigit(s[i + 1]))
                    {
                        if (s[i + 1] == 'e' || s[i + 1] == 'E')
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    };

                }
                else if (!char.IsDigit(key))
                {
                    return false;
                }
                else if (char.IsDigit(key))
                {
                    isPlusallow = false;
                }
            }
            return true;
        }
        #endregion
    }
}
