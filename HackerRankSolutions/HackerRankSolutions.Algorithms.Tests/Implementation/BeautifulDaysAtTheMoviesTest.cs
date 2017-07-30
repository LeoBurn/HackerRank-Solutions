using System;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class BeautifulDaysAtTheMoviesTest
    {
        [TestMethod]
        public void ShouldTestReverseNumber()
        {
            //Arrange
            int numberOne = 123456789;
            int reverseNumberOne = 987654321;

            int numberTwo = 123321;
            int reverseNumberTwo = 123321;

            int numberThree = 0;
            int reverseNumberThree = 0;

            int numberFour = 111;
            int reverseNumberFour = 111;

            BeautifulDaysAtTheMovies runner = new BeautifulDaysAtTheMovies();

            //Act
            var resultNumberOne = runner.Reverse(numberOne);
            var resultNumberTwo = runner.Reverse(numberTwo);
            var resultNumberThree = runner.Reverse(numberThree);
            var resultNumberFour = runner.Reverse(numberFour);

            //Assert
            Assert.AreEqual(resultNumberOne, reverseNumberOne);
            Assert.AreEqual(resultNumberTwo, reverseNumberTwo);
            Assert.AreEqual(resultNumberThree, reverseNumberThree);
            Assert.AreEqual(resultNumberFour, reverseNumberFour);
        }

        [TestMethod]
        public void ShouldTestNumberOfBeatifulDays()
        {
            //Arrange
            int begin = 20;
            int end = 23;
            int k = 6;

            int expectedResult = 2;
            BeautifulDaysAtTheMovies runner = new BeautifulDaysAtTheMovies();
            //Act
            var result = runner.Run(begin, end, k);
            //Assert
            Assert.AreEqual(result,expectedResult);

        }
    }
}
