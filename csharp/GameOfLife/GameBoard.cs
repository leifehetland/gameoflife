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
        gameWorld = new Cell[10, 10];

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                gameWorld[x, y] = new Cell();
            }
        }
    }

    public void checkNeighbors()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                int count = 0;

                if (this.gameWorld[mod((x - 1),10), mod((y + 1),10)].IsAlive)
                {
                    count++;
                }
                if (this.gameWorld[mod((x), 10), mod((y + 1), 10)].IsAlive)
                {
                    count++;
                }
                if (this.gameWorld[mod((x + 1), 10), mod((y + 1), 10)].IsAlive)
                {
                    count++;
                }

                if (this.gameWorld[mod((x - 1), 10), mod((y), 10)].IsAlive)
                {
                    count++;
                }
                if (this.gameWorld[mod((x + 1), 10), mod((y), 10)].IsAlive)
                {
                    count++;
                }

                if (this.gameWorld[mod((x - 1), 10), mod((y - 1), 10)].IsAlive)
                {
                    count++;
                }
                if (this.gameWorld[mod((x), 10), mod((y - 1), 10)].IsAlive)
                {
                    count++;
                }
                if (this.gameWorld[mod((x + 1), 10), mod((y - 1), 10)].IsAlive)
                {
                    count++;
                }
                this.gameWorld[x, y].neighbors = count;
            }
        }
    }
int mod(int x, int m)
{
    return (x % m + m) % m;
}

}