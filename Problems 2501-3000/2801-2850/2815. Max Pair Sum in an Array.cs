using System;
using System.Collections.Generic;

#region Test Data
//var obj2 = new _2815();
//obj2.MaxSum_20230925(new int[] { 51, 71, 17, 24, 42 });
#endregion

namespace leetcode.Problems_2501_3000._2801_2850
{
    internal class _2815
    {
        #region 09/25/2023
        Dictionary<int, (int? first, int? second)> dic = new Dictionary<int, (int? first, int? second)>() { };
        public int MaxSum_20230925(int[] nums)
        {
            int max = -1;
            foreach (var n in nums)
            {
                int key = getMaxNumber(n);
                if (dic.ContainsKey(key)) 
                {
                    if (dic[key].second == null)
                    {
                        if (dic[key].first < n)
                        {
                            dic[key] = (n, dic[key].first);
                        }
                        else
                        {
                            dic[key] = (dic[key].first, n);
                        }
                    }
                    else
                    {
                        if (dic[key].second >= n) continue;
                        if (dic[key].first < n)
                        {
                            dic[key] = (n, dic[key].first);
                        }
                        else
                        {
                            dic[key] = (dic[key].first, n);
                        }

                        
                    }
                    max = Math.Max(max, (int)dic[key].first + (int)dic[key].second);

                }
                else
                {
                    dic.Add(key, (n, null));
                }
                
            }
            return max;
        }
        public int getMaxNumber(int number)
        {
            int max = -1;
            while(number != 0)
            {
                max = Math.Max(number % 10, max);
                number = number / 10;
            }
            return max;
        }
        #endregion
    }
}
