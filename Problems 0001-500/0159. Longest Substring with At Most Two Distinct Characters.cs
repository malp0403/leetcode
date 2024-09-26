using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0159
    {
        #region 03/29/2024 records the last index
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int l = 0;
            int r = 0;
            int maxLengh = 0;
            while(r < s.Length)
            {
                if (!dic.ContainsKey(s[r]))
                {
                    if (dic.Keys.Count >= 2)
                    { 
                        int minLen = s.Length;
                        char toRemoveKey = ' ';
                        foreach (var item in dic.Keys)
                        {
                            if (dic[item] <= minLen)
                            {
                                minLen = dic[item];
                                toRemoveKey = item;
                            }
                        }
                        l = minLen + 1;
                        dic.Remove(toRemoveKey);
                      
                    }

                    dic.Add(s[r], r);
                }
                else
                {
                    dic[s[r]] = r;
                }



                //if (dic.ContainsKey(s[r]))
                //{
                //    dic[s[r]]++;
                //}
                //else
                //{
                //    if(dic.Keys.Count < 2)
                //    {
                //        dic.Add(s[r], 1);
                //    }
                //    else
                //    {
                //        while(dic.Keys.Count >=2 && l < r)
                //        {
                //            dic[s[l]]--;
                //            if (dic[s[l]] == 0)
                //            {
                //                dic.Remove(s[l]);
                //            }
                //            l++;
                //        }
                //        dic.Add(s[r], 1);
                //    }
                //}
                maxLengh = Math.Max(maxLengh, r - l + 1);

                r++;


            }

            return maxLengh;
        }
        #endregion
    }
}
