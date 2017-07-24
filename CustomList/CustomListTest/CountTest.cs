using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class CountTest
    {
        [TestMethod]
        public void Get_StringListCount_ReturnPositiveInteger()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { };
            string testString = "Hello World";
            //Act
            customList.Add(testString);
            int listCount = customList.Count;
            //Assert 
            Assert.AreEqual(1, listCount);
        }

        [TestMethod]
        public void Get_IntegerListCount_ReturnPositiveInteger()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            int testInteger = 1;
            //Act
            customList.Add(testInteger);
            int listCount = customList.Count;
            //Assert 
            Assert.AreEqual(1,listCount);
        }

        [TestMethod]
        public void Get_ObjectListCount_ReturnPositiveInteger()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>() { };
            object random = new Random();
            //Act
            customList.Add(random);
            int listCount = customList.Count;
            //Assert 
            Assert.AreEqual(1, listCount);
        }

        [TestMethod]
        public void Get_ListCount_ReturnZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            //Act
            int listCount = customList.Count;
            //Assert 
            Assert.AreEqual(0, listCount);
        }

        [TestMethod]
        public void Get_LargeList_ReturnPositiveInteger()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            int testInteger = 1;
            int itemsToAdd = 1000;
            //Act
            for (int i = 0; i < itemsToAdd; i++)
            {
                customList.Add(testInteger);
            }
            int listCount = customList.Count;
            //Assert 
            Assert.AreEqual(1000, listCount);
        }
    }
}
