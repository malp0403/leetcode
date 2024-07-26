using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0301
    {
        #region 07/22/2024
        HashSet<string> answer_20240722;
        public IList<string> RemoveInvalidParentheses_2024_07_22(string s)
        {
            Stack<string> sta = new Stack<string>();
            answer_20240722 = new HashSet<string>();
            int extraOpen = 0;
            int extraClose = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == '(')
                {
                    sta.Push("(");
                }else if (s[i] == ')')
                {
                    if (sta.Count > 0)
                    {
                        sta.Pop();
                    }
                    else
                    {
                        extraClose++;
                    }
                }
                i++;
            }
            extraOpen = sta.Count;

            helper_2024_07_22(0, s, "", 0, extraOpen, extraClose);
            return answer_20240722.ToList();
        }
        public void helper_2024_07_22(int i,string s, string str,int extraLeft,int invalidOpen,int invalidClose)
        {
            if(i == s.Length)
            {
                if(extraLeft ==0 && invalidOpen==0 && invalidClose == 0)
                {
                    answer_20240722.Add(str);
                }
                return;
            }

            if (s[i] == '(')
            {
                if(invalidOpen > 0)
                {
                    helper_2024_07_22(i + 1, s,str, extraLeft, invalidOpen - 1, invalidClose);
                }
                helper_2024_07_22(i + 1, s,str + "(", extraLeft + 1, invalidOpen, invalidClose);
            }else if (s[i] == ')')
            {
                if (invalidClose > 0)
                {
                    helper_2024_07_22(i + 1, s, str, extraLeft, invalidOpen, invalidClose-1);
                }
                if (extraLeft == 0) return;
                helper_2024_07_22(i + 1, s, str + ")", extraLeft -1, invalidOpen, invalidClose);
            }
            else
            {
                helper_2024_07_22(i + 1, s, str + s[i].ToString(), extraLeft, invalidOpen, invalidClose);

            }
        }

        #endregion


    }
}
