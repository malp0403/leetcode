using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace leetcode.Problems_2001_2500
{
    public class _2028
    {

        #region attempt
        int totalCount;
        List<int> result = new List<int>() { };
        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            long total = 0;
            for(int i =0; i < rolls.Length; i++)
            {
                total += rolls[i];

            }
            long remaining = mean * (rolls.Length + n) - total;
            if(remaining < 0)
            {
                return new int[] { };
            }
            int average = (int)remaining / n;
            int rem = (int) remaining % n;
            int div = n - rem;

            if(average >6 || (average == 6 && rem !=0) | average == 0)
            {
                return new int[] { };
            }

            List<int> result = new List<int>() { };
            while (rem !=0)
            {
                result.Add(average + 1);
                rem--;
            }
            while(div != 0)
            {
                result.Add(average);
                div--;
            }

            return result.ToArray();


        }
        public void helper(List<int> temp, long curSum,int left,List<int> missings,int target)
        {
            if(left == 0)
            {
                if((int)(curSum/totalCount) == target && curSum% totalCount == 0)
                {
                    result = temp.Select(x => x).ToList();
                }
                return;
            }
            for(int i = missings.Count-1; i >=0; i--)
            {
                temp.Add(missings[i]);
                helper(temp, curSum + missings[i], left - 1, missings, target);
                temp.RemoveAt(temp.Count - 1);
            }
        }
        #endregion
    }
}

#region Test
//var res3 = obj3.MissingRolls(new int[] { 3, 2, 4, 3 }, 4, 2); =>[6,6]
//var res3 = obj3.MissingRolls(new int[] { 1, 5, 6 }, 3, 4); = >[2,3,2,2]

#endregion
