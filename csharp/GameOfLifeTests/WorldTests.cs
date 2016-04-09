using System;
using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeTests
{
    [TestClass]
    public class WorldTests
    {
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
    }
}
