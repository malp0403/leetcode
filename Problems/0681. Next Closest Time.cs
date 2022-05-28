using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0681
    {
        public string NextClosestTime(string time)
        {
            var sep = time.Split(":");
            var h = sep[0];
            var min = sep[1];
            List<string> list = new List<string>() { };
            //all the digit;
            for(int i =0; i < time.Length; i++)
            {
                if (i != 2 && !list.Contains(time[i].ToString()))
                {
                    list.Add(time[i].ToString());
                }
            }
            //all the nums;
            List<int> list2 = new List<int>() { };
            for(int i=0; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    var temp = int.Parse(list[i] + list[j]);
                    if (!list2.Contains(temp))
                    {
                        list2.Add(temp);
                    }
                }
            }
            list2.Sort();
            //check min
            List<int> mins = new List<int>() { };
            List<int> hs = new List<int>() { };


            for(int i=0; i < list2.Count; i++)
            {
                if( list2[i]>=0 && list2[i]<=59)
                {
                    if (!mins.Contains(list2[i]))
                    {                       
                        mins.Add(list2[i]);
                    }
                }
                if (list2[i] >= 0 && list2[i] <= 23)
                {
                    if (!hs.Contains(list2[i]))
                    {
                        hs.Add(list2[i]);
                    }
                }
            }
            mins.Sort();
            hs.Sort();

            //has larger minutes;
            var minIndx = mins.FindIndex(x => x > int.Parse(min));
            if(minIndx != -1)
            {
                return h + ":" + formate(mins[minIndx]);
            }
            else
            {
                var hIndx = hs.FindIndex(x => x > int.Parse(h));
                if (hIndx != -1)
                {
                    return formate(hs[hIndx]) + ":" + formate(mins[0]);
                }
                else
                {
                    return formate(hs[0]) + ":" + formate(mins[0]);
                }
            }
            return null;
        }

        public string formate(int i)
        {
            if (i == 0)
            {
                return "00";
            }
            else if( i>0 && i < 10)
            {
                return "0" + i.ToString();
            }
            return i.ToString();
        }
    }
}
