using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class EnumerateTest
    {
        [TestMethod]
        public void ForEach_AddToNewList_ReturnNewListCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            CustomList<int> EnumeratedList = new CustomList<int>() { };
            int itemsToAdd = 10;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(1);
            }
            foreach (int item in customList)
            {
                EnumeratedList.Add(item);
            }
            int listCount = EnumeratedList.Count;
            //Assert
            Assert.AreEqual(itemsToAdd, listCount);
        }

        [TestMethod]
        public void ForLoop_List_ReturnIndexTest()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int indexTest = 5;
            int foundIndexTest = 0;
            //Act
            for (int i = 0; i < customList.Count; i++)
            {
                if (customList[i] == 5)
                {
                    foundIndexTest = 5;
                }
            }
            //Assert
            Assert.AreEqual(indexTest, foundIndexTest);
        }

        [TestMethod]
        public void ForEach_AddToNewList_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            CustomList<int> EnumeratedList = new CustomList<int>() { };
            int itemsToAdd = 5;
            int indexTest = 0;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(i);
            }
            foreach (int item in customList)
            {
                EnumeratedList.Add(item);
            }
            int index = EnumeratedList[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void ForEach_AddToNewList_ReturnIndexOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            CustomList<int> EnumeratedList = new CustomList<int>() { };
            int itemsToAdd = 5;
            int indexTest = 1;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(i);
            }
            foreach (int item in customList)
            {
                EnumeratedList.Add(item);
            }
            int index = EnumeratedList[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void ForEach_AddToNewList_ReturnIndexTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            CustomList<int> EnumeratedList = new CustomList<int>() { };
            int itemsToAdd = 5;
            int indexTest = 2;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(i);
            }
            foreach (int item in customList)
            {
                EnumeratedList.Add(item);
            }
            int index = EnumeratedList[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void ForEach_AddToNewList_ReturnIndexThree()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            CustomList<int> EnumeratedList = new CustomList<int>() { };
            int itemsToAdd = 5;
            int indexTest = 3;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(i);
            }
            foreach (int item in customList)
            {
                EnumeratedList.Add(item);
            }
            int index = EnumeratedList[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void ForEach_AddToNewList_ReturnIndexFour()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            CustomList<int> EnumeratedList = new CustomList<int>() { };
            int itemsToAdd = 5;
            int indexTest = 4;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(i);
            }
            foreach (int item in customList)
            {
                EnumeratedList.Add(item);
            }
            int index = EnumeratedList[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }
    }
}
