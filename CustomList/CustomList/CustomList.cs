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
                for (int i = 0; i < count; i++)
                {
                    T currentArrayItem = customArray[i];
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
                temporaryArray = new T[count - 1];
                for (int i = 0; i < (count); i++)
                {
                    if (i == skipIndex)
                    {
                        continue;
                    }
                    else if (i > skipIndex)
                    {
                        temporaryArray[i - 1] = customArray[i];
                    }
                    else
                    {
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
                else if (arraySwitch == true)
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

        public void Sort()
        {
            T[] temporaryArray = customArray;
            int firstIndex = 0;
            int lastIndex = count - 1;
            if (count > 1)
            {
                temporaryArray = QuickSort(temporaryArray, firstIndex, lastIndex);
            }
            customArray = temporaryArray;
        }

        private T[] QuickSort(T[] temporaryArray, int firstIndex, int lastIndex)
        {
            int wall = firstIndex;
            int pivot = lastIndex;
            int range = (lastIndex - firstIndex);
            int comparingIndex = firstIndex - 1;

            if (range <= 0)
            {
                //TODO: return array, exit recursion.
                return temporaryArray;
            }

            for (int i = firstIndex; i < range; i++)
            {
                if (Compare(temporaryArray[pivot], temporaryArray[i]) >= 0)
                {
                    //if i < than pivot

                    //increment comparingIndex
                    comparingIndex++;
                    //swap comparingIndex with i
                    temporaryArray = SwapIndexes(temporaryArray, comparingIndex, i);
                    //increment wall
                    wall++;
                }
                else if (Compare(temporaryArray[pivot], temporaryArray[i]) < 0)
                {
                    //if i > than pivot
                    //continue
                    continue;
                }
            }
            //TOOD: when finished, swap wall with pivot
            if(Compare(temporaryArray[wall], temporaryArray[pivot]) >= 0)
            {
                temporaryArray = SwapIndexes(temporaryArray, pivot, wall);
                int temporaryPivotIndex = pivot;
                pivot = wall;
                wall = temporaryPivotIndex;
            }
            

            //new pivot point and ranges
            int firstIndexLeft = firstIndex;
            int firstIndexRight;
            if (pivot == 0)
            {
                firstIndexRight = 0;
            }
            else
            {
                firstIndexRight = pivot - 1;
            }
            int secondIndexLeft = pivot + 1;
            int secondIndexRight = lastIndex;

            //must call left and right array ranges of wall to sort over in recursion calls.
            //left half
            temporaryArray = QuickSort(temporaryArray, firstIndexLeft, firstIndexRight);
            //right half
            temporaryArray = QuickSort(temporaryArray, secondIndexLeft, secondIndexRight);

            return temporaryArray;
        }

        public int Compare(T item1, T item2)
        {
            return Comparer<T>.Default.Compare(item1, item2);
        }

        private T[] SwapIndexes(T[] temporaryArray, int index1, int index2)
        {
            T firstIndex = temporaryArray[index1];
            temporaryArray[index1] = temporaryArray[index2];
            temporaryArray[index2] = firstIndex;
            return temporaryArray;
        }

        public override string ToString()
        {
            string customListString = "";

            for (int i = 0; i < count; i++)
            { 
                customListString += "'" + customArray[i].ToString() + "'";
                if (i < (count - 1))
                {
                    customListString += ", ";
                }
            }
            return customListString;
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
