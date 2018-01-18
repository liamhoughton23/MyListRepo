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
            MyList<int> numberPlus1 = new MyList<int>();
            MyList<int> numberPlus2 = new MyList<int>();
            numberPlus1.Add(7);
            numberPlus1.Add(8);
            numberPlus1.Add(3);
            numberPlus2.Add(5);
            numberPlus2.Add(9);
            numberPlus2.Add(1);
            //act
            numberPlus1.Zip(numberPlus2);
            
        }
    }
}
