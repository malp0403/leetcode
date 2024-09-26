using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj = new _0792() { };

//obj.NumMatchingSubseq("abcde", new string[] { "a", "bb", "acd", "ace" });
//obj.NumMatchingSubseq("dsahjpjauf", new string[] { "ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax" });
#endregion
namespace leetcode.Problems_0501_1000._0751_0800
{
    public class _0792
    {
        #region 09/18/2023

        public int NumMatchingSubseq_20230918(string s, string[] words)
        {
            int answer = 0;
           List<_792Node>[] head = new List<_792Node>[26];
            for(int i =0;i<26; i++)
            {
                head[i] = new List<_792Node>();
            }

            foreach (var item in words)
            {
                head[item[0] - 'a'].Add(new _792Node(item, 0));
            }

            foreach (var c in s.ToArray())
            {
                List<_792Node> list = head[c - 'a'];
                head[c - 'a'] = new List<_792Node>() { };

                foreach (_792Node item in list)
                {
                    item.index++;
                    if(item.index == item.s.Length)
                    {
                        answer++;
                    }
                    else
                    {
                        head[item.s[item.index] - 'c'].Add(item);
                    }

                }
                list.Clear();

            }
            return answer;

        }


        #endregion
    }
    public class _792Node
    {
        public string s;
        public int index;
        public _792Node(string s,int index)
        {
            this.s = s;
            this.index = index;
        }
    }
}
