using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0208
    {
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


        //01-15-2022----------------------------

        private TrieNode root;
        public _0208()
        {
            root = new TrieNode();
        }
        public void Insert(string word)
        {
            TrieNode node = root;
            for(int i = 0; i < word.Length; i++)
            {
                if (!node.containsKey(word[i]))
                {
                    node.put(word[i], new TrieNode());
                }
                node = node.get(word[i]);
            }
            node.setEnd();
        }
        public bool Search(string word)
        {
            TrieNode node = SearchPrefix(word);
            return node != null && node.getIsEnd();
        }

        public TrieNode SearchPrefix(string word)
        {
            TrieNode node = root;
            for(int i =0; i < word.Length; i++)
            {
                if (!node.containsKey(word[i]))
                {
                    return null;
                }
                node = node.get(word[i]);
            }
            return node;
        }
        public bool StartsWith(string prefix)
        {
            TrieNode node = SearchPrefix(prefix);
            return node != null;
        }

        public class TrieNode{
            TrieNode[] links;
            int R = 26;
            bool isEnd = false;
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
                return links[ch - 'a'];
            }
            public void put(char ch, TrieNode n)
            {
                links[ch - 'a'] = n;
            }
            public void setEnd()
            {
                isEnd = true;
            }
            public bool getIsEnd()
            {
                return isEnd;
            }
        }
    }
}
