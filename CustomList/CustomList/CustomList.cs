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
        int count = 0;

        public T this[int index] {   get { return customArray[index]; }  }
        public int Count {   get { return count; }   }

        public CustomList()
        {
            
        }

        public void Add(T item)
        {    
            T[] temporaryArray = new T[count + 1];

            if(count == 0)
            {
                customArray = new T[] { item };
            }
            else if(count >= 1)
            {
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = customArray[i];
                }
                temporaryArray[count + 1] = item;
            }
            customArray = temporaryArray;
            count++;
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
