using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Test
//var obj = new _0068() { };
//var res1 = obj.FullJustify_2024_03_06(new string[] {
//          "Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"
//}, 20);
#endregion
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
                    int averagePerWord = (maxWidth - total) / (end - start);
                    int leftover = (maxWidth - total) % (end - start);
                    for (int i = start; i <= end; i++)
                    {

                        sb.Append(words[i]);

                        if (i != end)
                        {
                            int totalSpace = averagePerWord + leftover > 0 ? 1 : 0;
                            while (totalSpace > 0)
                            {
                                sb.Append(' ');
                                totalSpace--;
                            }
                            leftover--;
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

        #region 03/06/2024
        IList<string> answer_2024_03_06= new List<string>();
        int maxLength = int.MaxValue;
        public IList<string> FullJustify_2024_03_06(string[] words, int maxWidth)
        {

            IList<(int len,List<string> list)> res = new List<(int len,List<string> list)>();
            IList<string> answer = new List<string>();

            for (int i =0; i < words.Length; i++)
            {
                int len = words[i].Length;
                if(res.Count ==0 || res.Last().len + res.Last().list.Count + len> maxWidth)
                {
                    var newItem = (len, new List<string>() { words[i] });
                    res.Add(newItem);
                }
                else
                {
                    var updateItem = res.Last();
                    updateItem.len = updateItem.len + words[i].Length;
                    updateItem.list.Add(words[i]);
                    res[res.Count - 1] = updateItem;

                }
            }

            for(int i =0; i < res.Count; i++) {
                
                if(i != res.Count - 1)
                {
                    answer.Add(format_2024_03_06(res[i].len, res[i].list, maxWidth));
                }
                else
                {
                    string temp = string.Join(" ", res[i].list);
                    temp = temp.Trim() + string.Join("", Enumerable.Repeat(" ", maxWidth - temp.Trim().Length).ToArray());
                    answer.Add(temp);
                }
            }

            return answer;  



        }
      
        public string format_2024_03_06(int totalLen,List<string> list,int maxWidth)
        {
            StringBuilder sb = new StringBuilder();
            if(list.Count == 1)
            {
                sb.Append(list.First());
                sb.Append(string.Join("",Enumerable.Repeat(" ", maxWidth - totalLen).ToArray()));
            }
            else
            {
                int gap = (maxWidth - totalLen)/ (list.Count-1);
                int extra = (maxWidth - totalLen) % (list.Count - 1);
                string spaces = string.Join("", Enumerable.Repeat(" ", gap).ToArray());
                for(int i=0;i < list.Count; i++)
                {
                    sb.Append(list[i]);
                    if(i != list.Count - 1)
                    {
                        sb.Append(spaces);
                        if (extra > 0)
                        {
                            sb.Append(" ");
                            extra--;
                        }
                    }
 
                }
            }
            return sb.ToString();

        }
        #endregion
    }
}
