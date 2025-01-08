using leetcode.Problems_0001_500._0201_0250;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data

//var obj = new _0239();
//var res = obj.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
#endregion

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0239
    {
        #region 09/04/2023 Monotonic Deque.  list.First.Value  list.Last.Value
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
            {
                return new int[0];
            }

            int n = nums.Length;
            int[] result = new int[n - k + 1];
            int index = 0;

            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                while (list.Count > 0 && list.First.Value < i - k + 1)
                {
                    list.RemoveFirst();
                }

                while (list.Count > 0 && nums[list.Last.Value] < nums[i])
                {
                    list.RemoveLast();
                }
                list.AddLast(i);

                if (i >= k - 1)
                {
                    result[index++] = nums[list.First.Value];
                }
            }

            return result;



        }


        #endregion

        #region 07/07/2024
        public int[] MaxSlidingWindow_2024_07_07(int[] nums, int k)
        {
            int n = nums.Length;
            int[] res = new int[n - k + 1];
            int index = 0;

            LinkedList<int> list = new LinkedList<int>();

            for(int i =0; i < n; i++)
            {
                while(list.Count>0 && list.First.Value< i - k + 1)
                {
                    list.RemoveFirst();
                }
                while(list.Count>0 && nums[list.Last.Value] < nums[i])
                {
                    list.RemoveLast();
                }

                list.AddLast(i);

                if(i >= k - 1)
                {
                    res[index++] = nums[list.First.Value];
                }
            }
            return res;
        }

        #endregion

        #region 07/07/2024 my attempt
        public int[] MaxSlidingWindow_2024_07_07_attemp1(int[] nums, int k)
        {
            int n = nums.Length;
            int[] res = new int[n - k + 1];
            int index = 0;

            LinkedList<int> list = new LinkedList<int> { };

            for(int i =0; i < nums.Length; i++)
            {
                while(list.Count>0 && list.First.Value < i - k + 1)
                {
                    list.RemoveFirst();
                }
                while (list.Count > 0 && nums[list.Last.Value] < nums[i])
                {
                    list.RemoveLast();
                }
                list.AddLast(i);

                if(i >= k - 1)
                {
                    res[index++] = nums[list.First.Value];
                }
            }

            return res;
        }

        #endregion
    }


}
