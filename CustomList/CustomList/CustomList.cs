using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        //T[] customArray = new T[] { };
        T[] customArray;
        int count;

        public T this[int index] {   get { return customArray[index]; }  }
        public int Count {   get { return count; }   }

        public CustomList()
        {
            
        }

        public void Add(T item)
        {
            T newItem = item;
            //Get array length
            //initialize new array
            //move old array elements to new array during init.
            customArray = new T[] { };

        }

        public bool Remove(T item)
        {
            return false;
        }

        public void Zip(CustomList<T> newList)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        //Overload + - Operators

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private int GetArrayLength()
        {
            return 0;
        }
        
    }
}
