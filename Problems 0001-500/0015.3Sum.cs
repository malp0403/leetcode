using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;

#region Test Data
//int[] nums = new int[6] { -1, 0, 1, 2, -1, 4 };
//var obj = new _0015() { };
//var answer = obj.ThreeSum_20230718(nums);

//int[] nums2 = new int[4] { -1, 0,0,1 };
//var obj2 = new _0015() { };
//var answer2 = obj2.ThreeSum_20230718(nums2);
#endregion
namespace leetcode.Problems
{
    class _0015
    {
        #region 2 pointers***************************
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ans = new List<IList<int>>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    helper(nums, i, ans);
                }
            }
            return ans;
        }
        public void helper(int[] nums, int start, IList<IList<int>> res)
        {
            int lo = start + 1; int hi = nums.Length - 1;
            while (lo < hi)
            {
                int temp = nums[start] + nums[lo] + nums[hi];
                if (temp > 0)
                {
                    hi--;
                }
                else if (temp < 0)
                {
                    lo++;
                }
                else
                {
                    res.Add(new List<int>() { nums[start], nums[lo++], nums[hi] });
                    while (lo < hi && nums[lo] == nums[lo - 1])
                    {
                        lo++;
                    }
                }
            }
        }
        #endregion

        #region Hashset***************************
        public IList<IList<int>> ThreeSum_V2(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ans = new List<IList<int>>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    helper(nums, i, ans);
                }
            }
            return ans;
        }
        public void helper_V2(int[] nums, int start, IList<IList<int>> res)
        {
            HashSet<int> set = new HashSet<int>() { };
            for (int j = start + 1; j < nums.Length; j++)
            {
                int temp = -nums[start] - nums[j];
                if (set.Contains(temp))
                {
                    res.Add(new List<int>() { nums[start], nums[j], temp });
                    while (j + 1 < nums.Length && nums[j + 1] == nums[j])
                    {
                        j++;
                    }
                }
                set.Add(nums[j]);
            }
        }
        #endregion

        #region 07/18/2022
        public IList<IList<int>> ThreeSum_r2(int[] nums)

        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>() { };

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    while (left < right && left < nums.Length)
                    {
                        int sum = nums[left] + nums[right] + nums[i];
                        if (sum > 0)
                        {
                            right--;
                        }
                        else if (sum < 0)
                        {
                            left++;
                        }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                            left++;
                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                        }
                    }
                }
            }

            return result;
        }
        #endregion two pointers

        #region 12/28/2022 two pointers
        IList<IList<int>> answer_20221228;
        public IList<IList<int>> ThreeSum_20221228(int[] nums)
        {
            Array.Sort(nums);
            answer_20221228 = new List<IList<int>>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    helper_20221228(nums, i + 1, nums.Length - 1, -nums[i]);

                }
            }
            return answer_20221228;
        }
        public void helper_20221228(int[] nums, int start, int end, int target)
        {
            int low = start;
            int hi = end;
            while (low < hi)
            {
                int sum = nums[low] + nums[hi];
                if (sum == target)
                {
                    answer_20221228.Add(new List<int>() { nums[low], nums[hi], -target });
                    low++;
                    while (low < hi && nums[low] == nums[low - 1])
                    {
                        low++;
                    }
                }
                else if (sum < target)
                {
                    low++;
                }
                else
                {
                    hi--;
                }
            }
                      
        }
        #endregion

        #region 12/28/2022 Hashset
        public void helper_20221228v2(int[] nums, int start, int end, int target)
        {
            HashSet<int> set = new HashSet<int>() { };
            for(int i = start; i <= end; i++)
            {
                int result = target - nums[i];
                if (set.Contains(result))
                {
                    answer_20221228.Add(new List<int>() { nums[i], result, -target });
                    while (i + 1 <= end && nums[i+1] == nums[i])
                    {
                        i++;
                    }
                }
                else
                {
                    set.Add(nums[i]);
                }
            }
        }


        #endregion

        #region 07/18/2023

        public IList<IList<int>> ThreeSum_20230718(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> answer = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(i==0 || nums[i] != nums[i - 1])
                {
                    helper_20230718(i, nums, answer);
                }
            }


            return answer;
        }

        public void helper_20230718(int index, int[] nums, IList<IList<int>> answer)
        {
            int l = index + 1;
            int r = nums.Length - 1;
            int remain = -nums[index];

            while (l < r && l < nums.Length - 1 && r>0)
            {
                if (nums[l] + nums[r] > remain)
                {
                    r--;
                    while(r >0 && nums[r] == nums[r + 1])
                    {
                        r--;
                    }
                    //skip duplicate

                }else if (nums[l] + nums[r] < remain)
                {
                    l++;
                    while ( l < nums.Length-1 && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
                else
                {
                    answer.Add(new List<int>() { nums[index], nums[l], nums[r] });
                    l++;
                    while (l < nums.Length - 1 && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
            }
        }




        #endregion

        #region 01/21/2024 
        public IList<IList<int>> ThreeSum_2024_01_21(int[] nums)
        {
            Array.Sort(nums);
            int index = 0;
            IList<IList<int>> result = new List<IList<int>>();
            while (index < nums.Length - 1)
            {
                List<List<int>> res = this.TwoSum_2024_01_21(index + 1, nums.Length - 1, nums, nums[index]);
                foreach (var item in res)
                {
                    result.Add(item);
                }

                index++;
                while(index< nums.Length - 1 && nums[index] == nums[index - 1])
                {
                    index++;
                }
            }

            return result;
        }

        public List<List<int>> TwoSum_2024_01_21(int l, int r, int[] nums, int initialValue)
        {
            List<List<int>> result = new List<List<int>>();
            while (l < r)
            {
                int sum = nums[l] + nums[r] + initialValue;
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[l], nums[r], initialValue });
                    l++;
                    while (l < r && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
                else if (sum < 0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return result;
        }
        #endregion
    }
}
