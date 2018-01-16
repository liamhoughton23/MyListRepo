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
        private int count;
        private int capacity;

        public MyList()
        {
            capacity = 4;
            array = new T[5];           
            count = Count;
           
            
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value;}
        }

        public int Count
        {
            get {return count; }
            
           
        }
        public void LargerArray()
        {
            T[] newArray = new T[capacity * 4];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
              
            }
            capacity = capacity * 4;
            array = newArray;
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                LargerArray();
                   
            }
            array[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if(array[i].Equals(item))
                {
                    array[i] = array[i + 1];
                    count--;
                }


            }
            
                
            
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
