﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<string> foo = new CustomList<string>();
            //foo.Add("Hello");
            //foo.Add(" World");
            //Console.WriteLine(foo[0] + " " +foo[1]);
            //Console.ReadKey();

            //CustomList<string> foo = new CustomList<string>();
            //foo.Add("hello");
            //foo.Add("world");
            //foo.Add("how");
            //foo.Add("are");
            //foo.Add("you?");
            //foo.Remove("world");
            //foo.Remove("GARBAGE");
            //Console.WriteLine(foo.Count);
            //Console.WriteLine(foo[0]);
            //Console.WriteLine(foo[1]);
            //Console.WriteLine(foo[2]);
            //Console.WriteLine(foo[3]);

            //foreach (var item in foo)
            //{
            //    Console.WriteLine(item);
            //}

            CustomList<string> list1 = new CustomList<string>();
            list1.Add("hello");
            CustomList<string> list2 = new CustomList<string>();
            list2.Add("world");
            CustomList<string> list3 = new CustomList<string>();
            list2.Add("!");
            CustomList<string> list4 = list1 + list2 + list3;
            string printThis = list4[0] + list4[1] + list4[2];


            Console.WriteLine("__________________");
            Console.WriteLine(printThis);

            Console.ReadKey();
        }
    }
}
