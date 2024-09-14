using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0412
    {
        #region Solution
        public IList<string> FizzBuzz(int n)
        {
            IList<string> list = new List<string>() { };
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }
        #endregion

        #region 09/05/2024
        public IList<string> FizzBuzz_2024_09_05(int n)
        {
            IList<string> list = new List<string>();

            for(int i =1; i <= n; i++)
            {
                StringBuilder str = new StringBuilder();
                if(i % 3 == 0)
                {
                    str.Append("Fizz");
                }
                if( i %5 ==0)
                {
                    str.Append("Buzz");
                }
                if(str.Length == 0)
                {
                    str.Append(i);
                }

                list.Add(str.ToString());



            }

            return list;
        }
        #endregion
    }
}
