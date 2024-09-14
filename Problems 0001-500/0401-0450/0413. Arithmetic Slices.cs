using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0413
    {

        #region Approach 5: Constant Space Dynamic Programming 09/05/2024

        public int NumberOfArithmeticSlices_app5(int[] nums)
        {
            int dp = 0;
            int sum = 0;
            for(int i =2; i< nums.Length; i++)
            {
                if (nums[i] - nums[i-1] == nums[i - 1] - nums[i - 2])
                {
                    dp = 1 + dp;
                    sum += dp;
                }
                else
                {
                    dp = 0;
                }

            }
            return sum;
        }

        #endregion

        #region 09/05/2024 no DP
        public int NumberOfArithmeticSlices(int[] nums)
        {
            if (nums.Length <= 2) return 0;
            int dif = nums[1] - nums[0];
            int start = 0;


            int sum = 0;
        

            for(int i =2;i < nums.Length; i++)
            {
                if (nums[i] - nums[i-1] == dif)
                {
                 
                    if( i == nums.Length - 1)
                    {
                        if(i - start + 1 >= 3)
                        {
                            sum += Count(i - start + 1);
                        }
                    }
                    continue;
                }
                else
                {
                    if(i -start  >= 3)
                    {
                        sum += Count(i - start);
                    }

                    start = i-1;
                    dif = nums[i] - nums[start];    
                }
            }
            return sum;
        }
        public int Count(int len)
        {
            int total = 0;
            while(len >= 3)
            {
                total += (len - 2);
                len--;
            }
            return total;
        }
        #endregion


    }
}
