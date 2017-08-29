using System;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class DesignerPDFViewerTest
    {
        [TestMethod]
        public void ShouldGetArea()
        {
            //Arrange
            int[] sizes = {1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
            string word = "abc";
            int expectedValue = 9;
            DesignerPDFViewer runner = new DesignerPDFViewer();

            //Act
            var result = runner.Run(word, sizes);

            //Assert
            Assert.AreEqual(expectedValue,result);
        }
    }
}
