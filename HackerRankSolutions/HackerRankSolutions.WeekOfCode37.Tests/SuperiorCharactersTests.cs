using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.WeekOfCode37.Tests
{
    [TestClass]
    public class SuperiorCharactersTests
    {
        [TestMethod]
        public void SuperiorCharactersFirstTestCase()
        {
            //Arrange
            int[] words = new int[] { 0,0,0,0,2,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0};
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 1;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue,result);
        }

        [TestMethod]
        public void SuperiorCharactersSecondTestCase()
        {
            //Arrange
            int[] words = new int[] { 1, 2, 2, 3, 4, 0, 3, 4, 4, 1, 3, 1, 4, 4, 1, 0, 0, 0, 0, 0, 4, 2, 3, 2, 2, 1 };
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 25;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SuperiorCharactersThirdTestCase()
        {
            //Arrange
            int[] words = new int[] { 1, 1, 3, 3, 1, 1, 4, 4, 3, 1, 3, 3, 3, 0, 1, 2, 0, 4, 2, 1, 3, 0, 3, 1, 1, 1 };
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 24;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SuperiorCharactersFourthTestCase()
        {
            //Arrange
            int[] words = new int[] { 2, 1, 4, 1, 0, 2, 0, 3, 1, 2, 0, 3, 1, 1, 2, 0, 1, 4, 2, 3, 2, 3, 2, 0, 2, 1 };
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 21;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SuperiorCharactersFifthTestCase()
        {
            //Arrange
            int[] words = new int[] { 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 0;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SuperiorCharactersSixtTestCase()
        {
            //Arrange
            int[] words = new int[] { 15, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 7;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SuperiorCharactersSeventhTestCase()
        {
            //Arrange
            int[] words = new int[] { 1, 3, 8, 1, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SuperiorCharacters runner = new SuperiorCharacters();
            int expectedValue = 7;

            //Act
            var result = runner.MaximumSuperiorCharacters(words, 1);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
