using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0299
    {
        #region 07/15/2024
        public string GetHint(string secret, string guess)
        {
            int cows = 0;
            int bulls = 0;
            int[] arr1 = Enumerable.Repeat(0,10).ToArray();
            int[] arr2 = Enumerable.Repeat(0, 10).ToArray();
            for(int i =0; i < secret.Length; i++)
            {
                arr1[secret[i] - '0']++;
                arr2[guess[i] - '0']++;
                if (secret[i] == guess[i]) bulls++;
            }

            for(int i =0;i < arr1.Length; i++)
            {
                cows += Math.Min(arr1[i], arr2[i]);
            }


            return bulls + "A" + (cows - bulls).ToString() + "B";


        }
        #endregion
    }
    }
