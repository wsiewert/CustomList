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
            CustomList<object> EnumeratedList = new CustomList<object>() { };
            //Act
            foreach (var item in customList)
            {
                EnumeratedList.Add(item);
            }
            int listCount = EnumeratedList.Count;
            //Assert
            Assert.AreEqual(0, listCount);
        }
    }
}
