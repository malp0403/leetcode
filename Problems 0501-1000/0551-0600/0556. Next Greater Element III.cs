using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

#region test data
//var obj = new _0556() { };
//obj.NextGreaterElement_20230911(12);

#endregion
namespace leetcode.Problems
{
    class _0556
    {
        #region Solution
        public int NextGreaterElement_(int n)
        {
            StringBuilder s = new StringBuilder(n.ToString());
            int i = s.Length - 2;
            while (i >= 0 && int.Parse(s[i].ToString()) - int.Parse(s[i + 1].ToString()) >= 0)
            {
                i--;
            }
            if (i < 0) return -1;
            int j = i + 1;
            for (; j < s.Length; j++)
            {
                if (int.Parse(s[j].ToString()) - int.Parse(s[i].ToString()) <= 0)
                {
                    break;
                }
            }
            //swap
            char temp = s[i];
            s[i] = s[j - 1];
            s[j - 1] = temp;
            //reverse
            int l = i + 1;
            int r = s.Length - 1;
            while (l < s.Length && l < r)
            {
                var temp2 = s[l];
                s[l] = s[r];
                s[r] = temp2;
                l++;
                r--;
            }
            if (Int64.Parse(s.ToString()) > Int32.MaxValue) return -1;

            return int.Parse(s.ToString());

        }
        #endregion

        #region 09/11/2023
        public int NextGreaterElement_20230911(int n)
        {

            char[] a = ("" + n).ToCharArray();

            int i = a.Length - 2;
            while(i>=0 && a[i + 1] <= a[i])
            {
                i--;
            }
            if (i == -1) return -1;

            int j = a.Length - 1;
            while(j >=0 && a[j] <= a[i])
            {
                j--;
            }

            //swap
            char temp = a[i];
            a[i] = a[j];
            a[j] = temp;

            //revese;
            int start = i + 1;
            int end = a.Length - 1;

            while(start< end)
            {
                char t = a[start];
                a[start] = a[end];
                a[end] = t;
                start++;
                end--;
            }

            try
            {
                return int.Parse(new string(a));
            }catch(Exception e)
            {
                return -1;
            }
             
        }
        #endregion


    }
}
