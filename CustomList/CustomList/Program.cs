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
            //CustomList<int> customList = new CustomList<int>() { 1, 2 };
            //int result1 = customList.Compare(customList[0], customList[1]); // -1
            //int result2 = customList.Compare(customList[0], customList[0]); // 0
            //int result3 = customList.Compare(customList[1], customList[0]); // 1
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.ReadKey();

            //Sort test data
            //[5, 2, 1, 3, 4]
            //after 1 sort
            //[2, 1, 3, 4, 5]

            CustomList<int> list = new CustomList<int>() { 6, 2, 5, 4, 1, 3, 8, 1, 11, 99999, 123123, 4, 11, 43412, 5 };
            list.Sort();
            string printThis = list.ToString();
            Console.WriteLine(printThis);
            Console.ReadKey();
        }
    }
}
