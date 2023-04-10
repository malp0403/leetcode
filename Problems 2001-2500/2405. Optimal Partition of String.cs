using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace leetcode.Problems_2001_2500
{
    internal class _2405
    {

        List<string> students = new List<string>(){};

        public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {


            List<string> students = New


            HashSet<string> prefixes = new HashSet<string>();



            foreach (string word in words)
            {
                if (word.Length < prefixLength) continue;
                string key = word.Substring(0, prefixLength);
                if (prefixes.Contains(key)) continue;
                prefixes.Add(key);
            }
            foreach (string word in prefixes)
            {
                yield return word;
            }

        }
        public class RentalTime
        {
            public DateTime Start { get; private set; }
            public DateTime End { get; private set; }



            public RentalTime(DateTime start, DateTime end)
            {
                this.Start = start;
                this.End = end;
            }
        }
        Dictionary<int, RentalTime> dic = new Dictionary<int, RentalTime>() { };
        public bool CanScheduleAll(IEnumerable<RentalTime> unloadingTimes)
        {

            var periods = unloadingTimes.ToList();

            var times = unloadingTimes.ToList();
            times.Sort((x, y) => DateTime.Compare(x.Start, y.Start));


            for (int i = 0; i < times.Count - 1; i++)
            {
                RentalTime next = times[i + 1];
                if (next.Start.CompareTo(times[i].End) < 0)
                {
                    return false;
                }
            }
            return true;
        }
    



    #region My Solution using set
    public int PartitionString(string s)
    {
        int start = 0;
        int count = 0;
        while (start < s.Length)
        {
            HashSet<char> set = new HashSet<char>();
            while (start < s.Length && !set.Contains(s[start]))
            {
                set.Add(s[start]);
                start++;
            }
            count++;
        }
        return count;
    }
    #endregion

    #region Solution using arr
    public int PartitionString_arr(string s)
    {
        int start = 0;
        int count = 0;
        while (start < s.Length)
        {
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            while (start < s.Length && arr[s[start] - 'a'] == 0)
            {
                arr[s[start] - 'a']++;
                start++;
            }
            count++;
        }
        return count;
    }
    #endregion

    #region Attemp 03/06/2023
    public int PartitionString_20230306(string s)
    {
        int start = 0;
        int count = 0;
        while (start < s.Length)
        {
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            while (start < s.Length && arr[s[start] - 'a'] == 0)
            {
                arr[s[start] - 'a']++;
                start++;
            }
            count++;
        }
        return count;
    }
    #endregion

    #region Attempt 03/29/2023
    public int PartitionString_20230329(string s)
    {
        int count = 0;
        int[] arr = Enumerable.Repeat(0, 26).ToArray();
        int index = 0;
        while (index < s.Length)
        {
            arr[s[index] - 'a']++;
            if (arr[s[index] - 'a'] > 0)
            {
                count++;
                arr = Enumerable.Repeat(0, 26).ToArray();
                arr[arr[index] - 'a']++;
            }
            if (index == s.Length - 1) { count++; }
            index++;
        }

        return count;

    }
    #endregion

}
}