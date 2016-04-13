using System;
using System.Linq;
using System.Diagnostics;
using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameofLifeTests
{
    [TestClass]
    public class GameboardTests
    {
        [TestMethod]
        public void CanICreateAGameBoardInstance()
        {
            //Arrange 
            Gameboard gameWorld = new Gameboard();

            //Act

            //Assert
            Assert.IsNotNull(gameWorld);
        }

        [TestMethod]
        public void CanICreateAGameBoardWithDimensions()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            var value = gameboard.gameWorld[5, 5];
            var actual = value.IsAlive;
            var expected = false;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CanICreateAGameBoardWithAnAliveCell()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            gameboard.gameWorld[5, 5].IsAlive = true;
            var actual = gameboard.gameWorld[5, 5].IsAlive;
            var expected = true;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CanICheckForNeighbors()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            gameboard.gameWorld[5, 5].IsAlive = true;
            gameboard.gameWorld[5, 6].IsAlive = true;
            gameboard.gameWorld[5, 7].IsAlive = true;
            gameboard.checkNeighbors();
            var expected = 2;
            var actual = gameboard.gameWorld[5, 6].neighbors;


            

            //Assert
            Assert.AreEqual(expected, actual );
        }

        [TestMethod]
        public void CanICreateABlinker()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            gameboard.gameWorld[5, 5].IsAlive = true;
            gameboard.gameWorld[5, 6].IsAlive = true;
            gameboard.gameWorld[5, 7].IsAlive = true;
            gameboard.checkNeighbors();
            gameboard.nextGeneration();
            var expected = true;
            var actual1 = gameboard.gameWorld[4, 6].IsAlive;
            var actual2 = gameboard.gameWorld[5, 6].IsAlive;
            var actual3 = gameboard.gameWorld[6, 6].IsAlive;



            //Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod]
        public void CanICreateABlinkerPt2()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            gameboard.gameWorld[5, 5].IsAlive = true;
            gameboard.gameWorld[5, 6].IsAlive = true;
            gameboard.gameWorld[5, 7].IsAlive = true;
            gameboard.checkNeighbors();
            gameboard.nextGeneration();
            gameboard.checkNeighbors();
            gameboard.nextGeneration();
            var expected = true;
            var actual1 = gameboard.gameWorld[5, 5].IsAlive;
            var actual2 = gameboard.gameWorld[5, 6].IsAlive;
            var actual3 = gameboard.gameWorld[5, 7].IsAlive;



            //Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod]
        public void CanICreateABlinkerAtTheEdge()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            gameboard.gameWorld[0, 9].IsAlive = true;
            gameboard.gameWorld[0, 0].IsAlive = true;
            gameboard.gameWorld[0, 1].IsAlive = true;
            gameboard.checkNeighbors();
            gameboard.nextGeneration();
            var expected = true;
            var actual1 = gameboard.gameWorld[9, 0].IsAlive;
            var actual2 = gameboard.gameWorld[0, 0].IsAlive;
            var actual3 = gameboard.gameWorld[1, 0].IsAlive;



            //Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod]
        public void CanIConfirmDeadCellsWithBlinker()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard();

            //Act
            gameboard.gameWorld[5, 5].IsAlive = true;
            gameboard.gameWorld[5, 6].IsAlive = true;
            gameboard.gameWorld[5, 7].IsAlive = true;
            gameboard.checkNeighbors();
            gameboard.nextGeneration();
            
            var expected = false;
            var actual1 = gameboard.gameWorld[5, 5].IsAlive; //Dead Cell
            var actual2 = gameboard.gameWorld[5, 7].IsAlive; //Dead Cell



            //Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void CanICreateAnInstanceOfGameboardToString()
        {
            //Arrange
            Gameboard gameboard = new Gameboard();
            var expected = gameboard.PutInConsole();

            //Act

            //Assert
            Assert.IsNotNull(expected);
        }
    }
}
