using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
#region Test
/*
             var obj = new _0146(2) { };
            obj.Put(1, 1);
            obj.Put(2, 2);
            obj.Get(1);
            obj.Put(3, 3);
            obj.Get(2);
            obj.Put(4, 4);
            obj.Get(1); obj.Get(3); obj.Get(4);

 */
#endregion
namespace leetcode.Problems
{
    class _0146
    {
        #region my try

        //Dictionary<int, int> dic = new Dictionary<int, int>() { };
        //List<int> li = new List<int>() { };
        //int capacity = 0;

        //public _0146(int capacity)
        //{
        //    this.capacity = capacity;
        //}

        //public int Get(int key)
        //{
        //    if (dic.ContainsKey(key))
        //    {
        //        li.Remove(key);
        //        li.Add(key);
        //        return dic[key];
        //    }
        //    return -1;

        //}

        //public void Put(int key, int value)
        //{
        //    if (dic.ContainsKey(key))
        //    {
        //        dic[key] = value;
        //    }
        //    else
        //    {
        //        dic.Add(key, value);
        //    }

        //    if (li.Count >= capacity && !li.Contains(key))
        //    {
        //        //remove first element;
        //        int k = li[0];
        //        dic.Remove(k);
        //        li.RemoveAt(0);
        //    }
        //    if (li.Contains(key))
        //    {
        //        li.Remove(key);
        //    }
        //    li.Add(key);

        //}
        #endregion

        #region 12/29/2022
        //Dictionary<int, int> dic;
        //List<int> list;
        //int _capacity;
        //public _0146(int capacity)
        //{
        //    _capacity = capacity;
        //    dic = new Dictionary<int, int>() { };
        //    list = new List<int>() { };
        //}
        //public int Get(int key)
        //{
        //    if (dic.ContainsKey(key)) {
        //        list.Remove(key);
        //        list.Add(key);
        //        return dic[key];
        //    }
        //    return -1;
        //}

        //public void Put(int key, int value)
        //{
        //    if(list.Count < _capacity || dic.ContainsKey(key))
        //    {
        //        if (dic.ContainsKey(key))
        //        {
        //            dic[key] = value;
        //            list.Remove(key);
        //        }
        //        else
        //        {
        //            dic.Add(key, value);
        //        }
        //        list.Add(key);
        //    }
        //    else
        //    {
        //        int remove = list[0];
        //        dic.Remove(remove);
        //        list.Remove(remove);

        //        dic.Add(key, value);
        //        list.Add(key);
        //    }
        //}
        #endregion

        #region 08/11/2023
        //int capacity_20230811;
        //Dictionary<int, int> dict_20230811;
        //List<int> list_20230811;
        //public _0146(int capacity)
        //{
        //    capacity_20230811 = capacity;
        //     dict_20230811 = new Dictionary<int,int>();
        //    list_20230811 = new List<int>();
        //}

        //public int Get(int key)
        //{
        //    if (dict_20230811.ContainsKey(key)) {
        //        list_20230811.Remove(key);
        //        list_20230811.Add(key);
        //        return dict_20230811[key];
        //    }

        //    return -1;
        //}

        //public void Put(int key, int value)
        //{

        //    if (dict_20230811.ContainsKey(key))
        //    {
        //        dict_20230811[key] = value;
        //        list_20230811.Remove(key);
        //        list_20230811.Add(key);
        //    }
        //    else {
        //        if(list_20230811.Count >= capacity_20230811)
        //        {
        //            int tomoved = list_20230811[0];
        //            list_20230811.Remove(tomoved);
        //            dict_20230811.Remove(tomoved);

        //            list_20230811.Add(key);
        //            dict_20230811.Add(key, value);
        //        }
        //        else
        //        {
        //            list_20230811.Add(key);
        //            dict_20230811.Add(key, value);
        //        }

        //    }

        //}
        #endregion

        #region 08/11/2023 double linked node
        //int capacity;
        //Dictionary<int, Node_> dic = new Dictionary<int, Node_>();
        //Node_ head;
        //Node_ tail;
        //public _0146(int capacity)
        //{
        //    this.capacity = capacity;
        //    this.head = new Node_(-1,-1);
        //    this.tail = new Node_(-1, -1);
        //    this.head.next = tail;
        //    tail.prev = head;
        //}

        //public int Get(int key)
        //{
        //    if (dic.ContainsKey(key))
        //    {
        //        Node_ n = dic[key];
        //        remove(n);
        //        add(n);
        //        return n.val;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

        //public void Put(int key, int value)
        //{
        //    if(dic.ContainsKey(key))
        //    {
        //        remove(dic[key]);
        //        dic[key] = new Node_(key, value);
        //        add(dic[key]);
        //    }
        //    else
        //    {
        //        if(dic.Count >= capacity)
        //        {
        //            Node_ removed = this.head.next;
        //            dic.Remove(removed.key);
        //            remove(removed);
        //        }
        //            Node_ toadd = new Node_(key, value);
        //            dic.Add(key, toadd);
        //            add(toadd);


        //    }
        //}
        //public void remove(Node_ remove)
        //{
        //    remove.prev.next = remove.next;
        //    remove.next.prev = remove.prev;
        //}
        //public void add(Node_ add)
        //{
        //    Node_ previousEnd = tail.prev;
        //    previousEnd.next = add;
        //    add.prev = previousEnd;
        //    add.next = tail;
        //    tail.prev = add;
        //}
        #endregion

        #region 03/27/2024
        /*
        int capacity;
        Dictionary<int, Node_> dic = new Dictionary<int, Node_>();
        Node_ head;
        Node_ tail;
        public _0146(int capacity)
        {
            this.capacity = capacity;
            this.head = new Node_(-1, -1);
            this.tail = new Node_(-1, -1);
            this.head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            if (dic.ContainsKey(key))
            {
                Node_ n = dic[key];
                remove(n);
                add(n);
                return dic[key].val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (dic.ContainsKey(key))
            {

                remove(dic[key]);
                dic[key] = new Node_(key, value);
                add(dic[key]);
            }
            else
            {
                if (dic.Count >= capacity)
                {
                    var temp = head.next;
                    remove(temp);
                    dic.Remove(temp.key);
                }
                Node_ toAdd = new Node_(key, value);
                add(toAdd);
                dic.Add(key, toAdd);
            }
        }
        public void remove(Node_ remove)
        {
            remove.prev.next = remove.next;
            remove.next.prev = remove.prev;

        }
        public void add(Node_ add)
        {
            Node_ _PrevEnd = this.tail.prev;
            _PrevEnd.next = add;
            add.prev = _PrevEnd;
            add.next = tail;
            tail.prev = add;
        }

        */
        #endregion

        #region 10/06/2024 double linked node
        /*
        int _capacity;
        Dictionary<int, Node_> dic = new Dictionary<int, Node_>();
        Node_ head;
        Node_ tail;
        public _0146(int capacity)
        {
            head = new Node_(-1, -1);
            tail = new Node_(-2, -2);

            head.next = tail;
            tail.prev = head;
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (dic.ContainsKey(key))
            {
                Node_ node = dic[key];
                remove(node.key);
                add(node.key, node.val);
                return node.val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (dic.ContainsKey(key))
            {
                remove(key);
                add(key, value);

            }
            else
            {
                if (dic.Count >= _capacity)
                {
                    remove(head.next.key);

                }
                add(key, value);

            }



        }
        public void add(int key, int val)
        {
            Node_ newNode = new Node_(key, val);
            dic.Add(key, newNode);

            Node_ oldPrev = tail.prev;

            tail.prev = newNode;
            newNode.next = tail;

            oldPrev.next = newNode;
            newNode.prev = oldPrev;
        }
        public void remove(int key)
        {
            Node_ toRemove = dic[key];
            toRemove.next.prev = toRemove.prev;
            toRemove.prev.next = toRemove.next;

            dic.Remove(key);


        }
        */
        #endregion





    }
}

public class Node_
{
    public int key;
    public int val;
    public Node_ next;
    public Node_ prev;

    public Node_(int key, int val)
    {
        this.key = key;
        this.val = val;
    }

}
