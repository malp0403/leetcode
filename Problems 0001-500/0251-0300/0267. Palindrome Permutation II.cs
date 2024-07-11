using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
#region Test Case
/*
 
             var obj = new _0267();
            obj.GeneratePalindromes_2024_07_09("a");

            obj.GeneratePalindromes_2024_07_09("aabb");
 */
#endregion
namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0267
    {
        #region 07/09/2024
        IList<string> answer_2024_07_09 = new List<string>();
        public IList<string> GeneratePalindromes_2024_07_09(string s)
        {
            if(s.Length == 1)
            {
                answer_2024_07_09.Add(s);
                return answer_2024_07_09;
                
            }
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach (char c in s)
            {
                arr[c - 'a']++;
            }
            int singleCount = 0;
            string element = "";

            for(int i =0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 1)
                {
                    singleCount++;
                    element = ((char)('a' + i)).ToString();
                }
            }

            if(singleCount >=2) return new List<string>();
            dfs_2024_07_09(arr, new StringBuilder(), s.Length);

            answer_2024_07_09 = answer_2024_07_09.Select(x => {
                char[] charArray = x.ToCharArray();
                Array.Reverse(charArray);
             
                var test = x + element + new string(charArray);
                return   test ;
            } ).ToList();

            return answer_2024_07_09;

        }

        public void dfs_2024_07_09(int[] arr, StringBuilder sb,int total)
        {
            if(sb.Length == total / 2)
            {
                answer_2024_07_09.Add(sb.ToString());
                return;
            }
            for(int i =0; i < arr.Length; i++)
            {

                if (arr[i] >= 2)
                {

                    sb.Append( (char)(i + 'a'));
                    arr[i] -= 2;

                    dfs_2024_07_09(arr, sb, total);
                    arr[i] += 2;
                    sb.Remove(sb.Length - 1, 1);
                }


            }

        }
        #endregion
    }
}
