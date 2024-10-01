using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2551_2600
{
    internal class _2599
    {
        #region 09/25/2023 careful sum may be overflow
        public int MakePrefSumNonNegative(int[] nums)
        {
            int operation = 0;
            long sum = 0;
            List<int> negatives = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] < 0) negatives.Add(i);
                if (sum >= 0) continue;


                //remove the biggest negative in list
                int index = -1;
                int min = int.MaxValue;
                foreach (var item in negatives)
                {
                    if (nums[item] < min)
                    {
                        index = item;
                        min = nums[item];
                    }
                }

                sum -= nums[index];
                negatives.Remove(index);
                operation++;

            }

            return operation;
        }
        #endregion
    }
}
