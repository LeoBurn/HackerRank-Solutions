using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.CrakingTheCodingInterview.Tests
{
    [TestClass]
    public class HashTableRansomNoteTest
    {
        [TestMethod]
        public void TestCase1RansomNote()
        {
            //Arrange 
            string s1 = "give me one grand today night";
            string s2 = "give one grand today";
            HashTableRansomNote runner = new HashTableRansomNote();
            bool expectedValue = true;

            //Act
            var result = runner.Run(s1, s2);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestCase2RansomNote()
        {
            //Arrange 
            string s1 = "two times three is not four";
            string s2 = "two times two is four";
            HashTableRansomNote runner = new HashTableRansomNote();
            bool expectedValue = false;

            //Act
            var result = runner.Run(s1, s2);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
