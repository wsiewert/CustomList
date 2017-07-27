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
            string x = "X";
            string o = "O";
            CustomList<string> list1 = new CustomList<string>() { o, o, o, o };
            CustomList<string> list2 = new CustomList<string>() { x, x, x, x, x, x, x, x, x, x, x, x, x };
            list1.Zip(list2);
            string printThis = list1.ToString();
            Console.WriteLine(printThis);
            Console.ReadKey();
        }
    }
}
