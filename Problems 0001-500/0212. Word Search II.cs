using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0212
    {
        #region 07/07/2024
        //TrieNode_2 root = new TrieNode_2();
        //List<List<int>> dirs = new List<List<int>>()
        //{
        //                new List<int>(){1,0 },
        //    new List<int>(){ -1,0},
        //    new List<int>(){ 0,1},
        //    new List<int>(){ 0,-1}
        //};
        //public IList<string> FindWords(char[][] board, string[] words)
        //{
        //    bool[][] visited= new bool[board.Length][];
        //    for(int i =0; i < board.Length; i++)
        //    {
        //        visited[i] = Enumerable.Repeat(false, board[0].Length).ToArray();
        //    }

        //    for (int i =0; i <board.Length; i++) { 
        //        for(int j =0; j < board[i].Length; j++)
        //        {
        //            helper(i, j, board, visited, root);
        //        }
        //    }
        //    List<string> result = new List<string>();
        //    foreach (string word in words)
        //    {
        //        if (Search(word))
        //        {
        //            result.Add(word);
        //        }
        //    }
        //    return result;

        //}
        //public bool Search(string str)
        //{
        //    TrieNode_2 node = root;
        //    for(int i =0; i < str.Length; i++)
        //    {
        //        if (!node.containsKey(str[i]))
        //        {
        //            return false;
        //        }
        //        node = node.get(str[i]);
        //    }
        //    return node != null;
        //}
        //public void helper(int i ,int j, char[][] board, bool[][] visited,TrieNode_2 node)
        //{
        //    if (visited[i][j]) return;
        //    if( i <0 || i >= board.Length || j <0 || j >= board[0].Length) return;

        //    visited[i][j] = true;
        //    char c = board[i][j];
        //    if (!node.containsKey(c))
        //    {
        //        node.put(c, new TrieNode_2());
        //    }
        //    node = node.get(c);

        //    foreach (var item in dirs)
        //    {
        //        int row = i + item[0];
        //        int col = j + item[1];
        //        helper(row,col,board,visited, node);
        //    }
        //    visited[i][j] = false;


        //}

        public class TrieNode_2
        {
            public TrieNode_2[] links;
            public bool isEnd = false;
            public TrieNode_2()
            {
                links = Enumerable.Repeat<TrieNode_2>(null, 26).ToArray();
            }
            public bool containsKey(char c)
            {
                return links[c - 'a'] != null;
            }
            public void put(char c,TrieNode_2 node)
            {
                links[c - 'a'] = node;
            }
            public TrieNode_2 get(char c)
            {
                return links[c - 'a'];
            }
            public void setEnd()
            {
                this.isEnd = true;
            }
            public bool getEnd()
            {
                return this.isEnd;
            }


        }
        #endregion


    }
}
