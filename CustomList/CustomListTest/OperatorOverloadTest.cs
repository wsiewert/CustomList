using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class OperatorOverloadTest
    {
        [TestMethod]
        public void Add_IntegerListItems_ReturnConcatinatedListCount()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int listCount = ConcatinatedList.Count;
            //Assert
            Assert.AreEqual(10, listCount);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 0;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 1);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexOne()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 1;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 2);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexTwo()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 2;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 3);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexThree()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 3;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 4);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexFour()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 4;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 5);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexFive()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 5;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 6);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexSix()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 6;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 7);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexSeven()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 7;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 8);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexEight()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 8;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 9);
        }

        [TestMethod]
        public void Add_IntegerListItems_ReturnIndexNine()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 9;
            //Act
            ConcatinatedList = customListOne + customListTwo;
            int index = customListOne[indexTest];
            //Assert
            Assert.AreEqual(index, 10);
        }

        [TestMethod]
        public void Add_MultipleLists_ReturnCount()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> customListThree = new CustomList<int>() { 11, 12, 13, 14, 15 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int countTest = 15;
            //Act
            ConcatinatedList = customListOne + customListTwo + customListThree;
            int count = ConcatinatedList.Count;
            //Assert
            Assert.AreEqual(countTest, count);
        }

        [TestMethod]
        public void Add_MultipleLists_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> customListThree = new CustomList<int>() { 11, 12, 13, 14, 15 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 0;
            //Act
            ConcatinatedList = customListOne + customListTwo + customListThree;
            int index = ConcatinatedList[indexTest];
            //Assert
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void Add_MultipleLists_ReturnIndexFive()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> customListThree = new CustomList<int>() { 11, 12, 13, 14, 15 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 5;
            //Act
            ConcatinatedList = customListOne + customListTwo + customListThree;
            int index = ConcatinatedList[indexTest];
            //Assert
            Assert.AreEqual(6, index);
        }

        [TestMethod]
        public void Add_MultipleLists_ReturnIndexTen()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> customListThree = new CustomList<int>() { 11, 12, 13, 14, 15 };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            int indexTest = 10;
            //Act
            ConcatinatedList = customListOne + customListTwo + customListThree;
            int index = ConcatinatedList[indexTest];
            //Assert
            Assert.AreEqual(11, index);
        }
    }
}
