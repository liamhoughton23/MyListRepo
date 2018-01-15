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
            Assert.AreEqual(1, numberTest.Length);
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
            Assert.AreEqual(8, numberTest.Length);
        }

        /*public void AddIntTestLargeSize()
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
            Assert.AreEqual(15, numberTest.Count);
        }

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

        public void RemovingStringTest()
        {
            //arrange
            MyList<string> stringRemoveTest = new MyList<string>();
            stringRemoveTest.Add("First add");
            stringRemoveTest.Add("Second add");
            stringRemoveTest.Add("Third add");
            //act
            stringRemoveTest.Remove("Second Add");
            //assert
            Assert.AreEqual(2, stringRemoveTest.Count);
        }

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
            stringRemoveTest.Remove("Second Add");
            stringRemoveTest.Remove("First add");
            stringRemoveTest.Remove("Third add");
            stringRemoveTest.Remove("Seventh add");
            //assert
            Assert.AreEqual(3, stringRemoveTest.Count);
        }

        public void RemovingObject()
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
            int remove = list.Remove(10);
            //arrange
            Assert.AreEqual(10, remove);

        }

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
            Assert.AreEqual(9, numberTest[10]);
        }

        public void CheckingIndexString()
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
            stringRemoveTest.Remove("Second Add");
            stringRemoveTest.Remove("First add");
            stringRemoveTest.Remove("Third add");
            stringRemoveTest.Remove("Seventh add");
            //assert
            Assert.AreEqual("sixth add", stringRemoveTest[2]);
        }
        public void CountTest()
        {

        }*/
    }
}
