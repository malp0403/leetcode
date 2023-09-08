using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0273
    {
        #region 09/04/2023
        public string NumberToWords(int num)
        {

            if (num == 0) return "Zero";
            Dictionary<int, string> dic = new Dictionary<int, string>() { };
            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(3, "Three");
            dic.Add(4, "Four");
            dic.Add(5, "Five");
            dic.Add(6, "Six");
            dic.Add(7, "Seven");
            dic.Add(8, "Eight");
            dic.Add(9, "Nine");
            dic.Add(10, "Ten");
            dic.Add(11, "Eleven");
            dic.Add(12, "Twelve");
            dic.Add(13, "Thirteen");
            dic.Add(14, "Fourteen");
            dic.Add(15, "Fifteen");
            dic.Add(16, "Sixteen");
            dic.Add(17, "Seventeen");
            dic.Add(18, "Eighteen");
            dic.Add(19, "Nineteen");
            dic.Add(20, "Twenty");
            dic.Add(30, "Thirty");
            dic.Add(40, "Forty");
            dic.Add(50, "Fifty");
            dic.Add(60, "Sixty");
            dic.Add(70, "Seventy");
            dic.Add(80, "Eighty");
            dic.Add(90, "Ninety");

            int degree = 0;
            List<(string str,int degree )> list = new List<(string str, int degree)>() { };
            while(num != 0)
            {

                list.Add((helper(num % 1000, dic),degree));
       
                degree++;
                num = num / 1000;
            }

            string s = "";
            for(int i =list.Count-1; i >=0; i--)
            {
                var temp = list[i];
                if (temp.str  != " ")
                {
                    s += temp.str;

                    if (temp.degree == 3)
                    {
                        s += " " + "Billion" + " ";
                    }
                    else if (temp.degree == 2)
                    {
                        s += " " + "Million" + " ";
                    }
                    else if (temp.degree == 1)
                    {
                        s += " " + "Thousand" + " ";
                    }
                }
            }

            return s.Trim();


        }
        public string helper(int num,Dictionary<int,string> dic)
        {
            if (num == 0) return " ";
            StringBuilder sb = new StringBuilder();
            if(num/100 != 0)
            {
                sb.Append(dic[num / 100]);
                sb.Append(" ");
                sb.Append("Hundred");
                sb.Append(" ");
                sb.Append(helper(num % 100, dic));
            }
            else
            {
                int shiwei = num / 10;
                int geWei = num % 10;
                if(shiwei == 0 )
                {
                    if(geWei != 0)
                    {
                        sb.Append(dic[geWei]);
                    }
                }
                else
                {
                    if(shiwei == 1)
                    {
                        sb.Append(dic[num]);
                    }
                    else
                    {
                        sb.Append(dic[shiwei * 10]);
                        sb.Append(" ");

                        if (geWei != 0)
                        {
                            sb.Append(dic[geWei]);
                        }
                    }
                }
            }

            return sb.ToString().Trim();
        }
        #endregion
    }
}
