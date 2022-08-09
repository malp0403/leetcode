using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0068
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> answer = new List<string>() { };
            int total = 0;
            int start = 0;
            int spaceCount = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (total + words[i].Length +spaceCount+1> maxWidth)
                {
                    answer.Add(helper(words, start, i - 1, maxWidth, false, total));
                    start = i;
                    total = words[i].Length;
                    spaceCount = 0;
                }
                else
                {
                    total += words[i].Length;
                    spaceCount++;
                }

                if (i == words.Length - 1)
                {
                    answer.Add(helper(words, start, words.Length - 1, maxWidth, true, total));
                }

            }
            return answer;
        }
        public string helper(string[] words, int start, int end, int maxWidth, bool isLastLine, int total)
        {
            StringBuilder sb = new StringBuilder() { };
            if (!isLastLine)
            {
                if (start == end)
                {
                    sb.Append(words[start]);
                    int i = words[start].Length;
                    while (i < maxWidth)
                    {
                        sb.Append(' ');
                        i++;
                    }
                }
                else
                {
                    int spacePerWord = (maxWidth - total) / (end - start) +
                        ((maxWidth - total) % (end - start) >= 1 ? 1 : 0 );
                    int cur = maxWidth - total;
                    int count = 0;
                    for (int i = start; i <= end; i++)
                    {
                        sb.Append(words[i]);

                        if (cur - spacePerWord > 0)
                        {
                            count = spacePerWord;
                        }
                        else
                        {
                            count = cur;
                        }
                        cur -= spacePerWord;
                        while (count > 0)
                        {
                            sb.Append(' ');
                            count--;
                        }
                    }

                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    sb.Append(words[i]);
                    sb.Append(' ');
                }
                while (sb.Length < maxWidth)
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }
    }
}
