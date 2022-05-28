using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class FindSmallestLetter
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            if (target - letters[letters.Length-1]>=0) return letters[0];

            int l = 0;
            int r = letters.Length - 1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (target - letters[mid] >= 0 && target - letters[mid + 1] < 0) return letters[mid + 1];
                else if (target - letters[mid] > 0) l = mid + 1;
                else r = mid;
            }
            return letters[l];
        }
    }
}
