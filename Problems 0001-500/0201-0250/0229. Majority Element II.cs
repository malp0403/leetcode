using leetcode.Problems_0001_500._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Test Data

//var obj = new _0229() { };
//var res = obj.MajorityElement(new int[] { 3, 2, 3 });
//var res2 = obj.MajorityElement(new int[] { 1 });

#endregion

namespace leetcode.Problems_0001_500._0201_0250
{
    public class _0229
    {
        #region Solution Boyer-Moore Voting Algorithm  most one -> n/2; most 2 -> n/3; most 3-> n/4;
        public IList<int> MajorityElement_Boyer_Moore(int[] nums)
        {
            int? can1 = null;
            int? can2 = null;
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(can1 !=null && can1 == nums[i])
                {
                    count1++;
                }else if( can2 != null && can2 == nums[i])
                {
                    count2++;
                }else if( count1 == 0)
                {
                    can1 = nums[i];
                    count1++;
                }else if( count2 == 0)
                {
                    can2 = nums[i];
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }

            }

            count1 = 0;
            count2 = 0;
            for(int i =0; i  < nums.Length; i++)
            {
                if (nums[i] == can1) count1++;
                if (nums[i] == can2) count2++;
            }
            IList<int> list = new List<int>() { };
            if (count1 > nums.Length / 3) list.Add((int)can1);
            if (count2 > nums.Length / 3) list.Add((int)can2);
            return list;
        }

        #endregion

        #region 08/16/2023
        public IList<int> MajorityElement_20230816(int[] nums)
        {
            if (nums.Length == 1) return new List<int>() { nums[0] };
            Array.Sort(nums);

            IList<int> list = new List<int>();
            int start = 0;
            int number = nums[0];
            int bounded = nums.Length / 3;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != number)
                {
                    if (i - start > bounded)
                    {
                        list.Add(number);
                    }
                    start = i;
                    number = nums[i];
                    if (i == nums.Length - 1)
                    {
                        if (i - start + 1 > bounded)
                        {
                            list.Add(number);
                        }
                    }
                }
                else if (i == nums.Length - 1)
                {
                    if (i - start + 1 > bounded)
                    {
                        list.Add(number);
                    }
                }
            }
            return list;


        }
        #endregion

        public string test(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            StringBuilder sb = new StringBuilder() { };

            foreach (var k in dic.Keys)
            {
                sb.Append(k);
                sb.Append('=');
                sb.Append(dic[k]);
                sb.Append(',');
            }

            string answer = sb.ToString();
            if (answer.LastIndexOf(',') == answer.Length - 1)
            {
                answer = answer.Substring(0, answer.Length - 1);
            }


            return answer;

        }

        public string test2(string s)
        {
            int[] arr = new int[26];
            for(int i = 0; i < 26; i++)
            {
                arr[i] = 0;
            }
   
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            StringBuilder sb = new StringBuilder() { };

            foreach (var k in dic.Keys)
            {
                sb.Append(k);
                sb.Append('=');
                sb.Append(dic[k]);
                sb.Append(',');
            }

            string answer = sb.ToString();
            if (answer.LastIndexOf(',') == answer.Length - 1)
            {
                answer = answer.Substring(0, answer.Length - 1);
            }


            return answer;

        }

    }
}
