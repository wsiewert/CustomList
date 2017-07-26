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

        public T this[int index] { get { return customArray[index]; } }
        public int Count { get { return count; } }

        public CustomList()
        {

        }

        public void Add(T item)
        {
            T[] temporaryArray = new T[count + 1];

            if (count == 0)
            {
                customArray = new T[] { item };
            }
            else if (count >= 1)
            {
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = customArray[i];
                }
                temporaryArray[count] = item;
                customArray = temporaryArray;
            }
            count++;
        }

        public bool Remove(T item)
        {
            object removableItem = item;
            T[] temporaryArray;
            int skipIndex = 0;
            if (count == 0)
            {
                return false;
            }

            if (count >= 1)
            {
                //finds euqated values, returns skip index
                for (int i = 0; i < count; i++)
                {
                    object currentArrayItem = customArray[i];
                    if (removableItem.Equals(currentArrayItem))
                    {
                        skipIndex = i;
                        break;
                    }
                    else if (i == count - 1)
                    {
                        return false;
                    }
                }
                //rebuilds temporary array from current array minus skip index
                temporaryArray = new T[count - 1];
                for (int i = 0; i < (count); i++)
                {
                    if (i == skipIndex)
                    {
                        // continue when skipped
                        continue;
                    }
                    else if (i > skipIndex)
                    {
                        // add into temparray[i-1]
                        temporaryArray[i - 1] = customArray[i];
                    }
                    else
                    {
                        // add into temparry[i]
                        temporaryArray[i] = customArray[i];
                    }
                }
                customArray = temporaryArray;
                count--;
                return true;
            }
            return false;
        }

        public void Zip(CustomList<T> newList)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> list1,CustomList<T> list2)
        {
            CustomList<T> newCustomList = new CustomList<T>();
            newCustomList = list1;
            for (int i = 0; i < list2.Count; i++)
            {
                newCustomList.Add(list2[i]);
            }
            return newCustomList;
        }

        public static CustomList<T> operator -(CustomList<T> list1,CustomList<T> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                T item = list2[i];
                list1.Remove(item);
            }
            return list1;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return customArray[i];
            }
        }
    }
}
