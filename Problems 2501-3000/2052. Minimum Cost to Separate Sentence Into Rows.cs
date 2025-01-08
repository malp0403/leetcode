using leetcode.Problems_2501_3000._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
#region Test Data
//var obj2 = new _2052();
//obj2.MinimumCost_dp("i love leetcode", 12); //36
//obj2.MinimumCost_dp("apples and bananas taste great", 7); //21
//obj2.MinimumCost_dp("ks kdu mcjd", 5); //13
//obj2.MinimumCost_dp("aa aaa aa", 10); //0
#endregion

namespace leetcode.Problems_2501_3000._2051_2100
{
    internal class _2052
    {
        #region 10/09/2023 TLE 
        int min = int.MaxValue;
        public int MinimumCost(string sentence,int k)
        {
            string[] arr=  sentence.Split(' ');
            int N = arr.Length;

            if (N == 1) return 0;
            int[] stringArry = arr.Select(x=>x.Length).ToArray();
            int[] records = Enumerable.Repeat(0,N).ToArray();

            helper(records, 0, stringArry, 0, k);
            return min;
        }

        public void helper(int[] records,int recordIndex, int[] stringArray,int Arrayindex,int k)
        {
            if(Arrayindex >= stringArray.Length)
            {
                min = Math.Min(min,cal(records, k));
                return;
            }
            int toAdd = stringArray[Arrayindex] + (records[recordIndex] == 0 ? 0 : 1);
            if (records[recordIndex] + toAdd <= k)
            {
                records[recordIndex] += toAdd;
                helper(records, recordIndex, stringArray, Arrayindex + 1, k);
                records[recordIndex] -= toAdd;

            }

            if (records[recordIndex] != 0)
            {
                records[recordIndex+1] = stringArray[Arrayindex];
                helper(records, recordIndex+1, stringArray, Arrayindex + 1, k);
                records[recordIndex + 1] -= stringArray[Arrayindex];
            }

        }

        public int cal(int[] records,int k)
        {
            int sum =0;
            for(int i =0; i < records.Length; i++)
            {
                if (i == records.Length - 1) continue;
                if (records[i] != 0 && records[i + 1] == 0) break;
                sum += (int)Math.Pow(k - records[i], 2); 
            }
            return sum;
        }


        #endregion

        #region 10/09/2023 DP
        public int MinimumCost_dp(string sentence,int k)
        {
            if(sentence.Length < k) return 0;
            string[] strings = sentence.Split(" ");
            int[] arr = strings.Select(x => x.Length).ToArray();
            int[] dp = Enumerable.Repeat(0, arr.Length+1).ToArray();

            for(int i=1; i <= arr.Length; i++)
            {
                int len = 0;
                dp[i] = int.MaxValue;
                for(int j = i; j > 0; j--)
                {
                    len += arr[j - 1];
                    if (j < i)
                    {
                        len++;
                    }
                    if (len > k) break;
                    int cur = (k - len) * (k - len);
                    if(i == arr.Length)
                    {
                        cur = 0;
                    }
                    dp[i] = Math.Min(dp[i], cur + dp[j - 1]);
                }
            }
            return dp[arr.Length];
        }
        #endregion
    }
}
