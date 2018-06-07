using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankSolutions.DataStructures.Heaps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.DataStructures.Tests.Heaps
{
    [TestClass]
    public class Qheap1Test
    {
        [TestMethod]
        public void TestCase1Qheap1Test()
        {
            //Arrange
            string[] commands = new[] { "1 4", "1 9", "3", "2 4", "3" };
            int[] expectedResult = new[] { 4, 9 };
            QHeap1 runner = new QHeap1();

            //Act
            var result = runner.Run(commands, commands.Length);

            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
