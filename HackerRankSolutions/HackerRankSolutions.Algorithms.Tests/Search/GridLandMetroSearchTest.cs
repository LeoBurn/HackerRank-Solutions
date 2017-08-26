using System;
using System.Numerics;
using HackerRankSolutions.Algorithms.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Search
{
    [TestClass]
    public class GridLandMetroTest
    {
        [TestMethod]
        public void ShoudlPointsOverLap()
        {
            //Arrange
            GridLandMetroSearch.Interval one = new GridLandMetroSearch.Interval() { Begin = 1, End = 2 };
            GridLandMetroSearch.Interval two = new GridLandMetroSearch.Interval() { Begin = 4, End = 5 };
            GridLandMetroSearch.Interval three = new GridLandMetroSearch.Interval() { Begin = 3, End = 10 };
            GridLandMetroSearch.Interval four = new GridLandMetroSearch.Interval() { Begin = 2, End = 5 };
            bool oneAndTwoOverlap = false;
            bool oneAndThreeOverlap = true;
            bool threeAndFourOverlap = true;
            GridLandMetroSearch runner = new GridLandMetroSearch();

            //Act
            var resultOne = runner.ItsOverlap(one, two);
            var resultTwo = runner.ItsOverlap(three, four);
            var resultThree = runner.ItsOverlap(one, three);

            //Assert
            Assert.AreEqual(resultOne, oneAndTwoOverlap);
            Assert.AreEqual(resultTwo, threeAndFourOverlap);
            Assert.AreEqual(resultThree, oneAndThreeOverlap);
        }

        [TestMethod]
        public void ShouldGetEmptyCells()
        {
            //Arrange
            int numberOfLine = 4;
            int numberOfColumns = 4;
            BigInteger expected = 9;
            int[][] grid = new int[][] { new int[] { 2, 2, 3 }, new int[] { 3, 1, 4 }, new int[] { 4, 4, 4 } };
            GridLandMetroSearch runner = new GridLandMetroSearch();

            //Act
            var result = runner.Run(numberOfLine, numberOfColumns, grid);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
