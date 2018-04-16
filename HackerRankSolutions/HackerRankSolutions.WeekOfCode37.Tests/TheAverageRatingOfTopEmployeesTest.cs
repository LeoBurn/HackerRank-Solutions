using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.WeekOfCode37.Tests
{
    [TestClass]
    public class TheAverageRatingOfTopEmployeesTest
    {
        [TestMethod]
        public void FirstTestCenario()
        {
            //Arrange
            int counter = 5;
            int[] ratings = {84, 92, 61, 50, 95};
            double expectedValue = 93.50;
            TheAverageRatingOfTopEmployees runner = new TheAverageRatingOfTopEmployees();

            //Act
            var result = runner.Run(ratings, counter);

            //Assert
            Assert.AreEqual(result, expectedValue);
        }
    }
}
