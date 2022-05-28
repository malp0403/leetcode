using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _267
    {
        public IList<string> GeneratePalindromes(string s)
        {
            List<string> res = new List<string>() { };
            if (s.Length == 0) return res;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            List<char> remains = new List<char>() { };
            char? unique =null;
            foreach (char c in s) {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                    dic[c]++;
                if (dic[c] % 2 == 0) {
                    remains.Add(c);
                }
            }
            int count = 0;
            foreach (var (key, value) in dic) {
                if (value % 2 == 1) {
                    count++;
                    unique = key;
                }
                if (count >= 2) break;
            }
            if (count >= 2) return res;


            Stack<char> stac = new Stack<char>() { };
            insertNew(res, stac, remains, 0, unique);
            return res;
        }

        public void insertNew(List<string> res, Stack<char> s, List<char> remains,int curIndex,char? unique =null) {
            if (remains.Count == 0) {
                var l = s.ToList();
                var temp = String.Join("", l);
                l.Reverse();
                var temp2 = String.Join("", l);
                res.Add(temp + (unique != null? unique.ToString() : "") + temp2);
                return;
            }
            HashSet<char> set = new HashSet<char>() { };
            for (int i = 0; i < remains.Count;) {
                if (!set.Contains(remains[i])){
                    s.Push(remains[i]);
                    var temp = new List<char>(remains);
                    temp.RemoveAt(i);
                    insertNew(res, s, temp, curIndex, unique);
                    s.Pop();
                }
                set.Add(remains[i]);
                i++;
            }
        }
    }
}
