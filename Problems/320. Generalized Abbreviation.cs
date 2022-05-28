using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class _320
    {
        public IList<string> GenerateAbbreviations(string word)
        {

            IList<string> res = new List<string>() { };

            backtract(res, new StringBuilder(), word, 0, 0);
            return res;
        }

        public void backtract(IList<string> res, StringBuilder stringBuilder, string word, int i , int c) {
            if (i == word.Length)
            {
                if (c != 0) stringBuilder.Append(c);
                Console.WriteLine(stringBuilder.ToString());
                res.Add(stringBuilder.ToString());
            }
            else {
                
                backtract(res, new StringBuilder(stringBuilder.ToString()), word, i + 1, c + 1);

                if (c != 0) stringBuilder.Append(c);
                stringBuilder.Append(word[i]);
                backtract(res, new StringBuilder(stringBuilder.ToString()), word, i + 1, 0);
            }
        }
    }
}
