using System;
using HackerRankSolutions.Algorithms.Warmup;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Warmup
{
    [TestClass]
    public class BirthdayCakeCandlesTest
    {
        [TestMethod]
        public void ShouldGiveBiggestCandle()
        {
            //Arrange
            var candles = new int[]{3, 2, 1, 3};
            BirthdayCakeCandles runner = new BirthdayCakeCandles();
            var expectedNumber = 2;

            //Act
            var result = runner.Run(candles);

            //Assert
            Assert.AreEqual(expectedNumber, result);
        }
    }
}
