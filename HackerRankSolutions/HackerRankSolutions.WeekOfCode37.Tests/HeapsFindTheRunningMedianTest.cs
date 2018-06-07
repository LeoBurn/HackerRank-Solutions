using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankSolutions.CrakingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.WeekOfCode37.Tests
{
    [TestClass]
    public class HeapsFindTheRunningMedianTest
    {
        [TestMethod]
        public void FirstTestCenarioHeapsFindTheRunningMedian()
        {
            //Arrange
            int numberOfElements = 6;
            int[] elements = {12, 4, 5, 3, 8, 7};
            double[] expectedValues = {12.0,8.0,5.0,4.5,5.0,6.0};
            HeapsFindTheRunningMedian runner = new HeapsFindTheRunningMedian();

            //Act
            var result = runner.Run(elements, numberOfElements);

            //Assert
            CollectionAssert.AreEqual(expectedValues,result);
        }
    }
}
