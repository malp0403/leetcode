using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 11/07/2023
/*
 Given a string date representing a Gregorian calendar date formatted as YYYY-MM-DD, return the day number of the year.

 

Example 1:

Input: date = "2019-01-09"
Output: 9
Explanation: Given date is the 9th day of the year in 2019.
Example 2:

Input: date = "2019-02-10"
Output: 41
 

Constraints:

date.length == 10
date[4] == date[7] == '-', and all other date[i]'s are digits
date represents a calendar date between Jan 1st, 1900 and Dec 31th, 2019.
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1154
    {
        #region 11/07/2023
        public int DayOfYear_20231107(string date)
        {
            string[] strings = date.Split('-');
            int year = int.Parse(strings[0]);
            int month = int.Parse(strings[1]);
            int day = int.Parse(strings[2]);

            return new DateTime(year, month, day).DayOfYear;
        }
        #endregion
    }
}
