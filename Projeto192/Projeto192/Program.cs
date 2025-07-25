﻿using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10 };

            SortedSet<int> b = new SortedSet<int>() {1, 3, 5, 6, 7, 8, 9, 10};

            // UNION

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrinterCollection(c);

            //INTERSECTION

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrinterCollection(d);

            //DIFFERENCE

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrinterCollection(e);
        }

        static void PrinterCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}