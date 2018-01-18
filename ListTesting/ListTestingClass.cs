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
            numberTest.Add(numbers);
            //assert
            Assert.AreEqual(1, numberTest.Count);
        }
        [TestMethod]
        public void AddIntCountTestMediumSize()
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
            //assert
            Assert.AreEqual(8, numberTest.Count);
        }
        [TestMethod]
        public void AddIntTestLargeSize()
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

            //assert
            Assert.AreEqual(16, numberTest.Count);
        }
        [TestMethod]
        public void AddingStringTest()
        {
            //arrange
            MyList<string> stringAdd = new MyList<string>();
            stringAdd.Add("First add");
            stringAdd.Add("Second add");
            //act
            int adding = stringAdd.Count;
            //assert
            Assert.AreEqual(2, adding);
        }
        [TestMethod]
        public void AddingObject()
        {
            //arrange
            int addingNumberOfObjects = 16;
            MyList<TestingObjects> list = new MyList<TestingObjects>();
            //act
            TestingObjects objectList = new TestingObjects();
            for (int i = 0; i < addingNumberOfObjects; i++)
            {

                list.Add(objectList);

            }
            //arrange
            Assert.AreEqual(16, list.Count);

        }
        
        [TestMethod]
        public void RemoveIntCountTest()
        {
            //arrange
            MyList<int> removeTest = new MyList<int>();
            removeTest.Add(0);
            removeTest.Add(1);
            removeTest.Add(2);
            //act
            removeTest.Remove(2);
            //assert
            Assert.AreEqual(2, removeTest.Count);
        }
        [TestMethod]
        public void RemoveIntCountTestLarge()
        {
            //arrange
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
            //assert
            Assert.AreEqual(2, removeTest.Count);
        }
        
        [TestMethod]
        public void RemovingStringTest()
        {
            //arrange
            MyList<string> stringRemoveTest = new MyList<string>();
            stringRemoveTest.Add("First add");
            stringRemoveTest.Add("Second add");
            stringRemoveTest.Add("Third add");
            //act
            stringRemoveTest.Remove("First add");
            //assert
            Assert.AreEqual(2, stringRemoveTest.Count);
        }
        [TestMethod]
        public void RemovingStringTestLarge()
        {
            //arrange
            MyList<string> stringRemoveTest = new MyList<string>();
            stringRemoveTest.Add("First add");
            stringRemoveTest.Add("Second add");
            stringRemoveTest.Add("Third add");
            stringRemoveTest.Add("Fourth add");
            stringRemoveTest.Add("Fifth add");
            stringRemoveTest.Add("Sixth add");
            stringRemoveTest.Add("Seventh add");
            //act
            stringRemoveTest.Remove("First add");
            stringRemoveTest.Remove("Second add");
            stringRemoveTest.Remove("Third add");
            stringRemoveTest.Remove("Fourth add");
            //assert
            Assert.AreEqual(3, stringRemoveTest.Count);
        }
        /*
        [TestMethod]
        public void RemovingObject()
        {
            //arrange
            int addingNumberOfObjects = 16;
            MyList<TestingObjects> list = new MyList<TestingObjects>();
            //act
            TestingObjects objectList = new TestingObjects();
            for (int i = 0; i < addingNumberOfObjects; i++)
            {

                list.Add(objectList);

            }
            list.Remove(10);
            //arrange
            Assert.AreEqual(10, );

        }
        */
        [TestMethod]
        public void IndexCheckObject()
        {
            //arrange
            int addingNumberOfObjects = 16;
            MyList<object> list = new MyList<object>();
            //act
            TestingObjects objectList = new TestingObjects();
            for (int i = 0; i < addingNumberOfObjects; i++)
            {
     
                list.Add(objectList);

            }
           
            //arrange
            Assert.AreEqual(objectList, list[0]);
        }
        [TestMethod]
        public void ChekcingIndexInt()
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

            //assert
            Assert.AreEqual(10, numberTest[10]);
        }
        
        [TestMethod]
        public void CheckingIndexStringRemove()
        {
            //arrange
            MyList<string> stringRemoveTest = new MyList<string>();
            stringRemoveTest.Add("First add");//
            stringRemoveTest.Add("Second add");//
            stringRemoveTest.Add("Third add");//
            stringRemoveTest.Add("Fourth add");
            stringRemoveTest.Add("Fifth add");
            stringRemoveTest.Add("Sixth add");
            stringRemoveTest.Add("Seventh add");//
            //act
            stringRemoveTest.Remove("Second add");
            stringRemoveTest.Remove("First add");
            stringRemoveTest.Remove("Third add");
            stringRemoveTest.Remove("Seventh add");
            //assert
            Assert.AreEqual("Sixth add", stringRemoveTest[6]);
        }
        
        [TestMethod]
        public void OperatorPlusInt()
        {
            //arrange
            MyList<int> numberPlus1 = new MyList<int>();
            MyList<int> numberPlus2 = new MyList<int>();
            MyList<int> result;
            numberPlus1.Add(9);
            numberPlus1.Add(4);
            numberPlus1.Add(6);
            numberPlus2.Add(8);
            numberPlus2.Add(7);
            numberPlus2.Add(5);
            //act
            result = numberPlus1 + numberPlus2;
            //assert
            Assert.AreEqual(6, result.Count);
        }
        [TestMethod]
        public void OperatorPlusIndex()
        {
            //arrange
            MyList<int> numberPlus1 = new MyList<int>();
            MyList<int> numberPlus2 = new MyList<int>();
            MyList<int> result;
            numberPlus1.Add(9);
            numberPlus1.Add(4);
            numberPlus1.Add(6);
            numberPlus2.Add(8);
            numberPlus2.Add(7);
            numberPlus2.Add(5);
            //act
            result = numberPlus1 + numberPlus2;
            //assert
            Assert.AreEqual(8, result[3]);
        }
        [TestMethod]
        public void OperatorPlusString()
        {
            //arrange
            MyList<string> stringPlus1 = new MyList<string>();
            MyList<string> stringPlus2 = new MyList<string>();
            MyList<string> result;
            stringPlus1.Add("one");
            stringPlus1.Add("two");
            stringPlus1.Add("three");
            stringPlus2.Add("four");
            stringPlus2.Add("five");
            stringPlus2.Add("six");
            //act
            result = stringPlus1 + stringPlus2;
            //assert
            Assert.AreEqual(6, result.Count);

        }
        
        [TestMethod]
        public void OperatorMinusString()
        {
            //arrange
            MyList<string> stringPlus1 = new MyList<string>();
            MyList<string> stringPlus2 = new MyList<string>();
            MyList<string> result;
            stringPlus1.Add("one");
            stringPlus1.Add("two");
            stringPlus1.Add("three");
            stringPlus2.Add("four");
            stringPlus2.Add("five");
            stringPlus2.Add("six");
            //act
            result = stringPlus1 - stringPlus2;
            //assert
            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        public void OperatorMinusInt()
        {
            //arrange
            MyList<int> numberPlus1 = new MyList<int>();
            MyList<int> numberPlus2 = new MyList<int>();
            MyList<int> result;
            numberPlus1.Add(7);
            numberPlus1.Add(8);
            numberPlus1.Add(3);
            numberPlus2.Add(5);
            numberPlus2.Add(9);
            numberPlus2.Add(1);
            //act
            result = numberPlus1 - numberPlus2;
            //assert
            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        public void OperatorMinusIndex()
        {
            //arrange
            MyList<int> numberPlus1 = new MyList<int>();
            MyList<int> numberPlus2 = new MyList<int>();
            MyList<int> result;
            MyList<string> result2;
            numberPlus1.Add(7);
            numberPlus1.Add(8);
            numberPlus1.Add(3);
            numberPlus2.Add(5);
            numberPlus2.Add(9);
            numberPlus2.Add(1);
            //act
            result = numberPlus1 - numberPlus2;
            //assert
            Assert.AreEqual(9, result[4]);
        }
        
        [TestMethod]
        public void ZipIntTest()
        {
            //arrange
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
            //assert
            Assert.AreEqual(5, numberPlus1[1]);
        }
        [TestMethod]
        public void ZipStringTest()
        {
            //arrange
            MyList<string> numberPlus1 = new MyList<string>();
            MyList<string> numberPlus2 = new MyList<string>();
            numberPlus1.Add("six");
            numberPlus1.Add("four");
            numberPlus1.Add("two");
            numberPlus2.Add("five");
            numberPlus2.Add("three");
            numberPlus2.Add("one");
            //act
            numberPlus1.Zip(numberPlus2);
            //assert
            Assert.AreEqual("five", numberPlus1[1]);
        
        [TestMethod]
        public void toStringTest()
        {
            //arrange
            MyList<int> stringTest = new MyList<int>();
            stringTest.Add(5);
            stringTest.Add(7);
            stringTest.Add(8);
            stringTest.Add(10);
            //act
            string result = stringTest.ToString();
            //assert
            Assert.Equals("5 7 8 10", result);
            

        }
    }
}
