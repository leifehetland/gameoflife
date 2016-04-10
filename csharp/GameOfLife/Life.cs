using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

    public enum Cell
    {
        Alive,
        Dead,
    }

    public class Life
    {
        public static Cell GetNewCell(Cell currentCell, int liveNeighbors)
        {
            if (currentCell == Cell.Alive && liveNeighbors < 2)
            {
                return Cell.Dead;
            }

            if (currentCell == Cell.Alive && liveNeighbors > 3)
            {
                return Cell.Dead;
            }

            if (currentCell == Cell.Dead && liveNeighbors == 3)
            {
                return Cell.Alive;
            }

            return currentCell;
        }
    }
