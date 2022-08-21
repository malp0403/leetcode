using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0616
    {
        public string AddBoldTag(string s, string[] words)
        {
            List<List<int>> li = new List<List<int>>() { };
            int startInd;
            foreach(var word in words){
                startInd = 0;
                while (startInd < s.Length && s.IndexOf(word, startInd) != -1)
                {
                    int i = s.IndexOf(word, startInd);
                    li.Add(new List<int>() { i, word.Length - 1 });
                    startInd = startInd + word.Length;
                }
            }
            //no word found
            if (li.Count == 0) return s;

            li.Sort((a, b) => a[0] - b[0]);
            List<List<int>> li2 = new List<List<int>>() { };
            List<int> pre =null;

            for(int i =0; i < li.Count; i++)
            {
                if(pre == null)
                {
                    pre = li[i];
                }
                else
                {
                    if(pre[1] < li[i][0]) {
                        li.Add(pre);
                        if(i == li.Count - 1)
                        {
                            li.Add(li[li.Count - 1]);
                        }
                        continue; 
                    }
                    pre = new List<int>{ Math.Min(li[i][0], pre[0]), Math.Max(li[i][1], pre[1]) };
                }
            }



            return null;
        }
    }
}
