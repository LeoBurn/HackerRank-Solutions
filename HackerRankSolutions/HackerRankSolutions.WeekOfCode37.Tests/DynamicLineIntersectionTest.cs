using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.WeekOfCode37.Tests
{
    [TestClass]
    public class DynamicLineIntersectionTest
    {
        [TestMethod]
        public void DynamicLineIntersectionFirstTestCenario()
        {
            //Arrange
            int numberOfLines = 4;
            string[] lines = { "+ 1 0", "+ 2 0", "? 1","? 2" };
            int[] expectedValues = new int[] {1, 2};
            DynamicLineIntersection runner = new DynamicLineIntersection();

            //Act
            var result = runner.Run(lines, numberOfLines);

            //Assert
            CollectionAssert.AreEqual(expectedValues, result);
        }

        [TestMethod]
        public void DynamicLineIntersectionSecondTestCenario()
        {
            //Arrange
            int numberOfLines = 4;
            string[] lines = { "+ 1 0", "+ 2 0", "? 1", "? 2", "? 1", "? 2" };
            int[] expectedValues = new int[] { 1, 2,1,2};
            DynamicLineIntersection runner = new DynamicLineIntersection();

            //Act
            var result = runner.Run(lines, numberOfLines);

            //Assert
            CollectionAssert.AreEqual(expectedValues, result);
        }
    }
}
