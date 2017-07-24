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
    }
}
