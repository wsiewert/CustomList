using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_StringValue_ReturnBool()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { };
            string helloWorld = "Hello World";
            //Act
            customList.Add(helloWorld);
            bool removedItem = customList.Remove("Hello World");
            //Assert
            Assert.AreEqual(true, removedItem);
        }

        [TestMethod]
        public void Remove_IntValue_ReturnBool()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            int listItemValue = 10;
            //Act
            customList.Add(listItemValue);
            bool removedItem = customList.Remove(listItemValue);
            //Assert
            Assert.AreEqual(true, removedItem);
        }

        [TestMethod]
        public void Remove_Object_ReturnBool()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>() { };
            object testObject = new Random();
            //Act
            customList.Add(testObject);
            bool removedItem = customList.Remove(testObject);
            //Assert
            Assert.AreEqual(true, removedItem);
        }

        [TestMethod]
        public void Remove_Int_ReturnListCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            int itemToRemove = 2;
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(itemToRemove);
            int listCount = customList.Count;
            //Assert
            Assert.AreEqual(2, listCount);
        }

        [TestMethod]
        public void Remove_Int_ReturnIntAtIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };
            int itemToRemove = 2;
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(itemToRemove);
            int newItemAtRemovedIndex = customList[1];
            //Assert
            Assert.AreEqual(3, newItemAtRemovedIndex);
        }

        [TestMethod]
        public void Remove_OneObject_ReturnListCount()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>() { };
            object testObject = new Random();
            //Act
            customList.Add(testObject);
            customList.Add(testObject);
            customList.Add(testObject);
            customList.Remove(testObject);
            int listCount = customList.Count;
            //Assert
            Assert.AreEqual(2, listCount);
        }
    }
}
