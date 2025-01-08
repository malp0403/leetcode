using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
             Dictionary<char,int> dic = new Dictionary<char, int>();
            dic.Add('b', 0);
            dic.Add('a', 0);
            dic.Add('l', 0);
            dic.Add('0', 0);
            dic.Add('n', 0);



            foreach (char c in text)
            {
                if (c == 'b' || c == 'a' || c == 'l' || c == '0' || c == 'n')
                {
                    dic[c]++;
                }
            }
            int answer = int.MaxValue;
            foreach (var k in dic.Keys)
            {
                if(k == 'b' || k == 'a' ||  k== 'n')
                {
                    answer = Math.Min(answer, dic[k]);
                }
                else
                {
                    answer = Math.Min(answer, dic[k] / 2);
                }
            }
            return answer != int.MinValue ? answer : 0;
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1185
    {
        #region 11/05/2023
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateTime t = new DateTime(year, month, day);
            return t.DayOfWeek.ToString();

        }
        #endregion
    }
}
