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
        [TestMethod]
        public void CanICreateACellInstance()
        {
            //Arrange 
            Cell cell = new Cell();

            //Act
            

            //Assert
            Assert.IsNotNull(cell);
        }

        [TestMethod]
        public void CanICreateADeadCell()
        {
            //Arrange 
            Cell cell = new Cell();

            //Act
            var actual = cell.IsAlive;
            var expected = false;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CanICreateAnAliveCell()
        {
            //Arrange 
            Cell cell = new Cell();

            //Act
            cell.IsAlive = true;
            var actual = cell.IsAlive;
            var expected = true;


            //Assert
            Assert.AreEqual(actual, expected);
        }

    //    [TestMethod]
    //    public void LessThanTwoNeighborsDies()
    //    {
    //        //Arrange 
    //        Cell currentCell = new Cell();
            

    //        //Act
            

    //        //Assert
            
    //    }

    //    [TestMethod]
    //    public void TwoOrThreeLiveNeighborsLives()
    //    {
    //        //Arrange 
            

    //        //Act
            

    //        //Assert
            
    //    }

    //    [TestMethod]
    //    public void MoreThanThreeNeighborsDies()
    //    {
    //        //Arrange 
            

    //        //Act
            

    //        //Assert
            
    //    }

    //    [TestMethod]
    //    public void ExactlyThreeNeighborsLives()
    //    {
    //        //Arrange 
            

    //        //Act
            

    //        //Assert
            
    //    }
    }
}
