using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetcode.Problems
{
    class _0208
    {
        #region Solution
        long max = 0;
        public void test1()
        {
            List<int> singer = new List<int>() { 1, 2, 2 };
            List<int> length = new List<int>() { 2, 3, 2 };
            HashSet<int> singerIndxs = new HashSet<int>() { };
            HashSet<int> singerIds = new HashSet<int>() { };
            helper(singer, length, singerIndxs, singerIds, 0);

            var test = max;
            var ts = 123;

        }
        public void helper(List<int> singer, List<int> length, HashSet<int> singerIndxs, HashSet<int> singerIds, long cur)
        {
            if (singerIndxs.Count == singer.Count)
            {
                if (cur > max)
                {
                    max = cur;
                }
                return;
            }

            for (int i = 0; i < singer.Count; i++)
            {
                if (singerIndxs.Contains(i)) continue;
                singerIndxs.Add(i);
                if (singerIds.Contains(singer[i]))
                {
                    long product = singerIds.Count * length[i];
                    helper(singer, length, singerIndxs, singerIds, cur + product);
                }
                else
                {
                    singerIds.Add(singer[i]);
                    long product = singerIds.Count * length[i];
                    helper(singer, length, singerIndxs, singerIds, cur + product);
                    singerIds.Remove(singer[i]);
                }
                singerIndxs.Remove(i);

            }
        }
        #endregion

        //private TrieNode root;
        //public _0208()
        //{
        //    root = new TrieNode();
        //}

        //public void Insert(string word)
        //{
        //    TrieNode node = root;
        //    for(int i =0; i< word.Length; i++)
        //    {
        //        if (!node.containsKey(word[i]))
        //        {
        //            node.put(word[i], new TrieNode());
        //        }
        //        node = node.get(word[i]);
        //    }
        //    node.setEnd();
        //}
        //public TrieNode searchPrefix(string word)
        //{
        //    TrieNode node = root;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (node.containsKey(word[i]))
        //        {
        //            node = node.get(word[i]);
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    return node;
        //}

        //public bool Search(string word)
        //{
        //    TrieNode node = searchPrefix(word);
        //    return node != null && node.getIsEnd();

        //}

        //public bool StartsWith(string prefix)
        //{
        //    TrieNode node = searchPrefix(prefix);
        //    return node != null;
        //}



        //public class TrieNode
        //{
        //    private TrieNode[] links;
        //    private int R = 26;
        //    private bool isEnd = false;
        //    public TrieNode() {
        //        links = Enumerable.Repeat<TrieNode>(null, R).ToArray();
        //    }
        //    public bool containsKey(char ch)
        //    {
        //        return links[ch - 'a'] != null;
        //    }
        //    public TrieNode get(char ch)
        //    {
        //        return links[ch - 'a'];
        //    }
        //    public void put(char ch,TrieNode n)
        //    {
        //        links[ch - 'a'] = n;
        //    }
        //    public void setEnd()
        //    {
        //        isEnd = true;
        //    }
        //    public bool getIsEnd()
        //    {
        //        return isEnd;
        //    }
        //}

        #region 01/15/2022
        //01-15-2022----------------------------

        //private TrieNode root;
        //public _0208()
        //{
        //    root = new TrieNode();
        //}
        //public void Insert(string word)
        //{
        //    TrieNode node = root;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (!node.containsKey(word[i]))
        //        {
        //            node.put(word[i], new TrieNode());
        //        }
        //        node = node.get(word[i]);
        //    }
        //    node.setEnd();
        //}
        //public bool Search(string word)
        //{
        //    TrieNode node = SearchPrefix(word);
        //    return node != null && node.getIsEnd();
        //}

        //public TrieNode SearchPrefix(string word)
        //{
        //    TrieNode node = root;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (!node.containsKey(word[i]))
        //        {
        //            return null;
        //        }
        //        node = node.get(word[i]);
        //    }
        //    return node;
        //}
        //public bool StartsWith(string prefix)
        //{
        //    TrieNode node = SearchPrefix(prefix);
        //    return node != null;
        //}

        //public class TrieNode
        //{
        //    TrieNode[] links;
        //    int R = 26;
        //    bool isEnd = false;
        //    public TrieNode()
        //    {
        //        links = Enumerable.Repeat<TrieNode>(null, R).ToArray();
        //    }
        //    public bool containsKey(char ch)
        //    {
        //        return links[ch - 'a'] != null;
        //    }
        //    public TrieNode get(char ch)
        //    {
        //        return links[ch - 'a'];
        //    }
        //    public void put(char ch, TrieNode n)
        //    {
        //        links[ch - 'a'] = n;
        //    }
        //    public void setEnd()
        //    {
        //        isEnd = true;
        //    }
        //    public bool getIsEnd()
        //    {
        //        return isEnd;
        //    }
        //}
        #endregion

        #region 07/06/2024
        private TrieNode root;

        public _0208()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode node = root;
            for(int i =0; i < word.Length; i++)
            {
                char c = word[i];
                if (!node.containsKey(c))
                {
                    node.put(c, new TrieNode());
                }
                node = node.get(c);
            }
            node.setEnd();
        }

        public TrieNode SearchPrefix(string word)
        {
            TrieNode node = root;
            for(int i =0;i < word.Length; i++)
            {
                char c = word[i];
                if (node.containsKey(c))
                {
                    node = node.get(c);
                }
                else
                {
                    return null;
                }
            }
            return node;
        }

        public bool Search(string word)
        {
            TrieNode node = SearchPrefix(word);
            return node != null && node.getisEnd();
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = SearchPrefix(prefix);
            return node != null;
        }

        public class TrieNode
        {
            private TrieNode[] links;
            private int R = 26;
            private bool isEnd;

            public TrieNode()
            {
                links = Enumerable.Repeat<TrieNode>(null, R).ToArray();
            }

            public bool containsKey(char ch)
            {
                return links[ch - 'a'] != null;
            }

            public TrieNode get(char ch)
            {
                return links[ch-'a'];
            }

            public void put(char ch, TrieNode node)
            {
                links[ch - 'a'] = node;
            }
            public void setEnd()
            {
                this.isEnd = true;
            }
            public bool getisEnd()
            {
                return this.isEnd;
            }
        }
        #endregion
    }
}
