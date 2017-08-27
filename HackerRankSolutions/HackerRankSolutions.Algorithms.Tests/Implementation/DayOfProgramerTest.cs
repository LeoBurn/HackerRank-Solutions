using System;
using System.Text;
using System.Collections.Generic;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    /// <summary>
    /// Summary description for DayOfProgramerTest
    /// </summary>
    [TestClass]
    public class DayOfProgramerTest
    {
        [TestMethod]
        public void ShouldGetDayOfProgramerIn1918()
        {
            //Arrange
            int year = 1918;
            string expectedValue = "26.09.1918";
            DayOfProgramer runner = new DayOfProgramer();

            //Act
            var result = runner.Run(year);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ShouldGetDayOfProgramerInBissextusYear()
        {
            //Arrange
            int year = 2016;
            string expectedValue = "12.09.2016";
            DayOfProgramer runner = new DayOfProgramer();

            //Act
            var result = runner.Run(year);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ShouldGetDayOfProgramerInNotBissextus()
        {
            //Arrange
            int year = 2017;
            string expectedValue = "13.09.2017";
            DayOfProgramer runner = new DayOfProgramer();

            //Act
            var result = runner.Run(year);


            //Assert
            Assert.AreEqual(expectedValue, result);
        }

    }
}
