using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _012
    {

        public string IntToRoman(int num)
        {
            return "";
        }

        public string formFormat(int num,int org)
        {
            //1
            int degree = 0;
            string low = "a";
            string middle = "b";
            string high = "c";
            while (org/10 >= 0)
            {
                degree++;
            }
            switch (degree)
            {
                case 0: low = "I"; middle = "V";high = "X";break;

            }

            switch (num)
            {
                case 1: return low;
                case 2: return low + low;
                case 3: return low + low + low;
                case 4: return low + middle;
                case 5: return middle;
                case 6: return middle + low;
                case 7: return middle + low + low;
                case 8: return middle + low + low + low;
                case 9: return low + high;
                default:
                    return "";
            }
        }
    }

}
