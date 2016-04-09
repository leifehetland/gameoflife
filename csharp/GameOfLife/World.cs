﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public enum Cell
    {
        Alive,
        Dead,
    }

    public class Life
    {
        public static Cell GetNewCell(Cell currentCell, int liveNeighbors)
        {
            if (currentCell == Cell.Alive && liveNeighbors <= 2)
            {
                return Cell.Dead;
            }

            return currentCell;
        }
    }
}
