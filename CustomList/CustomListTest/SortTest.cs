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
            CustomList<int> list1 = new CustomList<int>() { 10,5,9,2 };
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
    }
}
