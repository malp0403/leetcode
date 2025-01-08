using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0051_100
{
    internal class _0087
    {
        #region 03/17/2024 TLE
        public bool IsScramble(string s1, string s2)
        {
            return divide(s1, s2);
        }

        public bool divide(string s1, string s2)
        {

            bool isValid = false;
            if (s1.Length == 1) return compare(s1, s2);

            for(int len =1; len < s1.Length; len++)
            {
                string temp1_a = s1.Substring(0, len);
                string temp1_b = s1.Substring(len, s1.Length - len);

                string temp2_a = s2.Substring(0, len);
                string temp2_b = s2.Substring(len, s1.Length - len);

                string temp3_a = s2.Substring(0, s1.Length - len);
                string temp3_b = s2.Substring(s1.Length-len);


                if (compare(temp1_a, temp2_a) &&  compare(temp1_b, temp2_b))
                {
                    isValid = isValid || (divide(temp1_a, temp2_a) && divide(temp1_b, temp2_b));
                }
                if (compare(temp1_a, temp3_b) && compare(temp1_b, temp3_a))
                {
                    isValid = isValid || (divide(temp1_a, temp3_b) && divide(temp1_b, temp3_a));
                }
            }

            return isValid;
        }

        public bool compare(string s1, string s2)
        {
            if (s1.Length == 1)
            {
                return s1 == s2;
            }

            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach(char i in s2)
            {
                arr[i - 'a']++;
            }
            foreach(char i in s1)
            {
                arr[i - 'a']--;
                if (arr[i - 'a'] < 0) return false;

            }
            return true;
        }
        #endregion
    }
}
