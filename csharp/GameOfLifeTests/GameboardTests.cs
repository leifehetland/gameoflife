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
            Gameboard gameboard = new Gameboard(25, 25);

            //Act

            //Assert
            Assert.IsNotNull(gameboard);
            Assert.AreEqual(gameboard.Width, 25);
            Assert.AreEqual(gameboard.Height, 25);
        }

        [TestMethod]
        public void CanICreateAGameBoardWithRows()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard(25, 25);
            GameboardCreator creator = new GameboardCreator();

            //Act
            var output = creator.Creator(gameboard);

            //Assert
            Assert.IsNotNull(gameboard);
            Assert.AreEqual(output.First().Length, 25);
        }

        //[TestMethod]
        //public void CanICreateAGameBoardWithPopulatedCells()
        //{
        //    //Arrange 
        //    Gameboard gameboard = new Gameboard(5, 5);

        //    //Act

        //    //Assert
        //    Assert.IsInstanceOfType(gameboard, typeof(Cell));
        //}

        [TestMethod]
        public void DoesMyCellMakerWork()
        {
            //Arrange 
            Gameboard gameboard = new Gameboard(5, 5);
            var expectedCell = new Cell();

            //Act

            //Assert
            Assert.ReferenceEquals(gameboard, expectedCell);
        }

        [TestMethod]
        public void CellMakerWhenAskedForTwoCellsMakeOneAliveOneDead()
        {
            //Arrange 
            var cellMaker = new CellMaker();

            //Act
            var cells = cellMaker.MakeCells(2);

            //Assert
            Assert.AreEqual(cells.Count(x => x.IsAlive), 1);
            Assert.AreEqual(cells.Count(x => !x.IsAlive), 1);
        }

        [TestMethod]
        public void CellMakerWhenAskedForThreeCells()
        {
            //Arrange 
            var cellMaker = new CellMaker();

            //Act
            var cells = cellMaker.MakeCells(3);

            //Assert
            Assert.AreEqual(cells.Count(x => x.IsAlive), 1);
            Assert.AreEqual(cells.Count(x => !x.IsAlive), 2);
        }
    }
}
