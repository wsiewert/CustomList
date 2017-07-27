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
            int newArrayCount = count + newList.Count;
            T[] temporaryArray = new T[newArrayCount];
            int customListCounter = count;
            int customListIndex = 0;
            int newlistCounter = newList.Count;
            int newListIndex = 0;
            bool arraySwitch = false;
            for (int i = 0; i < newArrayCount; i++)
            {
                if (arraySwitch == false && count > 0)
                {
                    temporaryArray[i] = customArray[customListIndex];
                    customListIndex++;
                    customListCounter--;
                    if (newlistCounter != 0)
                    {
                        arraySwitch = true;
                    }
                    else
                    {
                        arraySwitch = false;
                    }
                }
                else if (arraySwitch == true )
                {
                    temporaryArray[i] = newList[newListIndex];
                    newListIndex++;
                    newlistCounter--;
                    if (customListCounter != 0)
                    {
                        arraySwitch = false;
                    }
                    else
                    {
                        arraySwitch = true;
                    }
                }
            }
            customArray = new T[newArrayCount];
            customArray = temporaryArray;
            count = newArrayCount;
        }

        public override string ToString()
        {
            string returnString = "";

            for (int i = 0; i < count; i++)
            { 
                returnString += "'" + customArray[i].ToString() + "'";
                if (i < (count - 1))
                {
                    returnString += ", ";
                }
            }
            return returnString;
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
