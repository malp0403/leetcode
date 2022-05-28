using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class _76
    {
        //public string MinWindow(string s, string t)
        //{
        //    if (s == "" || t == "" || t.Length > s.Length) return "";
        //    if (s == t) return s;
        //    int l = 0;
        //    int r = 0;
        //    int len = s.Length;
        //    int start = 0;
        //    bool isFind = false;
        //    Dictionary<char, int> dic = new Dictionary<char, int>() { };
        //    foreach (char c in t) {
        //        if (dic.ContainsKey(c)) { dic[c]++; }
        //        else dic.Add(c, 1);
        //    }

        //    while (r < s.Length) {
        //        string temp;
        //        if (!isALLContained(s.Substring(l, r - l + 1), dic)) { r++; }
        //        else
        //        {
        //            isFind = true;
        //            while (isALLContained(s.Substring(l, r - l + 1), dic)) {
        //                if (r - l + 1 < len)
        //                {
        //                    len = r - l + 1;
        //                    start = l;
        //                } 
        //                l++;
        //            }
        //        }
        //    }
        //    if (!isFind) return "";
        //    return s.Substring(start, len);


        //}
        //public Boolean isALLContained(string s, Dictionary<char, int> dic) {
        //    Dictionary<char, int> dic2 = new Dictionary<char, int>(dic);
        //    for (int i = 0; i < s.Length; i++) {
        //        if (dic2.ContainsKey(s[i])) {
        //            dic2[s[i]]--;
        //        }
        //    }
        //    foreach (int v in dic2.Values) {
        //        if (v > 0) return false;
        //    }
        //    return true;
        //}

    }
}
