using System;
using System.Text;
using System.Collections.Generic;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    /// <summary>
    /// Summary description for BetweenTwoSetsTest
    /// </summary>
    [TestClass]
    public class BetweenTwoSetsTest
    {
       

        [TestMethod]
        public void ShouldReturnTwoSubSetANotContainsAnyElement()
        {
            //Arrange
            var subsetA = new int[] {3, 9, 6};
            var subsetB = new int[] {36,72};
            var expectedValue = 2;
            BetweenTwoSets runner = new BetweenTwoSets();

            //Act
            var result = runner.Run(subsetA, subsetB);

            //Assert
            Assert.AreEqual(expectedValue,result);
        }
    }
}
