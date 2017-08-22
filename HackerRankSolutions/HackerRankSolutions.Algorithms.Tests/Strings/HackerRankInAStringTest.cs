using System;
using System.Text;
using System.Collections.Generic;
using HackerRankSolutions.Algorithms.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Strings
{
    /// <summary>
    /// Summary description for HackerRankInAStringTest
    /// </summary>
    [TestClass]
    public class HackerRankInAStringTest
    {
        [TestMethod]
        public void ShouldGetHackerRankSubQuery()
        {
            //Arrange
            string s1 = "hereiamstackerrank";
            string expectedValue1 = "YES";
            string s2 = "hackerworld";
            string expectedValue2 = "NO";

            HackerRankInAString runner = new HackerRankInAString();

            //Act
            var result1 = runner.Run(s1);
            var result2 = runner.Run(s2);
            
            //Assert
            Assert.AreEqual(expectedValue1,result1);
            Assert.AreEqual(expectedValue2, result2);
        }
    }
}
