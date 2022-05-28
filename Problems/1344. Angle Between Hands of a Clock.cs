using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1344
    {
        public double AngleClock(int hour, int minutes)
        {
            double minaverage = 360 / (60);

            double m = minutes * minaverage;
            double h = 30 * (hour % 12) + (minutes * 30.0) / 12;

            double sum= Math.Max(m, h) - Math.Min(m, h);
            return Math.Min(360 - sum, sum);
        }
        //01-11-2022---------------------------
        public double AngleClock_R2(int hour,int minutes)
        {
            double min = 6 * minutes;
            double h = 30 * (hour%12) + (minutes*0.5);

            double sum = Math.Max(min, h) - Math.Min(min, h);
            return Math.Min(360 - sum, sum);
        }
    }
}
