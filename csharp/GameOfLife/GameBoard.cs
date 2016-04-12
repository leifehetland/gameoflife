using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

public class Gameboard
{
    public Cell[,] gameWorld { set; get; } 

    public Gameboard()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                this.gameWorld[x, y] = new Cell();
            }
        }
    }

}