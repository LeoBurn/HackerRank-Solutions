using System;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class BreakingTheRecordsTest
    {
        [TestMethod]
        public void ShouldGetMinAndMax()
        {
            //Arrange
            int[] arr = new[] {10, 5, 20, 20, 4, 5, 2, 25, 1};
            int n = 9;
            BreakingTheRecords.Points expected = new BreakingTheRecords.Points() {MaxCounter = 2, MinCounter = 4};
            BreakingTheRecords runner = new BreakingTheRecords();
            
            //Act
            var result = runner.Run(arr, n);
            //Assert
            Assert.AreEqual(result.MinCounter,expected.MinCounter);
            Assert.AreEqual(result.MaxCounter, expected.MaxCounter);
        }
    }
}
