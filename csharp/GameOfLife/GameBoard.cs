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

    public void nextGeneration()
    {
        var nextGeneration = new Gameboard();

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                int count = this.gameWorld[x, y].neighbors;
                bool living = this.gameWorld[x, y].IsAlive;

                if (living && count < 2)
                {
                    nextGeneration.gameWorld[x, y].IsAlive = false;
                }
                if (living && (count == 2 || count == 3))
                {
                    nextGeneration.gameWorld[x, y].IsAlive = true;
                }
                if (living && count > 3)
                {
                    nextGeneration.gameWorld[x, y].IsAlive = false;
                }
                if (!living && count == 3)
                {
                    nextGeneration.gameWorld[x, y].IsAlive = true;
                }
            }
        }
        this.gameWorld = nextGeneration.gameWorld;
    }

    public String PutInConsole()
    {
        StringBuilder buildMyString = new StringBuilder();
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                buildMyString.Append(this.gameWorld[x, y].IsAlive ? "O" : " ");
            }
            buildMyString.AppendLine();
        }
        return buildMyString.ToString();
    
    }

    int mod(int x, int m)
    {
        return (x % m + m) % m;
    }

}