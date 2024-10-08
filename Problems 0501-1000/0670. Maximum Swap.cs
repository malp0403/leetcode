using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




    }
}
