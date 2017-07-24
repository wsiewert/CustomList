using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class OperatorOverloadTest
    {
        [TestMethod]
        public void Add_ListItems_ReturnConcatinatedListCount()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { };
            CustomList<int> customListTwo = new CustomList<int>() { };
            CustomList<int> ConcatinatedList = new CustomList<int>() { };
            //Act
            customListOne.Add(1);
            customListTwo.Add(2);
            ConcatinatedList = customListOne + customListTwo;
            int listCount = ConcatinatedList.Count;
            //Assert
            Assert.AreEqual(2, listCount);
        }
    }
}
