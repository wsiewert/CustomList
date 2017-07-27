using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void Zip_Lists_ReturnNewZippedList()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1 };
            CustomList<int> customListTwo = new CustomList<int>() { 2 };
            //Act
            customListOne.Zip(customListTwo);
            int indexTwo = customListOne[1];
            //Assert
            Assert.AreEqual(2,indexTwo);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexZero()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0,2,4,6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1,3,5,7 };
            int indexTest = 0;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexOne()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 1;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexTwo()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 2;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexThree()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 3;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexFour()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 4;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexFive()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 5;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexSix()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 6;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_ListItems_ReturnZippedListIndexSeven()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 0, 2, 4, 6 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 3, 5, 7 };
            int indexTest = 7;
            //Act
            customListOne.Zip(customListTwo);
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, indexTest);
        }

        [TestMethod]
        public void Zip_LargeToSmallLists_ReturnCount()
        {
            //Arrange
            string x = "x";
            string o = "o";
            CustomList<string> list1 = new CustomList<string>() { x, x, x, x, x };
            CustomList<string> list2 = new CustomList<string>() { o, o, o };
            int expectedCount = 8;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

        [TestMethod]
        public void Zip_SmallToLargeList_ReturnCount()
        {
            //Arrange
            string x = "x";
            string o = "o";
            CustomList<string> list1 = new CustomList<string>() { x, x, x };
            CustomList<string> list2 = new CustomList<string>() { o, o, o, o, o, o, o, o, o, o, o, o };
            int expectedCount = 15;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

        [TestMethod]
        public void Zip_SameSizeLists_ReturnCount()
        {
            //Arrange
            string x = "x";
            string o = "o";
            CustomList<string> list1 = new CustomList<string>() { x, x, x };
            CustomList<string> list2 = new CustomList<string>() { o, o, o };
            int expectedCount = 6;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

        [TestMethod]
        public void Zip_NothingToList_ReturnCount()
        {
            //Arrange
            string o = "o";
            CustomList<string> list1 = new CustomList<string>() { };
            CustomList<string> list2 = new CustomList<string>() { o, o, o };
            int expectedCount = 3;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

        [TestMethod]
        public void Zip_ListToNothing_ReturnCount()
        {
            //Arrange
            string x = "x";
            CustomList<string> list1 = new CustomList<string>() { x, x, x };
            CustomList<string> list2 = new CustomList<string>() { };
            int expectedCount = 3;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

        [TestMethod]
        public void Zip_NothingToNothing_ReturnCountZero()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>() { };
            CustomList<string> list2 = new CustomList<string>() { };
            int expectedCount = 0;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

        [TestMethod]
        public void Zip_ListsOfObjects_ReturnCount()
        {
            //Arrange
            Random random = new Random();
            CustomList<Random> list1 = new CustomList<Random>() { random, random, random };
            CustomList<Random> list2 = new CustomList<Random>() { random, random, random };
            int expectedCount = 6;
            //Act
            list1.Zip(list2);
            int listCount = list1.Count;
            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }
    }
}
