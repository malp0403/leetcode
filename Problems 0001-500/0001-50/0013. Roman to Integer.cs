using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0013
    {
        #region answer
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);
            if (s.Length == 1) return dic[s[0]];
            int ans = 0;
            for(int i =0; i < s.Length-1; i++)
            {
                if(dic[s[i]] < dic[s[i + 1]])
                {
                    ans -= dic[s[i]];
                }
                else
                {
                    ans += dic[s[i]];
                }
            }
            ans += dic[s[s.Length - 1]];


            return ans;
        }
        public string helper(int num, int level)
        {
            string first = "";
            string mid = "";
            string end = "";
            switch (level)
            {
                case 0:
                    first = "I";
                    mid = "V";
                    end = "X";
                    break;
                case 1:
                    first = "X";
                    mid = "L";
                    end = "C";
                    break;
                case 2:
                    first = "C";
                    mid = "D";
                    end = "M";
                    break;
                case 3:
                    first = "M";
                    break;
                default: break;
            }
            string ans = "";
            switch (num) {
                case 1:
                case 2:
                case 3:
                    while (num > 0)
                    {
                        ans += first;
                        num--;
                    }
                    break;
                case 4: ans= first + mid;break;
                case 5: ans = mid;break;
                case 6: ans = mid + first;break;
                case 7:
                case 8:
                    ans = mid;
                    while (num > 5)
                    {
                        ans += first;
                        num--;
                    }
                    break ;
                case 9: ans = end + first;break;
                default:break;

            }
            return ans;
 
                


        }
        #endregion

        #region review 01/31/2022
        //01-31-2022-----------------------
        public int RomanToInt_R2(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);
            int ans = 0;
            for(int i =0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && dic[s[i+1]]>dic[s[i]])
                {
                    ans -= dic[s[i]];
                }
                else
                {
                    ans += dic[s[i]];
                }
            }
            return ans;
        }
        #endregion

        #region 07/18/2022
        public int RomanToInt_R3(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);
            int answer = 0;
            for(int i =0; i < s.Length; i++)
            {
                if(i+1<s.Length &&  dic[s[i]] < dic[s[i + 1]])
                {
                    answer -= dic[s[i]];
                }
                else
                {
                    answer += dic[s[i]];
                }
            }
            return answer;
        }
        #endregion

        #region 01/14/2024
        public int RomanToInt_2024_01_14(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);
            int answer = 0;

            int index = 0;
            while(index < s.Length)
            {
                int n = dic[s[index]];
                if(index < s.Length-1 && n < dic[s[index+1]])
                {
                    answer -= n;
                }
                else
                {
                    answer += n;
                }
                index++;
            }
            return answer;
        }
        #endregion
    }
}
