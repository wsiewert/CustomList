using System;
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

            CustomList<string> foo = new CustomList<string>();
            foo.Add("hello");
            foo.Add("world");
            foo.Add("how");
            foo.Add("are");
            foo.Add("you?");
            foo.Remove("world");
            foo.Remove("GARBAGE");
            Console.WriteLine(foo.Count);
            Console.WriteLine(foo[0]);
            Console.WriteLine(foo[1]);
            Console.WriteLine(foo[2]);
            Console.WriteLine(foo[3]);

            Console.ReadKey();
        }
    }
}
