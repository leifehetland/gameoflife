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


    }
}
