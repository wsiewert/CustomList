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

        public T this[int index]
        {
            get { return customArray[index]; }
        }

        public CustomList()
        {
            T whatever = customArray[0];
        }

        public void Add(T item)
        {

        }

        public void Remove(T item)
        {

        }

        public void Count()
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
}
