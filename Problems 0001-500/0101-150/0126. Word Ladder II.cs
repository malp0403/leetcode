using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0126
    {
        #region MyRegion
        IList<IList<string>> answer;
        IList<string> wordList;
        Dictionary<string, List<string>> dic;
        int maxLen = int.MaxValue;
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            answer = new List<IList<string>>();
            this.wordList = wordList;
            dic = new Dictionary<string, List<string>>();

            if (!wordList.Contains(endWord)) return answer;


            foreach (var item in wordList)
            {
                bfs(item);
            }

            if (!wordList.Contains(beginWord))
            {
                bfs(beginWord);
            }

            helper(beginWord, endWord, new HashSet<string>(), new List<string>());


            return answer;




        }

        public void bfs(string s)
        {
            dic.Add(s, new List<string>());

            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 'a'; j <= 'z'; j++)
                {
                    if (chars[i] != (char)j)
                    {
                        char temp = chars[i];
                        chars[i] = (char)j;
                        string newStr = new string(chars);
                        if (wordList.Contains(newStr))
                        {
                            dic[s].Add(newStr);

                        }
                        chars[i] = temp;
                    }
                }
            }
        }

        public void helper(string cur, string EWord, HashSet<string> visited, List<string> list)
        {

            list.Add(cur);
            if (cur == EWord)
            {

            }
            else
            {

            }

            List<string> neighbors = dic[cur];


            foreach (var item in neighbors)
            {
                if(visited.Contains(item)) continue;

                visited.Add(item);
                list.Add(item);

                if(item == EWord)
                {
                    
                    if(list.Count < maxLen)
                    {
                      
                            answer = new List<IList<string>>
                            {
                                new List<string>(list)
                            };
                       
                        maxLen = list.Count;
                    }
                    else
                    {
                        answer.Add(new List<string>(list));

                    }
                }
                else
                {
                    helper(item, EWord, visited, list);
                }

                list.RemoveAt(list.Count-1);
                visited.Remove(item);

            }

            list.RemoveAt(list.Count - 1);
        }
        #endregion
    }
}
