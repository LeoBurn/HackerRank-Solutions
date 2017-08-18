using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class MigratoryBirdsTest
    {
        [TestMethod]
        public void ShouldGet4Type()
        {
            //Arrange
            int[] arr = new[] {1, 4, 4, 4, 5, 3};
            int expectedResult = 4;
            MigratoryBirds runner = new MigratoryBirds();
            
            //Act
            var result = runner.Run(arr, arr.Length);

            //Assert
            Assert.AreEqual(expectedResult,result);
        }
    }
}
