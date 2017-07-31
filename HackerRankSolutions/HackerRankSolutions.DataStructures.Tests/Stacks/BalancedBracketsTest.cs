using System;
using HackerRankSolutions.DataStructures.Stacks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.DataStructures.Tests.Stacks
{
    [TestClass]
    public class BalancedBracketsTest
    {
        [TestMethod]
        public void ShouldReturnIdentifyBalancedBrackets()
        {
            //Arrange
            string[] brackets = new[] {"{[()]}", "{[(])}", "{{[[(())]]}}", "{{[[(())]]}}[", "{[}]"};
            string[] expectedResult = new[] { "YES", "NO", "YES", "NO", "NO" };
            BalancedBrackets runner = new BalancedBrackets();
            
            //Act
            var result  = runner.Run(brackets);
            
            //Assert
            CollectionAssert.AreEqual(expectedResult,result);
        }
    }
}
