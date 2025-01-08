using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0165
    {
        #region LeetCode Approach 1: Split + Parse, Two Pass
        public int CompareVersion_app1(string version1, string version2)
        {
            string[] arr1 = version1.Split('.');
            string[] arr2 = version2.Split('.');

            int len = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
            {
                int num1 = i <arr1.Length?int.Parse(arr1[i]):0;
                int num2 = i<arr2.Length?int.Parse(arr2[i]):0;
                if (num1 < num2) return -1;
                else if (num1 > num2) return 1;

            }
            
            return 0;
        }

        #endregion

        #region LeetCode Approach 2: Two Pointers, One Pass
        public int CompareVersion_app2(string version1, string version2)
        {
            return 0;
        }

        #endregion

        #region 04/15/2024
        public int CompareVersion_2024_04_15(string version1, string version2)
        {
            string[] arr1 = version1.Split('.');
            string[] arr2 = version2.Split('.');

            int len = Math.Min(arr1.Length, arr2.Length);
            for(int i =0; i < len; i++)
            {
                int num1 = int.Parse(arr1[i]);
                int num2 = int.Parse(arr2[i]);
                if (num1 < num2) return -1;
                else if (num1 > num2) return 1;

            }
            if(arr1.Length > len)
            {
                for(int i = len; i < arr1.Length; i++)
                {
                    int num = int.Parse(arr1[i]);
                    if (num != 0) return 1;
                    
                }
                return 0;
            }else if(arr2.Length > len)
            {
                for (int i = len; i < arr2.Length; i++)
                {
                    int num = int.Parse(arr2[i]);
                    if (num != 0) return -1;

                }
                return 0;
            }
            return 0;
        }
        #endregion
    }
}
