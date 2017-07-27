using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ToStringOverrideTest
    {
        [TestMethod]
        public void ToString_StringList_ReturnString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "Hello","World"};
            //Act
            string customListString = customList.ToString();
            //Assert
            Assert.AreEqual(customListString,"'Hello', 'World'");

        }

        [TestMethod]
        public void ToString_IntList_ReturnString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            string expectedString = "'1', '2', '3', '4', '5'";
            //Act
            string customListString = customList.ToString();
            //Assert
            Assert.AreEqual(customListString, expectedString);
        }

        [TestMethod]
        public void ToString_ObjectList_ReturnObjectNamesString()
        {
            //Arrange
            Random object1 = new Random();
            Random object2 = new Random();
            Random object3 = new Random();
            Random object4 = new Random();
            Random object5 = new Random();
            CustomList<Random> customList = new CustomList<Random>() { object1, object2, object3, object4, object5 };
            string expectedString = "'System.Random', 'System.Random', 'System.Random', 'System.Random', 'System.Random'";
            //Act
            string customListString = customList.ToString();
            //Assert
            Assert.AreEqual(customListString, expectedString);
        }

        [TestMethod]
        public void ToString_Nothing_ReturnEmptyString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { };
            //Act
            string customListString = customList.ToString();
            //Assert
            Assert.AreEqual(customListString, "");

        }
    }
}
