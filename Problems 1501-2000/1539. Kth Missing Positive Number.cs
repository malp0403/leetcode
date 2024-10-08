using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1539
    {
        #region LeetCode Approach 1: Brute Force, O(N) time

        #endregion

        #region Approach 2: Binary Search, O(logN) time; right = mid-1
        public int FindKthPositive_app2(int[] arr, int k)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] - mid -1 < k)
                {
                    left = mid + 1;

                }
                else
                {
                    right = mid-1;
                }
            }

            return left + k;
        }
        #endregion

        #region Solution
        public int FindKthPositive(int[] arr, int k)
        {
            int arrIndx = 0;
            int count = 0;
            int num = 1;
            while (count != k)
            {
                if ((num != arr[arrIndx] && arrIndx < arr.Length) || arrIndx >= arr.Length)
                {
                    count++;
                }
                else
                {
                    arrIndx++;
                }
                num++;
            }
            return num--;
        }
      
        public int FindKthPositive2(int[] arr, int k)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] - m - 1 < k)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return l + k;
        }
        #endregion

        #region 12/23/2021
        public int FindKthPositive_R3(int[] arr, int k)
        {
            int l = 0;
            int r = arr.Length - 1;
            if (arr[0] - 1 >= k) return k;
            if (arr[arr.Length - 1] - (arr.Length - 1) + 1 < k) return k + arr.Length - 2;
            while (l < r)
            {
                int mid = l + (l - r) / 2;

                if ((arr[mid] - (mid + 1)) < k)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }

            return l + k;
        }
        #endregion

        #region 10/07/2024 queue contains 2000
        public int FindKthPositive_2024_10_24(int[] arr, int k)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= 2000; i++)
            {
                q.Enqueue(i);
            }
            int ans = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] > q.Peek())
                {
                    ans = q.Dequeue();
                    k--;
                    if (k == 0) return ans;
                }
                q.Dequeue();
            }

            while (k > 0)
            {
                ans = q.Dequeue();
                k--;
            }

            return ans;
        }
        #endregion


    }
}
