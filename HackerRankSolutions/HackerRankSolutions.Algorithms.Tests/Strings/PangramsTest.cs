using System;
using HackerRankSolutions.Algorithms.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Strings
{
    [TestClass]
    public class PangramsTest
    {
        [TestMethod]
        public void ShouldTestOnePangramAndOtherNot()
        {
            //Arrange
            string s1 = "We promptly judged antique ivory buckles for the next prize";
            string s2 = "We promptly judged antique ivory buckles for the prize";
            string expecteds1 = "pangram";
            string expecteds2 = "not pangram";
            Pangrams runner = new Pangrams();

            //Act
            var result1 = runner.Run(s1);
            var result2 = runner.Run(s2);

            //Assert
            Assert.AreEqual(expecteds1,result1);
            Assert.AreEqual(expecteds2, result2);
        }
    }
}
