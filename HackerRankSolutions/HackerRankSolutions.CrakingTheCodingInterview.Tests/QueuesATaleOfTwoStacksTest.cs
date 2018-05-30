using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.CrakingTheCodingInterview.Tests
{
    [TestClass]
    public class QueuesATaleOfTwoStacksTest
    {
        [TestMethod]
        public void TestCase1QueuesATaleOfTwoStacks()
        {
            //Arrange 
            int[] operations = {1, 2, 1, 3, 1, 3, 1, 1, 2, 2};
            int?[] values = {42, null, 14, null, 28, null, 60, 78, null, null};
            int?[] expectedValues = {null, null, null, 14, null, 14, null, null, null, null};
            
            QueuesATaleOfTwoStacks runner = new QueuesATaleOfTwoStacks();

            //Act
            var result = runner.Run(operations, values);

            //Assert
            CollectionAssert.AreEqual(expectedValues,result);
        }
    }
}
