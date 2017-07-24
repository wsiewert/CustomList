using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ToStringOverrideTest
    {
        [TestMethod]
        public void Get_List_ReturnString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "Hello","World"};
            //Act
            string customListString = customList.ToString();
            //Assert
            Assert.AreEqual(customListString,"'Hello', 'World'");

        }
    }
}
