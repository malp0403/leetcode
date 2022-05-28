﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Prev1
    {
        //        Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.If target exists,
        //then return its index.Otherwise, return -1.
        //You must write an algorithm with O(log n) runtime complexity.
        //Example 1:
        //Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
        //Output: 4
        //Explanation: 9 exists in nums and its index is 4
        //        Example 2:

        //Input: nums = [-1,0,3,5,9,12], target = 2
        //Output: -1
        //Explanation: 2 does not exist in nums so return -1
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            if (nums.Length == 1) return nums[0] == target ? 0 : -1;
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] < target) l = mid + 1;
                else r = mid - 1;
            }
            return -1;









            //int l = 0;
            //int r = nums.Length - 1;
            //while (l <= r)
            //{
            //    int mid = l + (r - l) / 2;
            //    if (nums[mid] == target) return mid;
            //    else if (nums[mid] < target)
            //    {
            //        l = mid + 1;
            //    }
            //    else
            //    {
            //        r = mid - 1;
            //    }
            //}
            //return -1;
        }
    }
}
