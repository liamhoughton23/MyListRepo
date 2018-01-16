using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> removeTest = new MyList<int>();
            removeTest.Add(0);
            removeTest.Add(1);
            removeTest.Add(2);
            removeTest.Add(3);
            removeTest.Add(4);
            //act
            removeTest.Remove(2);
            removeTest.Remove(3);
            removeTest.Remove(4);

            Console.ReadKey();


        }
    }
}
