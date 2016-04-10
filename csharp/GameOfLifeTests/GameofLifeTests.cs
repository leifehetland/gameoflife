using System;
using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeTests
{
    [TestClass]
    public class GameofLifeTests
    {
        [TestMethod]
        public void CanICreateAGameBoardInstance()
        {
            //Arrange 
            Gameboard Gameboard = new Gameboard(25,25);

            //Act

            //Assert
            Assert.IsNotNull(Gameboard);
            Assert.AreEqual(Gameboard.Width, 25);
            Assert.AreEqual(Gameboard.Height, 25);
        }

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
        public void CanICreateAnInstanceOfGamboardCreator()
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
        public void CanICreateACellInstance()
        {
            //Arrange 
            Cell Cell = new Cell();

            //Act

            //Assert
            Assert.IsNotNull(Cell);
        }

        [TestMethod]
        public void LessThanTwoNeighborsDies()
        {
            //Arrange 
            Cell currentCell = Cell.Alive;
            int liveNeighbors = 1;

            //Act
            Cell result = Life.GetNewCell(currentCell, liveNeighbors);

            //Assert
            Assert.AreEqual(Cell.Dead, result);
        }

        [TestMethod]
        public void TwoOrThreeLiveNeighborsLives()
        {
            //Arrange 
            Cell currentCell = Cell.Alive;
            int liveNeighbors = 3;

            //Act
            Cell result = Life.GetNewCell(currentCell, liveNeighbors);

            //Assert
            Assert.AreEqual(Cell.Alive, result);
        }

        [TestMethod]
        public void MoreThanThreeNeighborsDies()
        {
            //Arrange 
            Cell currentCell = Cell.Alive;
            int liveNeighbors = 4;

            //Act
            Cell result = Life.GetNewCell(currentCell, liveNeighbors);

            //Assert
            Assert.AreEqual(Cell.Dead, result);
        }

        [TestMethod]
        public void ExactlyThreeNeighborsLives()
        {
            //Arrange 
            Cell currentCell = Cell.Dead;
            int liveNeighbors = 3;

            //Act
            Cell result = Life.GetNewCell(currentCell, liveNeighbors);

            //Assert
            Assert.AreEqual(Cell.Alive, result);
        }
    }
}
