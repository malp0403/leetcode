using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1871
    {

        public bool CanReach(string s, int minJump, int maxJump)
        {
            Queue<int> indexs = new Queue<int>() { };
            indexs.Enqueue(0);
            int i = 1;
            while(i < s.Length)
            {
                if(indexs.Count == 0) return false;
                if(i >=indexs.Peek()+minJump && i <= indexs.Peek()+maxJump && s[i] == '0')
                {
                    indexs.Enqueue(i);
                }
                if(i == indexs.Peek() + maxJump)
                {
                    indexs.Dequeue();
                }
                i++;
            }
            while (indexs.Count != 0)
            {
                int n = indexs.Dequeue();
                if (n == s.Length - 1) return true;
            }
            return false;
        }

        
    }
}
