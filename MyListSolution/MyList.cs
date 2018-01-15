using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListSolution
{
    public class MyList<T>
    {
        T[] array;
        private int length;
        private int count;
        private int capacity;

        public MyList()
        {
            array = new T[5];
            capacity = 5;
            count = Count;
            length = Length;
            

        }


        public int Count
        {
            get {
                return count; }
           
        }
        
        public int Length
        {
            get { return length; }
            set {
                length = -1;
                length = value; }
        }
        public void LargerArray()
        {
            int newCapacity = capacity * 3;
            array = new T[newCapacity];
        }
        public void Add(T item)
        {
            if (count == 0)
            {
                array[0] = item;
                count++;
                length++;
            }
            else if (count > 0 && count < capacity)
            {
                length++;
                array[length] = item;
                count++;
            }
            else if (count >= capacity)
            {
                LargerArray();
                length++;
                array[length] = item;
                count++;
            }
        }

        public void Remove(T item)
        {
           
        }

        public void OverrideString()
        {
            //ability to change the toString thing that makes everything that is added into the list a string
        }
        public void OverLoadPlus()
        {

        }
        public void OverLoadMinus()
        {

        }
        public void ZipingTwoCustomClasses()
        {
            //create a new list to merge the two existing lists into one big list
            //make sure that they go into the right indexes, should be every other
        }

        public void Index(T item)
        {
            //check to see if the stuff added is at the right index
            //maybe an if statement 
        }
       
        public void DisplayInfo()
        {
            
        }
    }
}
