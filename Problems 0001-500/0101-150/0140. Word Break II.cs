using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0140
    {
        #region 03/26/2024

        IList<string> list_2024_03_26;
        string s_2024_03_26;
        Dictionary<int, bool> dic_2024_03_26;
        IList<string> res_2024_03_26;
        public IList<string> WordBreak_2024_03_26(string s, IList<string> wordDict)
        {
            res_2024_03_26= new List<string>();
            list_2024_03_26 = wordDict;
            s_2024_03_26 = s;
            dic_2024_03_26 = new Dictionary<int, bool>();
            helper_2024_03_26(0,new List<string>() { });

            return res_2024_03_26;
        }

        public bool helper_2024_03_26(int index,List<string> cur)
        {
            if (index == s_2024_03_26.Length) {
                res_2024_03_26.Add(string.Join(" ",cur));
                return true;
            } 


            bool valid = false;
            for (int len = 1; len + index <= s_2024_03_26.Length; len++)
            {
                string temp = s_2024_03_26.Substring(index, len);
                if (list_2024_03_26.Contains(temp))
                {
                    cur.Add(temp);
                    valid =  helper_2024_03_26(index + len, cur) || valid;
                    cur.RemoveAt(cur.Count - 1);
                }
            }
            return valid;
        }
        #endregion
    }
}
