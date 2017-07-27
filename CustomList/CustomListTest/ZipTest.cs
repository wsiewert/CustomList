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
            CustomList<int> customListOne = new CustomList<int>() { };
            CustomList<int> customListTwo = new CustomList<int>() { };
            int one = 1;
            int two = 2;
            //Act
            customListOne.Add(one);
            customListTwo.Add(two);
            customListOne.Zip(customListTwo);
            int indexTwo = customListOne[1];
            //Assert
            Assert.AreEqual(two,indexTwo);
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
    }
}
