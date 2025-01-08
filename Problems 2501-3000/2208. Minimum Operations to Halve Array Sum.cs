using leetcode.Problems_2501_3000._2201_2250;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#region Test Data
//var obj2 = new _2208();
//obj2.HalveArray(new int[] { 1 });
//obj2.HalveArray(new int[] { 5, 19, 8, 1 });
//obj2.HalveArray(new int[] { 6, 58, 10, 84, 35, 8, 22, 64, 1, 78, 86, 71, 77 });
#endregion

namespace leetcode.Problems_2501_3000._2201_2250
{
    internal class _2208
    {
        #region 10/07/2023 priorityQueue, Comparer
        public int HalveArray(int[] nums)
        {

            PriorityQueue<double, double> q = new PriorityQueue<double, double>(new myComparer());
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                q.Enqueue(nums[i], nums[i]);
            }

            double target = sum / 2;

            int count = 0;
            while (sum > target)
            {
                double number = q.Dequeue();
                sum -= number/2;
                q.Enqueue(number / 2, number / 2);
                count++;
            }

            return count;




        }


        #endregion
    }
    public class myComparer:IComparer<double>
    {
        public int Compare(double x, double y)
        {
            if (x - y > 0) return -1;

            else if (x - y < 0) return 1;
            return 0;
        }
    }
}
