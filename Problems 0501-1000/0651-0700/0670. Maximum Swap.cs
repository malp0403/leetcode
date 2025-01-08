using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0651_0700
{
    internal class _0670
    {
        #region Approach 4: Space Optimized Greedy : from Right to Left;

        public int MaximumSwap_20250107(int num)
        {
            int maxDigitIndex = -1;
            int index1 = -1; int index2 = -1;

            char[] str= num.ToString().ToCharArray();

            for(int i = str.Length-1; i >= 0; i--)
            {
                if(maxDigitIndex == -1 || str[i] > str[maxDigitIndex])
                {
                    maxDigitIndex = i;
                }else if (str[i] < str[maxDigitIndex])
                {
                    index1 = i;
                    index2 = maxDigitIndex;
                }
            }
            if(index1 !=-1 && index2 != -1)
            {
                char c = str[index1];
                str[index1] = str[index2];
                str[index2] = c;
            }

            return int.Parse(string.Join("", str));

            
        }
        #endregion


        #region 01/07/2025
        public int MaximumSwap_2025_01_07(int num)
        {
            if (num / 10 == 0) return num;
            int[] arr = num.ToString().Select(x => (x - '0')).ToArray<int>();


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    continue;
                }
                else
                {
                    int max = arr[i];
                    int index = i;
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[j] >= max)
                        {
                            max = arr[j];
                            index = j;
                        }
                    }

                    int z = i - 1;
                    while (z - 1 >= 0 && arr[z - 1] < max)
                    {
                        z--;
                    }



                    int temp = arr[z];
                    arr[z] = arr[index];
                    arr[index] = temp;


                }
            }

            string ans = string.Join("", arr);
            return int.Parse(ans);
        }
        #endregion
    }
}
