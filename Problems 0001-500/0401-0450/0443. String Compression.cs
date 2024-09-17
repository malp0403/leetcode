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
        public int Compress(char[] chars)
        {
            int index = 1;
            int insertIndex = 1;
            int count = 1;
            while(index < chars.Length)
            {
                if (chars[index] != chars[index - 1])
                {
                    if(count > 1)
                    {
                        string countString = count.ToString();
                        int countStringindex = 0;
                        while(countStringindex < countString.Length)
                        {
                            chars[insertIndex] = countString[countStringindex];
                            countStringindex++;
                            insertIndex++;
                        }
                    }



                    insertIndex = index + 1;
                    count = 1;
                }
                else
                {
                    count++;
                }


            }

        }
        #endregion
    }
}
