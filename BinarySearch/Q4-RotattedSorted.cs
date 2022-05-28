using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q4_RotattedSorted
    {
        //        There is an integer array nums sorted in ascending order(with distinct values).
        //Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k(1 <= k<nums.length) such that the resulting array is [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0-indexed). For example, [0, 1, 2, 4, 5, 6, 7] might be rotated at pivot index 3 and become[4, 5, 6, 7, 0, 1, 2].
        //Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
        //You must write an algorithm with O(log n) runtime complexity.
        //Example 1:

        //Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 0
        //Output: 4
        //Example 2:

        //Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 3
        //Output: -1
        //Example 3:

        //Input: nums = [1], target = 0
        //Output: -1

        //********************Solution 1 **********************
        public int Search(int[] nums, int target) {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target) return mid;
                if(nums[mid] >= nums[l]) // equal to handle case like [2,1] -> 1; 
                {
                    if(target>=nums[l] && target < nums[mid])
                    {
                        r = mid-1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                else
                {
                    if(target > nums[mid] && target <= nums[r])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
            }
            return -1;


            //if (nums.Length == 1) return nums[0] == target ? 0 : -1;
            //int pivot = findPivot(0, nums.Length - 1, nums);

            //if (pivot == 0) return helper(0, nums.Length - 1, nums, target);

            //if(target>= nums[0] && target <= nums[pivot - 1])
            //{
            //    return helper(0, pivot - 1, nums, target);
            //}

            //if (target >= nums[pivot] && target <= nums[nums.Length - 1])
            //{
            //    return helper(pivot, nums.Length - 1, nums, target);
            //}
            //return -1;
          
        }
        public int findPivot(int l, int r, int[] nums)
        {
            while (l < r)
            {
                int mid = l + (r-l)/2 ;
                if (nums[mid] < nums[r]) r = mid;
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }
        public int helper(int l,int r,int[] nums,int target)
        {
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;
        }
        //*********************Solution 2 ****************************
        public int Search_V2(int[] nums,int target)
        {
            return -1;
        }
    }
}
