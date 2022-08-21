using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1233
    {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            IList<string> answer = new List<string>() { };

            List<MyNode> ans = new List<MyNode>() { };
            for(int i=0; i < folder.Length; i++)
            {
                string[] fs = folder[i].Split("/");

            }




            return answer;
        }
        public class MyNode
        {
            public List<MyNode> children;
            string filename;
            public MyNode(string filename, List<MyNode> children)
            {
                this.filename = filename;
                this.children = children;
            }
        }
    }
}
