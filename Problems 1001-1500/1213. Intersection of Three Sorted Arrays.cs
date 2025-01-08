using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1213
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            var section1 = Intersection(arr1, arr2);
            var section2 = Intersection(section1.ToArray(), arr3);
            return section2;
        }

        public IList<int> Intersection(int[] arr1,int[] arr2)
        {
            int i = 0;
            int j = 0;
            List<int> answer = new List<int>() { };
            while(i < arr1.Length && j < arr2.Length)
            {
                if(arr1[i]== arr2[j])
                {
                    answer.Add(arr1[i]);
                    i++;
                    j++;
                }else if(arr1[i] > arr2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return answer;
        }


        //***************12/14/2021
        public IList<int> ArraysIntersection_Review2(int[] arr1, int[] arr2, int[] arr3)
        {
            var li = helper(arr1, arr2);
            return helper(li.ToArray(), arr3);
        }
        public IList<int> helper(int[] arr1, int[] arr2)
        {
            IList<int> list = new List<int>(){ };
            int p1 = 0;
            int p2 = 0;
            while(p1<arr1.Length && p2 < arr2.Length)
            {
                if (arr1[p1] == arr2[p2])
                {
                    list.Add(arr1[p1]);
                    p1++;
                    p2++;
                }else if(arr1[p1] > arr2[p2])
                {
                    p2++;
                }
                else
                {
                    p1++;
                }
            }
            return list;
        }

        //***************12/14/2021   three pointers****************
        public IList<int> ArraysIntersection_Review3(int[] arr1, int[] arr2, int[] arr3)
        {
            int p1=0 , p2=0 , p3 = 0;
            IList<int> ans = new List<int>() { };
            while (p1 < arr1.Length && p2 < arr2.Length && p3 < arr3.Length)
            {
                if(arr1[p1] == arr2[p2] && arr1[p1] == arr3[p3])
                {
                    ans.Add(arr1[p1]);
                    p1++;p2++;p3++;
                }
                else
                {
                    if(arr1[p1] < arr2[p2])
                    {
                        p1++;
                    }else if (arr2[p2] < arr3[p3])
                    {
                        p2++;
                    }
                    else { p3++; }
                }
            }
            return ans;
        }
    }
}
