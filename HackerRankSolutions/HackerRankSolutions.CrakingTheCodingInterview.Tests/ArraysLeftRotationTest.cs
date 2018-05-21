using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.CrakingTheCodingInterview.Tests
{
    [TestClass]
    public class ArraysLeftRotationTest
    {
        [TestMethod]
        public void TestCase1()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var rotate = 9;
            var runner = new ArraysLeftRotation();
            var expectedResult = new int[] { 5, 1, 2, 3, 4 };

            //Act
            var result = runner.Run(arr, arr.Length, rotate);



            //Assert
            CollectionAssert.Equals(expectedResult, result);
        }
    }
}
