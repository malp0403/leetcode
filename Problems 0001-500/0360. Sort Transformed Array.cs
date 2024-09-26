using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0360
    {
        #region 09/01/2024
        public int[] SortTransformedArray(int[] nums, int a, int b, int c)
        {
            if (a == 0)
            {
                List<int> answer = new List<int>();
                foreach (var item in nums)
                {
                    answer.Add(cal(a, b, c,item));
                }
                if (b >= 0) return answer.ToArray();
                answer.Reverse();
                return answer.ToArray();
            }
            else
            {
                double val = -1.0 * b / (2 * a);
                int index = FindCloseIndex(nums, val);
                List<int> result = new List<int>();
                foreach (int i in nums)
                {
                    result.Add(cal(a, b, c, i));
                }

                List<int> answer = new List<int>();

                if (a > 0)
                {
                    answer.Add(result[index]);
                    int l = index - 1;
                    int r = index + 1;

                    while( l>=0 || r < result.Count)
                    {
                        if(l < 0)
                        {
                            answer.Add(result[r]);
                            r++;
                        }else if( r >= result.Count)
                        {
                            answer.Add(result[l]);
                            l--;
                        }
                        else
                        {
                            if(result[l] <= result[r])
                            {
                                answer.Add((int)result[l]);
                                l--;
                            }
                            else
                            {
                                answer.Add((int)result[r]);
                                r++;
                            }
                        }
                    }

                    return answer.ToArray();
                }
                else
                {
                    answer.Add(result[index]);
                    int l = index - 1;
                    int r = index + 1;

                    while (l >= 0 || r < result.Count)
                    {
                        if (l < 0)
                        {
                            answer.Add(result[r]);
                            r++;
                        }
                        else if (r >= result.Count)
                        {
                            answer.Add(result[l]);
                            l--;
                        }
                        else
                        {
                            if (result[l] <= result[r])
                            {
                                answer.Add((int)result[r]);
                                r++;
                            }
                            else
                            {
                                answer.Add((int)result[l]);
                                l--;
                            }
                        }
                    }
                   answer.Reverse();
                    return answer.ToArray();
                }




            }
        }

        public int FindCloseIndex(int[] nums, double val) {

            int index = 0;
            double gap = int.MaxValue;


           
            for(int i =0; i < nums.Length; i++)
            {
                double g = Math.Abs(nums[i] - val);
                if(g < gap)
                {
                    gap = g;
                    index = i;
                }
            }

            return index;


        }

        public int cal(int a,int b,int c,int x)
        {
            return a * x * x + b * x + c;
        }
        #endregion
    }
}
