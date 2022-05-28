using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> ans = new List<string>() { };
            if (nums.Length == 0) return ans;
            if (nums.Length == 1) return new List<string>() { nums[0].ToString() };
            int? start = null;
            Stack<int> s = new Stack<int>() { };
            s.Push(nums[0]);
            start = nums[0];

            for(int i =1; i < nums.Length; i++)
            {
                string input = "";
                if (nums[i] != s.Peek() + 1)
                {
                   
                    if(s.Peek() == start)
                    {
                        input = start.ToString();
                    }
                    else
                    {
                        input = start.ToString() + "->" + s.Peek().ToString();

                    }
                    ans.Add(input);
                    start = nums[i];

                    if(i == nums.Length - 1)
                    {
                        input = nums[i].ToString();
                        ans.Add(input);
                    }
                }
                else
                {
                    if (i == nums.Length - 1)
                    {
                        input = start.ToString() + "->" + nums[i].ToString();
                        ans.Add(input);
                    }
                }
                s.Push(nums[i]);
            }
            return ans;
        }

        //*********** pointer cleaner***************
        public IList<string> SummaryRanges_V2(int[] nums)
        {
            IList<string> ans = new List<string>() { };

            for (int i = 0, j = 0; j < nums.Length; j++)
            {
                if (j + 1 < nums.Length && nums[j + 1] - nums[j] == 1) continue;

                if (i == j) ans.Add(nums[i].ToString());
                else ans.Add(nums[i] + "->" + nums[j]);
                i = j + 1;
            }
            return ans;

        }
        //-----------12-28-2021--------------
        public IList<string> SummaryRanges_R(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new List<string>() { };
            }
            else if (nums.Length == 1)
            {
                return new List<string>() { nums[0].ToString() };
            }
            IList<string> ans = new List<string>() { };
            int prev = nums[0];
            int start = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - prev != 1)
                {
                    if(prev == start)
                    {
                        ans.Add(start.ToString());
                    }
                    else
                    {
                        ans.Add(start + "->" + prev);
                        
                    }
                    if (i == nums.Length - 1)
                    {
                        ans.Add(nums[i].ToString());
                    }
                    start = nums[i];
                }
                else
                {
                    if(i == nums.Length - 1)
                    {
                        ans.Add(start + "->" + nums[i]);
                    }
                }

                prev = nums[i];

            }
            return ans;

        }

        public IList<string> SummaryRanges_R2(int[] nums)
        {
            IList<string> ans = new List<string>() { };

            for (int i = 0,j = 0; j < nums.Length; j++){
                if (j + 1 < nums.Length && nums[j + 1] - nums[j] == 1) continue;

                if (i == j) ans.Add(nums[i].ToString());
                else ans.Add(nums[i] + "->" + nums[j]);
                i = j + 1;
            }
            return ans;

        }
    }
}
