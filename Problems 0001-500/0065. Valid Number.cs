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

        #region 02/29/2024
        public bool IsNumber_2024_02_29(string s)
        {
            if (s.Length == 0) return false;
            //whether contains letter beside e,E
            foreach (char c in s)
            {
                if (char.IsLetter(c) && (c !='e' || c!='E')) return false;              
            }
            s = s.ToLower();
            var arrs = s.Split('e');
            if (arrs.Length > 2) return false;
            if(arrs.Length == 2)
            {
                return helper_handle_Spec(arrs[0], false) && helper_handle_Spec(arrs[1], true);
            }
            else 
            {
                return helper_handle_Spec(arrs[0], false);
            }
        }

        public bool helper_handle_Spec(string s,bool mustInt)
        {
           
            var negIndex = s.IndexOf('-');
            var posIndex = s.IndexOf('+');
            if (negIndex != -1 && negIndex != 0) return false;
            if (posIndex != -1 && posIndex != 0) return false;
            if (negIndex != -1 && posIndex != -1) return false;

            if(negIndex != -1)
            {
                s = s.Substring(1);
            }
            else if (posIndex != -1)
            {
                s = s.Substring(1);
            }

            var arrs = s.Split('.');
            if (arrs.Length > 2) return false;

            if (arrs.Length == 2 && mustInt) return false;

            if (arrs.Length == 2)
            {
                if (mustInt) return false;

            }
            

            return false;
        }

        public bool helper_handled_number(string s,bool canEmpty)
        {
            if (s.Length == 0 && !canEmpty) return false;

            foreach(char c in s)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }
        #endregion
    }
}
