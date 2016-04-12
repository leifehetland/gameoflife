using System;
using System.Linq;
using System.Diagnostics;
using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeTests
{
    [TestClass]
    public class CellTests
    {
        //[TestMethod]
        //public void CanICreateACellInstance()
        //{
        //    //Arrange 
        //    Cell Cell = new Cell();

        //    //Act

        //    //Assert
        //    Assert.IsNotNull(Cell);
        //}

        //[TestMethod]
        //public void LessThanTwoNeighborsDies()
        //{
        //    //Arrange 
        //    Cell currentCell = Cell.Alive;
        //    int liveNeighbors = 1;

        //    //Act
        //    Cell result = Life.GetNewCell(currentCell, liveNeighbors);

        //    //Assert
        //    Assert.AreEqual(Cell.Dead, result);
        //}

        //[TestMethod]
        //public void TwoOrThreeLiveNeighborsLives()
        //{
        //    //Arrange 
        //    Cell currentCell = Cell.Alive;
        //    int liveNeighbors = 3;

        //    //Act
        //    Cell result = Life.GetNewCell(currentCell, liveNeighbors);

        //    //Assert
        //    Assert.AreEqual(Cell.Alive, result);
        //}

        //[TestMethod]
        //public void MoreThanThreeNeighborsDies()
        //{
        //    //Arrange 
        //    Cell currentCell = Cell.Alive;
        //    int liveNeighbors = 4;

        //    //Act
        //    Cell result = Life.GetNewCell(currentCell, liveNeighbors);

        //    //Assert
        //    Assert.AreEqual(Cell.Dead, result);
        //}

        //[TestMethod]
        //public void ExactlyThreeNeighborsLives()
        //{
        //    //Arrange 
        //    Cell currentCell = Cell.Dead;
        //    int liveNeighbors = 3;

        //    //Act
        //    Cell result = Life.GetNewCell(currentCell, liveNeighbors);

        //    //Assert
        //    Assert.AreEqual(Cell.Alive, result);
        //}
    }
}
