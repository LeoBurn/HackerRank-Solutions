using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.WeekOfCode37.Tests
{
    [TestClass]
    public class SimpleLanguageTest
    {
        [TestMethod]
        public void FirstTestCenario()
        {
            //Arrange
            int numberOfLines = 3;
            string[] lines = { "add 2","set 1","add -1" };
            double expectedValue = 2;
            SimpleLanguage runner = new SimpleLanguage();

            //Act
            var result = runner.Run(lines, numberOfLines);

            //Assert
            Assert.AreEqual(result, expectedValue);
        }

        [TestMethod]
        public void SecondTestCenario()
        {
            //Arrange
            int numberOfLines = 2;
            string[] lines = { "set 5", "add 6"};
            double expectedValue = 11;
            SimpleLanguage runner = new SimpleLanguage();

            //Act
            var result = runner.Run(lines, numberOfLines);

            //Assert
            Assert.AreEqual(result, expectedValue);
        }

        [TestMethod]
        public void ThirdTestCenario()
        {
            //Arrange
            int numberOfLines = 3;
            string[] lines = { "add -1", "set -3","add -2" };
            double expectedValue = 0;
            SimpleLanguage runner = new SimpleLanguage();

            //Act
            var result = runner.Run(lines, numberOfLines);

            //Assert
            Assert.AreEqual(result, expectedValue);
        }

        [TestMethod]
        public void FourthTestCenario()
        {
            //Arrange
            int numberOfLines = 5;
            string[] lines = { "add 2", "add 3", "set 7","add -1","add 2" };
            double expectedValue = 9;
            SimpleLanguage runner = new SimpleLanguage();

            //Act
            var result = runner.Run(lines, numberOfLines);

            //Assert
            Assert.AreEqual(result, expectedValue);
        }
    }
}
