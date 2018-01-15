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
            //arrange
            MyList<int> numberTest = new MyList<int>();

            //act
            numberTest.Add(0);
            numberTest.Add(1);
            numberTest.Add(2);
            numberTest.Add(3);
            numberTest.Add(4);
            numberTest.Add(5);
            numberTest.Add(6);
            numberTest.Add(7);
            numberTest.Add(8);
            numberTest.Add(9);
            numberTest.Add(10);
            numberTest.Add(11);
            numberTest.Add(12);
            numberTest.Add(13);
            numberTest.Add(14);
            numberTest.Add(15);
        }
    }
}
