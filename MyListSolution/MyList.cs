using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListSolution
{
    public class MyList<T> //: IEnumerable<T>
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
                if (array[i].Equals(item))
                {
                    array[i] = array[i + 1];
                    count--;
                }
            }                                 
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public static MyList<T> operator +(MyList<T> one, MyList<T> two)
        {
            MyList<T> listsTogether = new MyList<T>();
            for (int i = 0; i < one.count; i++)
            {
                listsTogether.Add(one[i]);
            }
            for (int i = 0; i < two.count; i++)
            {
                listsTogether.Add(two[i]);
            }
            
            return listsTogether;
            
            
        }
        public static MyList<T> operator -(MyList<T> one, MyList<T> two)
        {
            MyList<T> listsTogether = new MyList<T>();
            return one;
        }
        
        public MyList<T> Zip(MyList<T> twoList)
        {
            if (this.count == twoList.count)
            {
                for (int i = 1; i < count; i + 2)
                {
                    
                }
            }
        }
       
        public void DisplayInfo()
        {
            
        }
        
    }
}
