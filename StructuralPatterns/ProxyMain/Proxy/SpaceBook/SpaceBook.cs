using System;
using System.Collections.Generic;

partial class SpaceBookSystem
{
    // The Subject
    private class SpaceBook
    {
        static SortedList<string, SpaceBook> community =
        new SortedList<string, SpaceBook>(100);
        string pages;
        string name;
        string gap = "\n\t\t\t\t";
        static public bool IsUnique(string name)
        {
            return community.ContainsKey(name);
        }
        internal SpaceBook(string n)
        {
            name = n;
            community[n] = this;
        }
        internal void Add(string s)
        {
            pages += gap + s;
            Console.Write(gap + "======== " + name + "'s SpaceBook =========");
            Console.Write(pages);
            Console.WriteLine(gap + "===================================");
        }
        internal void Add(string friend, string message)
        {
            community[friend].Add(message);
        }
        internal void Poke(string who, string friend)
        {
            community[who].pages += gap + friend + " poked you";
        }
    }
}