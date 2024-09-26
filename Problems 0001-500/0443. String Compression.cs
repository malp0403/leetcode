using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0443
    {
        #region Solution
        public int Compress(char[] chars)
        {
            if (chars.Length == 0) return 0;
            List<string> l = new List<string>() { };
            char? pre = null;
            int indx = 0;
            while (indx < chars.Length)
            {

                if (chars[indx] == pre)
                {
                    int count = 1;
                    while (indx < chars.Length && chars[indx] == pre)
                    {
                        count++;
                        indx++;
                    }
                    l.Add(pre.ToString());
                    l.Add(count.ToString());

                }
                else
                {
                    pre = chars[indx];
                    if (indx == chars.Length - 1 || (indx < chars.Length - 1 && chars[indx + 1] != pre))
                    {
                        l.Add(chars[indx].ToString());
                    }
                    indx++;
                }
            }

            string result = String.Join("", l.ToArray());
            for (int i = 0; i < result.Length; i++)
            {
                chars[i] = result[i];
            }
            return result.Length;
        }

        #endregion

        #region 12/30/2022
        public int Compress_20221230(char[] chars)
        {
            int count = 0;
            StringBuilder sb = new StringBuilder() { };
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(chars[i]);
                    count = 1;
                }
                else
                {
                    if (chars[i] == chars[i - 1])
                    {
                        count++;
                        if (i == chars.Length - 1)
                        {
                            sb.Append(count);
                        }
                    }
                    else
                    {
                        if (count == 1)
                        {
                            sb.Append(chars[i]);
                        }
                        else
                        {
                            sb.Append(count);
                            sb.Append(chars[i]);
                            count = 1;
                        }

                        if (i == chars.Length - 1 && count != 1)
                        {
                            sb.Append(count);
                        }
                    }
                }
            }

            string ans = sb.ToString();
            for (int i = 0; i < ans.Length; i++)
            {
                chars[i] = ans[i];
            }
            int len = ans.Length;
            return len;
        }
        #endregion

        #region 09/16/2024
        public int Compress_2024_09_16(char[] chars)
        {
            if (chars.Length == 1) return 1;
            int index = 1;
            int count = 1;
            int sum = 0;
            int insertIndex = 0;
            while (index < chars.Length)
            {
                if (chars[index] != chars[index - 1])
                {
                    chars[insertIndex] = chars[index - 1];
                    insertIndex++;

                    if (count > 1)
                    {
                        string countString = count.ToString();
                        int i = 0;
                        while (i < countString.Length)
                        {
                            chars[insertIndex] = countString[i];
                            i++;
                            insertIndex++;
                        }
                    }

                    //reset
                    count = 1;
                }
                else
                {
                    count++;
                }
                if (index == chars.Length - 1)
                {
                    chars[insertIndex] = chars[index];
                    insertIndex++;

                    if (count > 1)
                    {
                        string countString = count.ToString();
                        int i = 0;
                        while (i < countString.Length)
                        {
                            chars[insertIndex] = countString[i];
                            i++;
                            insertIndex++;
                        }
                    }


                }
                index++;


            }
            char[] answer = new char[insertIndex];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = chars[i];
            }

            chars = answer;


            return answer.Length;

        }
        #endregion

        #region LeetCode Solution 1 09/16/2024 
        public int Compress_app1(char[] chars)
        {
            int res = 0;
            int i = 0;
            while (i < chars.Length)
            {
                int len = 1;
                while (i + len < chars.Length && chars[i + len] == chars[i])
                {
                    len++;
                }

                chars[res++] = chars[i];
                if(len > 1)
                {
                    string str = len.ToString();
                    for(int j = 0; j < str.Length; j++)
                    {
                        chars[res++] = str[j];
                    }
                }
                i += len;
            }
            return res;
        }
        #endregion
    }
}
