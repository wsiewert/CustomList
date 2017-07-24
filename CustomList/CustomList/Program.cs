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
            List<string> listOne = new List<string>() { "Hello" };
            List<string> listTwo = new List<string>() { " World" };
            Console.WriteLine(listOne);
            Console.WriteLine(listTwo);
            Console.WriteLine(listOne.Concat(listTwo));
            Console.ReadLine();
        }
    }
}
