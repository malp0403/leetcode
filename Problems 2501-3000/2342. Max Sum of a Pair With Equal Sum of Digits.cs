using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2301_2350
{
    internal class _2342
    {
        #region Burtal force
        public int MaximumSum(int[] nums)
        {
            int[] sums= Enumerable.Repeat(0,nums.Length).ToArray();
            Dictionary<int, LinkedList<int>> dic = new Dictionary<int, LinkedList<int>>() { };

            for(int i =0; i < nums.Length; i++)
            {
                int val = helper(nums[i], 0);
                if (dic.ContainsKey(val))
                {
                    if (dic[val].Count == 1)
                    {
                        if (dic[val].First.Value > nums[i])
                        {
                            dic[val].AddLast(nums[i]);
                        }
                        else
                        {
                            dic[val].AddFirst(nums[i]);
                        }
                    }
                    else
                    {
                        if (nums[i] < dic[val].Last.Value) continue;

                        dic[val].RemoveLast();

                        if (nums[i] > dic[val].First.Value)
                        {
                            dic[val].AddFirst(nums[i]);
                        }
                        else 
                        {
                            dic[val].AddLast(nums[i]);
                        }
                       
                    }
                }
                else
                {
                    LinkedList<int> l = new LinkedList<int>() {};
                    l.AddFirst(nums[i]);
                    dic.Add(val, l);
                }
            }

            int answer = -1;
            foreach (var item in dic.Keys)
            {
                if (dic[item].Count == 2)
                {
                    answer = Math.Max(answer, dic[item].First.Value + dic[item].Last.Value); 
                }
            }
            return answer;

        }
        
        public int helper(int a1,int a2)
        {
            int total = 0;
            while(a1 != 0)
            {
                total += a1 % 10;
                a1 = a1 / 10;
            }
            while(a2 != 0)
            {
                total += a2%10;
                a2 = a2 / 10;
            }
            return total;
        }
        #endregion

        #region 09/23/2023
        public int MaximumSum_20230923(int[] nums)
        {
            Dictionary<int, (int? first, int? second)> dic = new Dictionary<int, (int? first, int? second)>();
            int max = -1;
            for(int i =0; i < nums.Length; i++)
            {
                int key = helper_20230923(nums[i]);
                if (dic.ContainsKey(key))
                {
                    if(dic[key].second ==null)
                    {
                        if(nums[i] > (int)dic[key].first.Value)
                        {
                            dic[key] = (nums[i], dic[key].first.Value);
                        }
                        else
                        {
                            dic[key] = (dic[key].first.Value, nums[i]);
                        }
                    }
                    else
                    {
                        if (nums[i] <= (int)dic[key].second.Value) continue;
                        if (nums[i] > dic[key].first.Value)
                        {
                            dic[key] = (nums[i], dic[key].first.Value);
                        }
                        else
                        {
                            dic[key] = (dic[key].first.Value, nums[i]);
                        }
                    }
                    max = Math.Max(max, (int)dic[key].first.Value + (int)dic[key].second.Value);


                }
                else
                {
                    dic.Add(key, (nums[i], null));
                }
            }
            return max;
            
        }
        public int helper_20230923(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
        #endregion
    }
}
