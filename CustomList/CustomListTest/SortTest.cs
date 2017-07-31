using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject; 

namespace CustomListTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Sort_IntList_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 10, 5, 9, 2 };
            int testIndex = 0;
            int expectedResult = 2;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult,index);
        }

        [TestMethod]
        public void Sort_IntList_ReturnIndexOne()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 10, 5, 9, 2 };
            int testIndex = 1;
            int expectedResult = 5;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_IntList_ReturnIndexTwo()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 10, 5, 9, 2 };
            int testIndex = 2;
            int expectedResult = 9;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_IntList_ReturnIndexThree()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 10, 5, 9, 2 };
            int testIndex = 3;
            int expectedResult = 10;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_IncreasingIntList_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int testIndex = 0;
            int expectedResult = 1;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_IncreasingIntList_ReturnIndexNine()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int testIndex = 9;
            int expectedResult = 10;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_DecreasingIntList_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int testIndex = 0;
            int expectedResult = 1;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_DecreasingIntList_ReturnIndexNine()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int testIndex = 9;
            int expectedResult = 10;
            //Act
            list1.Sort();
            int index = list1[testIndex];
            //Assert
            Assert.AreEqual(expectedResult, index);
        }

        [TestMethod]
        public void Sort_EmptyList_ReturnCount()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            int expectedResult = 0;
            //Act
            list1.Sort();
            int count = list1.Count;
            //Assert
            Assert.AreEqual(expectedResult, count);
        }

        [TestMethod]
        public void Sort_StringList_ReturnString()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>() { "World", "Hello" };
            string expectedResult = "'Hello', 'World'";
            //Act
            list1.Sort();
            string result = list1.ToString();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
