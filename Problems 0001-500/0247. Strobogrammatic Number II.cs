using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0247
    {
        List<int> list1 = new List<int>() { 0,1,6,8,9};
        List<int> list2 = new List<int>() { 0, 1, 8 };
        IList<string> answer;
        public IList<string> FindStrobogrammatic(int n)
        {
            if (n == 1)
            {
                return list2.Select(x=>x.ToString()).ToList();
            }
            answer = new List<string>();
            helper(0, Enumerable.Repeat(0, n).ToList().ToArray());
            return answer;
        }

        public void helper(int start, int[] arr)
        {
            if(arr.Length %2 == 0)
            {
                if (start >= arr.Length / 2)
                {
                    answer.Add(string.Join("",arr));
                    return;
                };
            }
            else
            {
                if(start == arr.Length / 2)
                {
                    foreach (var item in list2)
                    {
                        arr[start] = item;
                        answer.Add(string.Join("", arr));
                    }
                    return;
                }
            }

            for(int i =0;i < list1.Count; i++)
            {
                if (list1[i] == 6)
                {
                    arr[start] = 6;
                    arr[arr.Length - start - 1] = 9;
                }else if (list1[i] == 9)
                {
                    arr[start] = 9;
                    arr[arr.Length - start - 1] = 6;
                }
                else
                {
                    if (start == 0 && list1[i] == 0) continue;
                    arr[start] = list1[i];
                    arr[arr.Length - start - 1] = list1[i];
                }
                helper(start + 1, arr);
            }
        }
    }
}
