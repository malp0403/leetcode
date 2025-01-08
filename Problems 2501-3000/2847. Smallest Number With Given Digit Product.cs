using System.Linq;
using System.Text;

#region Test Data
//var obj2 = new _2847();
//obj2.SmallestNumber(105);
#endregion

namespace leetcode.Problems_2501_3000._2801_2850
{
    internal class _2847
    {
        #region 09/25/2023
        public string SmallestNumber(long n)
            
        {
            if (n == 1) return "1";
            int[] arr = Enumerable.Repeat(0, 10).ToArray();
            int divide = 9;
            while(divide >= 2)
            {
                while(n%divide == 0)
                {
                    arr[divide]++;
                    n /= divide;
                }

                divide--;
            }
            if (n > 10) return "-1";

            StringBuilder sb = new StringBuilder();
            for(int i =0;i< arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    sb.Append(i);
                    arr[i]--;
                }
            }
            return sb.ToString();
        }
        #endregion
    }
}
