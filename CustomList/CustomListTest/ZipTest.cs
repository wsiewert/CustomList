using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void Zip_Lists_ReturnNewZippedList()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>() { };
            CustomList<int> customListTwo = new CustomList<int>() { };
            int one = 1;
            int two = 2;
            //Act
            customListOne.Add(one);
            customListTwo.Add(two);
            customListOne.Zip(customListTwo);
            int indexTwo = customListOne[1];
            //Assert
            Assert.AreEqual(two,indexTwo);
        }
    }
}
