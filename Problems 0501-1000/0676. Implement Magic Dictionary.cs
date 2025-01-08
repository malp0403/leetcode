using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0676
    {
        Dictionary<int, List<string>> dic;
        public _0676()
        {
            dic = new Dictionary<int, List<string>>() { };


        }

        public void BuildDict(string[] dictionary)
        {
            foreach (var s in dictionary)
            {
                int key = s.Length;
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(s);
                }
                else
                {
                    dic.Add(key, new List<string>() { s });
                }
            }
        }

        public bool Search(string searchWord)
        {
            int key = searchWord.Length;
            bool exists = false;
            if (dic.ContainsKey(key))
            {
                for(int i=0; i < dic[key].Count; i++)
                {
                    string target = dic[key][i];
                    int count = 1;
                    for(int j=0; j < target.Length; j++)
                    {
                        if (target[j] != searchWord[j]) {
                            count--;
                        } 
                        if (count < 0) break;
                    }
                    if(count == 0)
                    {
                        exists = true;
                        break;
                    }
                }

            }

            return exists;
        }
    }
}
