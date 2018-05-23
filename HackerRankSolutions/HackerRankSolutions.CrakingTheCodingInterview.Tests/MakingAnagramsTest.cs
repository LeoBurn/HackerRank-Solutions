using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.CrakingTheCodingInterview.Tests
{
    [TestClass]
    public class MakingAnagramsTest
    {
        [TestMethod]
        public void TestCase1Anagram()
        {
            //Arrange 
            string s1 = "cde";
            string s2 = "abc";
            MakingAnagrams runner = new MakingAnagrams();
            int expectedValue = 4;

            //Act
            var result = runner.Run(s1, s2);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
