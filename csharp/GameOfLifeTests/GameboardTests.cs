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

    }
}
