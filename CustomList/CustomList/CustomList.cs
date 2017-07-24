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
        T[] customArray = new T[] { };
        int count;

        public T this[int index] {   get { return customArray[index]; }  }
        public int Count {   get { return count; }   }

        public CustomList()
        {
            T whatever = customArray[0];
        }

        //Removes First instance of specified item form list.
        public void Add(T item)
        {

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


        
    }
}
