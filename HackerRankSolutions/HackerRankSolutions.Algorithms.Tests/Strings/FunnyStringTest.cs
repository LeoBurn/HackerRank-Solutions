using System;
using System.Text;
using System.Collections.Generic;
using HackerRankSolutions.Algorithms.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Strings
{
    /// <summary>
    /// Summary description for FunnyStringTest
    /// </summary>
    [TestClass]
    public class FunnyStringTest
    {

        [TestMethod]
        public void ShouldGetFunnyString()
        {
            //Arrange
            string s = "acxz";
            string exptectedValue = "Funny";
            FunnyString runner = new FunnyString();

            //Act
            var result = runner.Run(s);

            //Assert
            Assert.AreEqual(exptectedValue,result);
        }

        [TestMethod]
        public void ShouldGetNotFunnyString()
        {
            //Arrange
            string s = "bcxz";
            string exptectedValue = "Not Funny";
            FunnyString runner = new FunnyString();

            //Act
            var result = runner.Run(s);

            //Assert
            Assert.AreEqual(exptectedValue, result);
        }
    }
}
