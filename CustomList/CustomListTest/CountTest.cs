using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class CountTest
    {
        [TestMethod]
        public void Get_ListCount_ReturnPositiveInteger()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>() { };
            
            //Act
            //Assert 
        }
    }
}
