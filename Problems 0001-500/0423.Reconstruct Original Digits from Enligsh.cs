using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0423
    {
        #region Approach 1: Hashmap 09/11/2024
        /*
         The letter "z" is present only in "zero".
The letter "w" is present only in "two".
The letter "u" is present only in "four".
The letter "x" is present only in "six".
The letter "g" is present only in "eight".

That is actually the key to how to count 3s, 5s, and 7s since some letters are present only in one odd and one even number (and all even numbers have already been counted) :

The letter "h" is present only in "three" and "eight".
The letter "f" is present only in "five" and "four".
The letter "s" is present only in "seven" and "six".
Now one needs to count 9s and 1s only, and the logic is basically the same :

Letter "i" is present in "nine", "five", "six", and "eight".
Letter "n" is present in "one", "seven", and "nine".
         */
        public string OriginalDigits_app1(string s)
        {

            int[] record = Enumerable.Repeat(0, 26).ToArray();
            foreach (var item in s)
            {
                record[item - 'a']++;
            }

            int[] answer = Enumerable.Repeat(0, 10).ToArray();

            answer[0] = record['z' - 'a'];
            answer[2] = record['w' - 'a'];
            answer[4] = record['u' - 'a'];
            answer[6] = record['x' - 'a'];
            answer[8] = record['g' - 'a'];
            answer[3] = record['h' - 'a']- answer[8];
            answer[5] = record['f' - 'a'] - answer[4];
            answer[7] = record['s' - 'a'] - answer[6];
            answer[9] = record['i' - 'a'] - answer[5] - answer[6] - answer[8];
            answer[1] = record['n' - 'a'] - 2*answer[9] - answer[7];

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < answer[i]; j++)
                {
                    sb.Append(i);
                }
            }
            return sb.ToString();

        }
        
        #endregion
    }
}
