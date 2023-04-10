using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500
{
    public class _2096
    {
        public static long max = 0;
        public static HashSet<string> all = new HashSet<string>();
        #region My Solution
        Dictionary<TreeNode, TreeNode> parents = new Dictionary<TreeNode, TreeNode>();
        int min = int.MaxValue;
        string answer = string.Empty;
        int startValue;
        int destValue;
        public string GetDrections(TreeNode root, int startValue, int destValue)
        {
            this.startValue = startValue;
            this.destValue = destValue;
            TreeNode n = root;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(n);
            TreeNode startNode = new TreeNode(startValue);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                while (count > 0)
                {
                    TreeNode temp = queue.Dequeue();
                    if(temp.val == startValue)
                    {
                        startNode = temp;
                    }
                    if (temp.right != null)
                    {
                        parents.Add(temp.right, temp);
                        queue.Enqueue(temp.right);
                    }
                    if (temp.left != null)
                    {
                        parents.Add(temp.left, temp);
                        queue.Enqueue(temp.left);
                    }
                    count--;
                }
            }

            helper(startNode, 0, new StringBuilder() { }, new HashSet<TreeNode>() { });

            return answer;


        }
        public void helper(TreeNode n, int sum, StringBuilder sb, HashSet<TreeNode> set)
        {
            if (n.val == destValue)
            {
                if (sum < min)
                {
                    answer = sb.ToString();
                }
                return;
            }
            if (set.Contains(n)) return;

            set.Add(n);

            //to up
            if (parents.ContainsKey(n))
            {
                sb.Append('U');
                helper(parents[n], sum + n.val, sb, set);
                sb.Remove(sb.Length - 1, 1);
            }
            //to right
            if (n.right != null)
            {
                sb.Append('R');
                helper(n.right, sum + n.val, sb, set);
                sb.Remove(sb.Length - 1, 1);
            }
            //to left;
            if (n.left != null)
            {
                sb.Append('L');
                helper(n.left, sum + n.val, sb, set);
                sb.Remove(sb.Length - 1, 1);
            }

            set.Remove(n);
        }
        #endregion

        #region Attempt 03-05-2023
        bool isStartFound = false;
        bool isEndFound = false;
        string startString = "";
        string endString = "";
        public string GetDirections_20230305(TreeNode root, int startValue, int destValue)
        {
         
            helper_20230305(root, new StringBuilder(), startValue, destValue);


            int indx = 0;
            while(indx < Math.Min(startString.Length, endString.Length))
            {
                if (startString[indx] != endString[indx]) { break; }
                indx++;
            }
            string s = startString.Substring(indx);
            string l = endString.Substring(indx);

            string result = "";
            for(int i = indx; i < startString.Length; i++)
            {
                result += "U";
            }
            result += l;
            return result;
           

        }
        public void helper_20230305(TreeNode n,StringBuilder curString,int start,int end)
        {
            if (isEndFound && isStartFound) return;
            if (n == null) return;
            if(n.val == start)
            {
                isStartFound = true;
                startString = curString.ToString();
            }
            if(n.val == end)
            {
                isEndFound = true;
                endString = curString.ToString();
            }
            curString.Append("L");
            helper_20230305(n.left, curString, start,end);
            curString.Remove(curString.Length - 1,1);

            curString.Append("R");
            helper_20230305(n.right, curString,start,end);
            curString.Remove(curString.Length - 1, 1);
        }



        #endregion

        #region Attempt 03-05-2023
        public string GetDirections_20230306(TreeNode root, int startValue, int destValue)
        {

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            helper_20230306(root,startValue, sb1);
            helper_20230306(root, destValue, sb2);


            var s3 = new string(sb1.ToString().ToCharArray().Reverse().ToArray());
            var s4 = new string(sb2.ToString().ToCharArray().Reverse().ToArray());
            int len = Math.Min(s3.Length, s4.Length);

            int index = 0;
            string result = "";
            while (index < len)
            {
                if (s3[index] != s4[index]) break;
                index++;
            }

            for(int i = index;i< s3.Length; i++)
            {
                result += "U";
            }
            result += s4.Substring(index);

            return result;
        }
        public bool helper_20230306(TreeNode node,int targetValue,StringBuilder s)
        {
            if(node.val == targetValue)
            {
                return true;
            }else if(node.left !=null && helper_20230306(node.left, targetValue,s))
            {
                s.Append("L");
            }else if(node.right !=null && helper_20230306(node.right, targetValue, s))
            {
                 s.Append("R");
            }
            return s.Length != 0;
        }
        #endregion

        #region Attempt 03-29-2023
        bool isFound_0329 = false;
        string start_0329 = "";
        string dest_0329 = "";
        public string testtest()
        {
            string s = "";
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://jsonmock.hackerrank.com/api/countries?name=Puerto Rico").GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    s = responseContent.ReadAsStringAsync().GetAwaiter().GetResult();
                }
            }
            var test = JsonSerializer.Deserialize<responseObj>(s);
            if (test.data.Length == 0 || test.data[0].callingCodes.Length == 0) return "-1";
            var test2 = test.data[0].callingCodes[test.data[0].callingCodes.Length-1] + " " ;
            return test2;
            ;
            //        var client = new HttpClient();
            //        var request = new HttpRequestMessage(HttpMethod.Get, "https://jsonmock.hackerrank.com/api/countries?name=Afghanistan");
            //        var response = await client.Send(request);
            //        response.EnsureSuccessStatusCode();
            //        Console.WriteLine(await response.Content.ReadAsStringAsync());

            //        var json = await response.Content.ReadAsStringAsync();
            //        responseObj test = new responseObj();
            //        try
            //        {
            //            test =
            //JsonSerializer.Deserialize<responseObj>(json);
            //        }
            //        catch(Exception ex)
            //        {

            //        }


        }
        class responseObj
        {
            public responseData[] data { get; set; }
        }
        class responseData
        {
            public string[] callingCodes { get; set; }
        }

        public string GetDirections_20230329(TreeNode root, int startValue, int destValue)
        {
            helper_03292023(root, new StringBuilder() { }, startValue,ref start_0329);
            this.isFound_0329 = false;
            helper_03292023(root, new StringBuilder() { }, destValue,ref  dest_0329);

            int i = 0;
            while(i<start_0329.Length && i<dest_0329.Length)
            {
                if (start_0329[i] == dest_0329[i])
                {
                    i++;
                }
                else
                {
                    break;
                }

            }
            start_0329 = start_0329.Substring(i);
            dest_0329 = dest_0329.Substring(i);

            StringBuilder start = new StringBuilder() { };
            for(int j =0; j < start_0329.Length; j++)
            {
                start.Append("U");
            }

            return start.ToString() + dest_0329;
        }
        public void helper_03292023(TreeNode root, StringBuilder s,int target,ref string route)
        {
            if (root == null) return;
            if (this.isFound_0329) return;
            if(root.val == target)
            {
                route = s.ToString();
                return;
            }
            s.Append("L");
            helper_03292023(root.left, s, target,ref route);
            s.Remove(s.Length - 1, 1);
            s.Append("R");
            helper_03292023(root.right, s, target,ref route);
            s.Remove(s.Length - 1, 1);
        }

        #endregion
        #region test case
        //TreeNode t5 = new TreeNode(5);
        //TreeNode t1 = new TreeNode(1);
        //TreeNode t2 = new TreeNode(2);
        //TreeNode t3 = new TreeNode(3);
        //TreeNode t4 = new TreeNode(4);
        //TreeNode t6 = new TreeNode(6);
        //t5.left = t1;
        //    t5.right = t2;
        //    t1.left = t3;
        //    t2.left = t6;
        //    t2.right = t4;
        //var obj = new _2096() { };
        //obj.GetDirections_20230305(t5,3,6);


        #endregion
    }
    }
