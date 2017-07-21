using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_StringValue_ReturnValue()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string helloWorld = "HELLO WORLD";
            int firstIndex = 0;
            //Act
            customList.Add(helloWorld);
            string result = customList[firstIndex];
            //Assert
            Assert.AreEqual(result, helloWorld);
        }

        [TestMethod]
        public void Add_IntValue_ReturnValue()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int testNumber = 5;
            int firstIndex = 0;
            //Act
            customList.Add(testNumber);
            int result = customList[firstIndex];
            //Assert
            Assert.AreEqual(result, testNumber);
        }

        [TestMethod]
        public void Add_Object_returnValue()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>();
            object testObject = new Random();
            int firstIndex = 0;
            //Act
            customList.Add(testObject);
            object result = customList[firstIndex];
            //Assert
            Assert.AreEqual(result, testObject);
        }

        [TestMethod]
        public void Add_MultipleInt_returnFirstIndexValue()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>();
            object testObject = new Random();
            int amountToAdd = 3;
            int firstIndex = 0;
            //Act
            for (int i = 0; i < amountToAdd; i++)
            {
                customList.Add(testObject);
            }
            object result = customList[firstIndex];
            //Assert
            Assert.AreEqual(result, testObject);
        }

        [TestMethod]
        public void Add_MultipleInt_returnLastIndexValue()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>();
            object testObject = new Random();
            int amountToAdd = 3;
            int lastIndex = amountToAdd-1;
            //Act
            for (int i = 0; i < amountToAdd; i++)
            {
                customList.Add(testObject);
            }
            object result = customList[lastIndex];
            //Assert
            Assert.AreEqual(result, testObject);
        }

    }
}
