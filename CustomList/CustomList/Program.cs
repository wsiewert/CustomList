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
            CustomList<int> list = new CustomList<int>() { 10, 5, 9, 2 };
            list.Sort();
            string printThis = list.ToString();
            Console.WriteLine(printThis);
            Console.ReadKey();
        }
    }
}
