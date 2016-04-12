using System;
using System.Linq;
using System.Diagnostics;
using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeTests
{
    [TestClass]
    public class GameboardCreatorTests
    {
        [TestMethod]
        public void CanISetupAGameboardCreatorThatsNotNull()
        {
            //Arrange 
            GameboardCreator creator = new GameboardCreator();

            //Act

            //Assert
            Assert.IsNotNull(creator);

        }

        [TestMethod]
        public void CanICreateAnInstanceOfGameboardCreator()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard(10, 10);
            GameboardCreator creator = new GameboardCreator();

            //Act
            var output = creator.Creator(gameboard);


            //Assert
            Assert.AreEqual(output.Count, 10);
        }

        [TestMethod]
        public void CanICreateAnInstanceOfGameboardCreatorWidth()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard(30, 10);
            GameboardCreator creator = new GameboardCreator();

            //Act
            var output = creator.Creator(gameboard);


            //Assert
            Assert.AreEqual(output.First().Length, 30);
        }

        [TestMethod]
        public void CanICreateAnInstanceOfADeadCell()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard(1, 1);
            GameboardCreator creator = new GameboardCreator();

            //Act
            var output = creator.Creator(gameboard);


            //Assert
            Assert.AreEqual(output.First(), "-");
        }

        



    }
}
