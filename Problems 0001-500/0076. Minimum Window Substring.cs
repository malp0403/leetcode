﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0076
    {
        #region answer
        public string MinWindow(string s, string t)
        {
            int[] arr = Enumerable.Repeat(0, 128).ToArray();
            foreach (var c in t)
            {
                arr[c]++;
            }
            int l = 0;
            int r = 0;
            int min = Int16.MaxValue;
            int count = t.Length;
            int minL = 0;
            int minR = -1;
            while (r < s.Length)
            {
                arr[s[r]]--;
                if(arr[s[r]] >= 0)
                {
                    count--;
                }
                while(count == 0)
                {
                    int len = r - l + 1;
                    if(len < min)
                    {
                        minL = l;
                        minR = r;
                        min = len;
                    }
                    arr[s[l]]++;
                    if (arr[s[l]] > 0)
                    {
                        count++;
                    }
                    l++;
                }
                r++;
            }

            return minR - minL + 1==0?"":s.Substring(minL, minR - minL + 1);
        }
        #endregion

        #region 08/09/2022
        Dictionary<char, int> dic = new Dictionary<char, int>() { };
        //public string MinWindow_20220809(string s, string t)
        //{
        //    if (t.Length > s.Length) return "";
        //    string res = "";
        //    foreach (var ch in t)
        //    {
        //        if (dic.ContainsKey(ch)) dic[ch]++;
        //        else
        //        {
        //            dic.Add(ch, 1);
        //        }
        //    }

        //    int start = 0;
        //    int end = 0;
        //    while (end < s.Length)
        //    {
        //        if (dic.ContainsKey(s[end]))
        //        {
        //            dic[s[end]]--;
        //            if (dic[s[end]] == 0)
        //            {
        //                //calculate

        //            }
        //        }
        //        end++;
        //    }


        //}

        //public int helper(int start, int end)
        //{
        //    for
        //    string str = "";
        //    while (start < end)
        //        {

        //        }
        //}
        #endregion

        #region 03/09/2024
        public string MinWindow_2024_03_09(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var item in t)
            {
                if (dic.ContainsKey(item)) dic[item]++;
                else dic.Add(item, 1);
            }

            int start = 0;
            int end = 0;
            string result= null;
            while(end < s.Length)
            {
                if (dic.ContainsKey(s[end])){
                    dic[s[end]]--;

                    if (isValid(dic))
                    {
                        while( start <= end && (!dic.ContainsKey(s[start]) || dic[s[start]] < 0))
                        {
                            if (dic.ContainsKey(s[start])) dic[s[start]]++;

                            start++;
                        }
                        string temp = s.Substring(start, end - start + 1);
                        if (result == null || result.Length > temp.Length) {
                            result = temp;
                        }
                    }
                    
                }

                end++;
            }

            return result == null ? "" : result;


        }

        public bool isValid(Dictionary<char, int> dic)
        {
            foreach (var item in dic.Keys)
            {
                if (dic[item] > 0) return false;
            }
            return true;
        }
        #endregion

    }
}
