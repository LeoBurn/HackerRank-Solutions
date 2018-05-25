using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.CrakingTheCodingInterview.Tests
{
    /// <summary>
    /// Summary description for StacksBalancedBracketsTest
    /// </summary>
    [TestClass]
    public class StacksBalancedBracketsTest
    {
      
        [TestMethod]
        public void StacksBalancedBracketsTestCase1()
        {
            //Arrange
            var brackets = "{[()]}";
            var expectedResult = true;
            StacksBalancedBrackets runner = new StacksBalancedBrackets();

            //Act
            var result = runner.Run(brackets);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void StacksBalancedBracketsTestCase2()
        {
            //Arrange
            var brackets = "{[(])}";
            var expectedResult = false;
            StacksBalancedBrackets runner = new StacksBalancedBrackets();

            //Act
            var result = runner.Run(brackets);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void StacksBalancedBracketsTestCase3()
        {
            //Arrange
            var brackets = "{{[[(())]]}}";
            var expectedResult = true;
            StacksBalancedBrackets runner = new StacksBalancedBrackets();

            //Act
            var result = runner.Run(brackets);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
