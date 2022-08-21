using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0605
    {

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1) return true;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (i == 0)
                {
                    if (i + 1 < flowerbed.Length && flowerbed[i + 1] == 0)
                    {
                        n--;
                        i++;
                    }
                }
                else if (i == flowerbed.Length - 1)
                {
                    if (i - 1 >= 0 && flowerbed[i - 1] == 0)
                    {
                        n--;
                        //i++;
                    }
                }
                else
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                    {
                        n--;
                        i++;
                    }
                }


                if (n == 0) break;
            }









            return n > 0 ? false : true;
        }

        //-----12-30-2021-------------
        public bool CanPlaceFlowers_R2(int[] flowerbed, int n)
        {
            if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1) return true;
            if (n == 0) return true;
            for (int i=0; i< flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (i == 0)
                    {
                        if (i < flowerbed.Length && flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                    else if (i == flowerbed.Length - 1)
                    {
                        if (i >= 1 && flowerbed[i - 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                    else
                    {
                        if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                }
                if (n == 0) return true;
            }
            return false;
        }
    }
}
