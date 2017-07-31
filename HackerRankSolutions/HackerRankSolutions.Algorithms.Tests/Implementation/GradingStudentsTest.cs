using System;
using HackerRankSolutions.Algorithms.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    [TestClass]
    public class GradingStudentsTest
    {
        [TestMethod]
        public void SouldTestGrades()
        {
            //Arrange
            int[] grades = new[] {73, 67, 38, 33};
            int[] expectedgrades = new[] {75, 67, 40, 33};
            GradingStudents runner = new GradingStudents();

            //Act
            var result = runner.Run(grades);
            
            //Assert
            CollectionAssert.AreEqual(expectedgrades, result);
        }
    }
}
