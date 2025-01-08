using System;
using System.Collections.Generic;
using System.Text;
#region Test case
/*
             var obj = new _0220();
            obj.ContainsNearbyAlmostDuplicate(new int[] { 0, 10, 22, 15, 0, 5, 22, 12, 1, 5 }, 2, 3);
            obj.ContainsNearbyAlmostDuplicate(new int[] { 1,5,9,1,5,9}, 2,3);
 */
#endregion
namespace leetcode.Problems
{
    class _0220
    {

        #region LeetCode Approach #3 (Buckets) [Accepted]

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {
            Dictionary<int,int> bucket= new Dictionary<int,int>();
            long w = (long)valueDiff + 1;
            for(int i =0; i <  nums.Length; i++)
            {

                int id = getID(nums[i], w);
                if (bucket.ContainsKey(id)) return true;
                if (bucket.ContainsKey(id-1) && Math.Abs(nums[i]- bucket[id-1]) < w)
                {
                    return true;
                }
                if (bucket.ContainsKey(id + 1) && Math.Abs(nums[i] - bucket[id + 1]) < w)
                {
                    return true;
                }
                bucket.Add(id, nums[i]);
                if (i >= indexDiff) bucket.Remove(getID(nums[i - indexDiff],w));
            }
            return false;

        }
        public int getID(long num, long w)
        {
            return (int)Math.Floor((double)num / w); ;

        }

        #endregion

        #region 07/07/2024 TLE
        public bool ContainsNearbyAlmostDuplicate_2024_07_07(int[] nums, int indexDiff, int valueDiff)
        {
            SortedDictionary<int, List<int>> dic = new SortedDictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    int closest = dic[nums[i]][dic[nums[i]].Count - 1];
                    if (Math.Abs(closest - i) <= indexDiff) return true;
                    dic[nums[i]].Add(i);

                }
                else
                {
                    dic.Add(nums[i], new List<int>() { i });
                }
            }

            foreach (var key1 in dic.Keys)
            {
                foreach (var key2 in dic.Keys)
                {
                    if (key2 > key1 && key2 - key1 <= valueDiff)
                    {
                        if (compare_2024_07_07(dic[key1], dic[key2], indexDiff)) return true;
                    }
                }
            }

            return false;
        }

        public bool compare_2024_07_07(List<int> list1, List<int> list2, int indexDiff)
        {
            int l1 = 0;
            int l2 = 0;
            while (l1 < list1.Count && l2 < list2.Count)
            {
                if (Math.Abs(list1[l1] - list2[l2]) <= indexDiff) return true;
                if (list1[l1] < list2[l2])
                {
                    l1++;
                }
                else
                {
                    l2++;
                }
            }
            return false;
        }
        #endregion

    }
}
