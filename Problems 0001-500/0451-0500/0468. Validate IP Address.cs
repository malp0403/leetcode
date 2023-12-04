using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a string queryIP, return "IPv4" if IP is a valid IPv4 address, "IPv6" if IP is a valid IPv6 address or "Neither" if IP is not a correct IP of any type.

A valid IPv4 address is an IP in the form "x1.x2.x3.x4" where 0 <= xi <= 255 and xi cannot contain leading zeros. For example, "192.168.1.1" and "192.168.1.0" are valid IPv4 addresses while "192.168.01.1", "192.168.1.00", and "192.168@1.1" are invalid IPv4 addresses.

A valid IPv6 address is an IP in the form "x1:x2:x3:x4:x5:x6:x7:x8" where:

1 <= xi.length <= 4
xi is a hexadecimal string which may contain digits, lowercase English letter ('a' to 'f') and upper-case English letters ('A' to 'F').
Leading zeros are allowed in xi.
For example, "2001:0db8:85a3:0000:0000:8a2e:0370:7334" and "2001:db8:85a3:0:0:8A2E:0370:7334" are valid IPv6 addresses, while "2001:0db8:85a3::8A2E:037j:7334" and "02001:0db8:85a3:0000:0000:8a2e:0370:7334" are invalid IPv6 addresses.

 

Example 1:

Input: queryIP = "172.16.254.1"
Output: "IPv4"
Explanation: This is a valid IPv4 address, return "IPv4".
Example 2:

Input: queryIP = "2001:0db8:85a3:0:0:8A2E:0370:7334"
Output: "IPv6"
Explanation: This is a valid IPv6 address, return "IPv6".
Example 3:

Input: queryIP = "256.256.256.256"
Output: "Neither"
Explanation: This is neither a IPv4 address nor a IPv6 address.
 

Constraints:

queryIP consists only of English letters, digits and the characters '.' and ':'.
 */
#endregion
namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0468
    {
        #region 11/27/2023  check all situation.
        public string ValidIPAddress(string queryIP)
        {
     
            if (isValidIPv4(queryIP)) return "IPv4";
        
            if (isValidIPv6(queryIP)) return "IPv6";

            return "Neither";
        }
        public bool isValidIPv4(string s)
        {
            string[] arr = s.Split('.');
            if (arr.Length != 4) return false;

            for(int i =0; i < arr.Length; i++)
            {
                string temp = arr[i];
                if (temp.Length > 3) return false;
                foreach (var item in temp)
                {
                    if (!char.IsNumber(item)) return false;                
                }
                if(temp.Length > 1)
                {
                    if (temp[0] == '0') return false;
                }
                if (temp.Length == 0)
                {
                     return false;
                }
                if (int.Parse(temp) < 0 || int.Parse(temp) > 255) return false;
            }
            return true;
        }

        public bool isValidIPv6(string s)
        {
            string[] arr = s.Split(':');
            if (arr.Length != 8) return false;

            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i];
                foreach (var item in temp)
                {
                    if (char.IsNumber(item)) continue;
                    if (char.IsLetter(item))
                    {
                        if ((item - 'a' >= 0 && item - 'f' <= 0) || (item - 'A' >= 0 && item - 'F' <= 0))
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    };

                }
                if (temp.Length <1 || temp.Length >4)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
