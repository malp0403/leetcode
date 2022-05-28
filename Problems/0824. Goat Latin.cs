using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0824
    {
        public string ToGoatLatin(string sentence)
        {
            var arr1 = sentence.Split(' ');
            HashSet<char> vowel = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };

            List<string> l = new List<string>() { };
            for(int i=0; i < arr1.Length; i++)
            {
                var c = arr1[i].ToLower()[0];
                var s = "";
                if (vowel.Contains(c))
                {
                    s = arr1[i] + "ma";
                }
                else
                {
                    s = arr1[i].Substring(1) + arr1[i][0]+ "ma";
                }
                var count = i;
                while(count >= 0)
                {
                    s += "a";
                    count--;
                }
                l.Add(s);
            }
            return String.Join(" ", l.ToArray());
            
        }

        //*********12/16/2021**************
        List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
        public string ToGoatLatin_R2(string sentence) {
            string[] arr = sentence.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = helper(arr[i], i + 1);
            }
            return String.Join(" ", arr);
        }
        public string helper(string word,int count)
        {
            string ans = "";
            if (!vowels.Contains(word[0]))
            {
                ans = word.Substring(1, word.Length - 1) + word[0].ToString();
            }
            ans = ans + "ma";
            while(count > 0)
            {
                ans += "a";
                count--;
            }
            return ans;
        }
    }
}
