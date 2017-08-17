using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class BirthdayChocolateTest
    {
        [TestMethod]
        public void ShouldReturnTwoElements()
        {
            //Arrange
            int n = 5;
            int[] arr = new[] {1, 2, 1, 3, 2};
            int m = 2;
            int d = 3;
            int expectedValue = 2;
            BirthdayChocolate runner = new BirthdayChocolate();

            //Act
            var result = runner.Run(n, arr, d, m);

            //Assert
            Assert.AreEqual(expectedValue,result);
        }
    }
}
