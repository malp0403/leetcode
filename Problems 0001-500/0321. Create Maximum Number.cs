using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0321
    {
        #region 07/23/2024
        List<int> ans;
        int[] _nums1;
        int[] _nums2;
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            ans = new List<int>();
            _nums1 = nums1;
            _nums2 = nums2;
            backtracking(0, 0, k, new List<int>(), false);

            return ans.ToArray();
        }

        public void backtracking(int i1, int i2, int k, List<int> list, bool canZero)
        {
            if (k == 0 || (i1 >= _nums1.Length && i2 >= _nums2.Length))
            {
                Console.WriteLine(string.Join("#", list));
                if (!isLarger(ans, list))
                {
                    ans = list.ToList();
                }
                return;
            }

            if (!shouldContinue(ans, list)) return;
    

            if (i1 < _nums1.Length)
            {
                if (canZero || (!canZero && _nums1[i1] != 0))
                {
                    list.Add(_nums1[i1]);
                    backtracking(i1 + 1, i2, k - 1, list, true);
                    list.RemoveAt(list.Count - 1);
                }
                backtracking(i1 + 1, i2, k, list, true);

            }

            if (i2 < _nums2.Length)
            {
                if (canZero || (!canZero && _nums2[i2] != 0))
                {
                    list.Add(_nums2[i2]);
                    backtracking(i1, i2 + 1, k - 1, list, true);
                    list.RemoveAt(list.Count - 1);
                }
                backtracking(i1, i2 + 1, k, list, true);
            }


        }

        public bool isLarger(List<int> list1, List<int> list2)
        {
            if (list1.Count > list2.Count) return true;
            if (list2.Count > list1.Count) return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] < list2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool shouldContinue(List<int> ans, List<int> cur)
        {
            int min = Math.Min(ans.Count, cur.Count);
            for (int i = 0; i < min; i++)
            {
                if (cur[i] < ans[i])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
