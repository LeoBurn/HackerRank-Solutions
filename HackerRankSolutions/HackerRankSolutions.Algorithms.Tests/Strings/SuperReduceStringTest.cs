using System;
using System.Text;
using System.Collections.Generic;
using HackerRankSolutions.Algorithms.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Strings
{
   [TestClass]
    public class SuperReduceStringTest
    {
        [TestMethod]
        public void ShouldGetReducedString()
        {
            //Arrange
            string str = "zztqooauhujtmxnsbzpykwlvpfyqijvdhuhiroodmuxiobyvwwxupqwydkpeebxmfvxhgicuzdealkgxlfmjiucasokrdznmtlwh";
            string expectedResult = "tqauhujtmxnsbzpykwlvpfyqijvdhuhirdmuxiobyvxupqwydkpbxmfvxhgicuzdealkgxlfmjiucasokrdznmtlwh";
            SuperReduceString runner = new SuperReduceString();

            //Act
            var result = runner.Run(str);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldGetReducedAnotherReduceString()
        {
            //Arrange
            string str = "aaabccddd";
            string expectedResult = "abd";
            SuperReduceString runner = new SuperReduceString();

            //Act
            var result = runner.Run(str);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldGetEmptyString()
        {
            //Arrange
            string str = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string expectedResult = "Empty String";

            SuperReduceString runner = new SuperReduceString();

            //Act
            var result = runner.Run(str);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ShouldGetReducedNotContinues()
        {
            //Arrange
            string str = "baab";
            string expectedResult = "Empty String";
            SuperReduceString runner = new SuperReduceString();

            //Act
            var result = runner.Run(str);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
