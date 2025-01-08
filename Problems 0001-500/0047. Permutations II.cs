using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0001_50
{
    internal class _0047
    {
        #region 02/24/2024  BackTracking + key

        IList<IList<int>> answer_2024_02_24;
        public IList<IList<int>> PermuteUnique_2024_02_24(int[] nums)
        {
            answer_2024_02_24 = new List<IList<int>>();
            bool[] seen = Enumerable.Repeat(false, nums.Length).ToArray();

            Array.Sort(nums);
            helper_2024_02_24(nums, seen, new List<int>(),new HashSet<string>());

            return answer_2024_02_24;


        }
        public void helper_2024_02_24(int[] nums,bool[] seen, List<int> curList,HashSet<string> keys)
        {
            if (isFull_2024_02_14(seen))
            {
                string key = string.Join(',', curList);
               
                if(!keys.Contains(key))
                {
                    answer_2024_02_24.Add(new List<int>(curList));
                    keys.Add(key);

                }
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!seen[i])
                {
                    curList.Add(nums[i]);
                    seen[i]= true;



                    helper_2024_02_24(nums, seen, curList, keys);
                    curList.RemoveAt(curList.Count - 1);
                    seen[i] = false;

                    int cur = nums[i];
                }
            }
        }

        public bool isFull_2024_02_14(bool[] seen)
        {
            for(int i =0; i < seen.Length; i++)
            {
                if (!seen[i]) return false;
            }
            return true;
        }
        #endregion
    }
}
