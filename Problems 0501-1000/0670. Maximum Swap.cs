using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:Problems 0501-1000/0651-0700/0670. Maximum Swap.cs
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
=======
#region Test
/*
   var obj = new _0670() { };
  var answer = obj.MaximumSwap_2024_10_06_v2(2736);
 */
#endregion

namespace leetcode.Problems_0501_1000
{
    internal class _0670
    {
        #region 10/06/2024 
        public int MaximumSwap_2024_10_06(int num)
        {

            string s = num.ToString();
            char[] arr = s.ToCharArray();
            char[] max= Enumerable.Repeat('0', arr.Length).ToArray();

            for(int i =arr.Length - 1;i >= 0; i--)
            {
                if (i == arr.Length - 1) max[i] = arr[i];
                else
                {
                    max[i] = (arr[i] - '0') > (max[i + 1] - '0') ? arr[i] : max[i + 1];
                }
            }

            int index = -1;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] != max[i])
                {
                    index = i;
                    break;
                }
            }

            if(index != -1)
            {

                for(int i = arr.Length - 1; i > index; i--)
                {
                    if (arr[i] == max[index])
                    {
                        char temp = arr[index];
                        arr[index] = max[index];
                        arr[i] = temp;
                    }
                }

                string str = new string(arr);
                return int.Parse(str);

            }
            else
            {
                return num;
            }

          


        }
        #endregion

        #region 10/06/2024 improve; store index for the max
        public int MaximumSwap_2024_10_06_v2(int num)
        {
            string str = num.ToString();
            char[] arr = str.ToCharArray();
            (int index, char max)[] max = Enumerable.Repeat((0, '0'), arr.Length).ToArray();

            for(int i= arr.Length-1;i>=0;i--)
            {
                if(i == arr.Length - 1)
                {
                    max[i] = (i, arr[i]);
                }
                else
                {
                    if (arr[i]- '0' > max[i + 1].max - '0')
                    {
                        max[i] = (i, arr[i]);
                    }
                    else
                    {
                        max[i] = max[i + 1];
                    }
                }

            }

      

            for(int i =0;i < arr.Length; i++)
            {
                if (arr[i] != max[i].max)
                {
                    char temp = arr[i];
                    arr[i] = max[i].max;
                    arr[max[i].index] = temp;


                    break;
                }
            }

            return int.Parse(new string(arr));

        }
        #endregion




>>>>>>> 6d99fc316f77012030d9e02012c6eab5cae03c3c:Problems 0501-1000/0670. Maximum Swap.cs
    }
}
