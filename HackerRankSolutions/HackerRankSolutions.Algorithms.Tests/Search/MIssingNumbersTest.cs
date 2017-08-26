using System;
using System.Text;
using System.Collections.Generic;
using HackerRankSolutions.Algorithms.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Search
{
    /// <summary>
    /// Summary description for MissingNumbersTest
    /// </summary>
    [TestClass]
    public class MissingNumbersTest
    {
        [TestMethod]
        public void ShouldGetThreeMissingValues()
        {
           //Arrange
            int[] a = new[] {203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] b = new[] {203,204,204,205,206,207,205,208,203,206,205,206,204};
            int[] expectedValues = new[] {204, 205, 206};
            MissingNumbers runner = new MissingNumbers();
            
            //Act
            var result = runner.Run(a, b);

            //Assert
            CollectionAssert.AreEqual(expectedValues,result);
        }
    }
}
