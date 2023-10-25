using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1951_2000
{
    internal class _1963
    {
        #region 10/10/2023 two linkedList
        public int MinSwaps(string s)
        {
             LinkedList<int> open = new LinkedList<int>();
            LinkedList<int> close = new LinkedList<int>();

            for (int i =0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    open.AddLast(i);
                }
                else
                {
                    close.AddLast(i);
                }
            }
            int count = 0;
            while(open.Count>0 && close.Count > 0)
            {
                if(open.First() < close.First())
                {
                    open.RemoveFirst();
                    close.RemoveFirst();
                }
                else
                {
                    close.RemoveFirst();
                    open.RemoveLast();
                    if (close.Count > 0)
                    {
                        close.RemoveFirst();
                        open.RemoveLast();
                    }
 
                    
                    count++;
                }

            }

            return count;
        }
        #endregion

        #region 10/10/2023 two pointers
        public int MinSwaps_20231010_twoPointers(string s)
        {
            int open = 0;
            int close = 0;
            int res = 0;
            int right = s.Length - 1;

            for(int left=0; left < right; left++)
            {
                if (s[left] == '[') open++;
                else close++;

                if (open >= close) continue;

                var backOpening = 0;
                var backClosing = 0;
                while(right >=0 && backClosing >= backOpening)
                {
                    if (s[right] == '[') backOpening++;
                    else backClosing++;

                    right--;
                }

                open++;
                close--;

                res++;

            }

            return res;
        }
        #endregion

        #region Solution3 20231010
        public int MinSwaps_20231010_twoPoints(string s)
        {
            if (s.Length == 0) return 0;

            int i = 0; 
            int j = s.Length - 1;
            int c = 0;
            int count = 0;

            char[] arr = s.ToCharArray();

            while (i < j)
            {
                while (arr[j]!= '[')
                {
                    j--;
                }
                if (arr[i] == '[') { c++; }
                else { c--; }

                if (c < 0)
                {
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    c += 2;
                    count++;
                }
                i++;
            }
            return count;

        }
        public string swap(string s,int i,int j)
        {
            char[] arr = s.ToCharArray();
            char c = arr[i];
            arr[i] = arr[j];
            arr[j] = c;
            return new string(arr);
        }
        #endregion


    }
}

#region Example
/*
 Example 1:

Input: s = "][]["
Output: 1
Explanation: You can make the string balanced by swapping index 0 with index 3.
The resulting string is "[[]]".
Example 2:

Input: s = "]]][[["
Output: 2
Explanation: You can do the following to make the string balanced:
- Swap index 0 with index 4. s = "[]][][".
- Swap index 1 with index 5. s = "[[][]]".
The resulting string is "[[][]]".
Example 3:

Input: s = "[]"
Output: 0
Explanation: The string is already balanced.
 */
#endregion