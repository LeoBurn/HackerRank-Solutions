using System;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class DrawingBookTest
    {
        [TestMethod]
        public void ShouldGetTurnedPageWithEvenPageNumberAndEvenTotalPage()
        {
            //Arrange    
            int numberOfPages = 6;
            int page = 4;
            int expectedValue = 1;
            DrawingBook runner = new DrawingBook();

            //Act
            var result = runner.Run(numberOfPages, page);
            
            //Assert
            Assert.AreEqual(expectedValue,result);
        }

        [TestMethod]
        public void ShouldGetTurnedPageWithOddPageNumberAndEvenTotalPage()
        {
            //Arrange    
            int numberOfPages = 6;
            int page = 5;
            int expectedValue = 1;
            DrawingBook runner = new DrawingBook();

            //Act
            var result = runner.Run(numberOfPages, page);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
