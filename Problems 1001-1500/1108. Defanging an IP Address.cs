using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1108
    {
        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");
            return address;
        }
        public string DefangIPaddr_v2(string address)
        {
            string ans = "";
            foreach(var s in address)
            {
                if(s == '.')
                {
                    ans += "[.]";
                }
                else
                {
                    ans += s.ToString();
                }
            }
            return ans;

        }
    }
}
