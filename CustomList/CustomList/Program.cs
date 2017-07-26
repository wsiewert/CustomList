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
            Random object1 = new Random();
            Random object2 = new Random();
            CustomList<Random> foo = new CustomList<Random>() { object1, object2 };
            Console.WriteLine(foo.ToString());
            Console.WriteLine(object1.GetType());
            Console.ReadKey();
        }
    }
}
