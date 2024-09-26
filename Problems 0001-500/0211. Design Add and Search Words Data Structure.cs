using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

#region Test Case
/*
             var obj = new _0211() { };
            obj.AddWord("bad");
            obj.AddWord("dad");
            obj.AddWord("mad");
            obj.Search(".ad");
            obj.Search("b..");
 */
#endregion

namespace leetcode.Problems
{

    class _0211
    {

        #region 07/06/2024


        TrieNode_1 root;
        public _0211()
        {
            root = new TrieNode_1();
        }

        public void AddWord(string word)
        {
            TrieNode_1 node = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (!node.containsKey(c))
                {
                    node.put(c, new TrieNode_1());
                }

                node = node.get(c);

            }
            node.setIsEnd();
        }

        public bool Search(string word)
        {
            return Search_helper(word, root);
        }

        public bool Search_helper(string word, TrieNode_1 node)
        {
   

            if (word.Length == 0) return node.getIsEnd();

            char c = word[0];


            if (c == '.')
            {
                bool isFound = false;
                for (int j = 0; j < node.links.Length; j++)
                {
                    if (node.links[j] != null)
                    {
                        isFound = isFound || Search_helper(word.Substring(1), node.links[j]);
                    }
                }

                return isFound;
            }
            else if (node.containsKey(c))
            {
                return Search_helper(word.Substring(1), node.get(c));
            }
            else
            {
                return false;
            }

        }


        public class TrieNode_1
        {
            public TrieNode_1[] links;
            int R = 27;
            bool isEnd = false;
            public TrieNode_1()
            {
                links = new TrieNode_1[R];
            }
            public bool containsKey(char key)
            {
               
                return links[key - 'a'] != null;
            }

            public void put(char c, TrieNode_1 node)
            {
                  links[c - 'a'] = node;
            }
            public TrieNode_1 get(char c)
            {
                return links[c - 'a'];
            }
            public bool getIsEnd()
            {
                return this.isEnd;
            }
            public void setIsEnd()
            {
                this.isEnd = true;
            }
        }
        #endregion
    };
}
