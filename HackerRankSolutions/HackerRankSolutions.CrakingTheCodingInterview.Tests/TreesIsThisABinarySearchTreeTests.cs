using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankSolutions.CrakingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankSolutions.CrakingTheCodingInterview.Tests
{ 

    [TestClass]
    public class TreesIsThisABinarySearchTreeTests
    {
        [TestMethod]
        public void TreesIsThisABinarySearchTreeTestCase1()
        {
            //Arrange
            TreesIsThisABinarySearchTree runner = new TreesIsThisABinarySearchTree();
            Node root = new Node() {Data = 4 , Left = new Node()
                                                {
                                                    Data = 2,
                                                    Left = new Node(){ Data = 1} ,
                                                    Right = new Node(){Data = 3}},
                                                Right = new Node()
                                                {
                                                    Data = 6,
                                                    Left = new Node() { Data = 5},
                                                    Right = new Node() { Data = 7}
                                                }
            };
            var expectedValue = true;
            
            //Act
            var result = runner.Run(root);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TreesIsThisABinarySearchTreeTestCase2()
        {
            //Arrange
            TreesIsThisABinarySearchTree runner = new TreesIsThisABinarySearchTree();
            Node root = new Node()
            {
                Data = 4,
                Left = new Node()
                {
                    Data = 3,
                    Left = new Node() { Data = 2 },
                    Right = new Node() { Data = 3 }
                },
                Right = new Node()
                {
                    Data = 6,
                    Left = new Node() { Data = 5 },
                    Right = new Node() { Data = 7 }
                }
            };
            var expectedValue = false;

            //Act
            var result = runner.Run(root);

            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
