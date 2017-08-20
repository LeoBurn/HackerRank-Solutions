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
        public void ShouldGetDayOfProgramer()
        {
            //Arrange
            int year1 = 2016;
            string expectedValue1 = "12.09.2016";
            int year2 = 2017;
            string expectedValue2 = "13.09.2017";
            int year3 = 1918;
            string expectedValue3 = "26.09.1918";
            DayOfProgramer runner = new DayOfProgramer();

            //Act
            var result1 = runner.Run(year1);
            var result2 = runner.Run(year2);
            var result3 = runner.Run(year3);

            //Assert
            Assert.AreEqual(expectedValue1,result1);
            Assert.AreEqual(expectedValue2, result2);
            Assert.AreEqual(expectedValue3, result3);
        }
    }
}
