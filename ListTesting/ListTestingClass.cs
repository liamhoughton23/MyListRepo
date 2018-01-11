using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListSolution;

namespace ListTesting
{
    [TestClass]
    public class ListTestingClass
    {
        [TestMethod]
        public void AddIntCountTest()
        {
            //arrange
            MyList<int> numberTest = new MyList<int>();
            int numbers = 7;
            //act
            numberTest.AddingItem(numbers);
            //assert
            Assert.AreEqual(1, numberTest.Count);
        }
    }
}
