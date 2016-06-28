using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Gameboard gameboard = new Gameboard();

            gameboard.gameWorld[5, 5].IsAlive = true;
            gameboard.gameWorld[6, 5].IsAlive = true;
            gameboard.gameWorld[7, 5].IsAlive = true;
            gameboard.gameWorld[7, 4].IsAlive = true;
            gameboard.gameWorld[6, 3].IsAlive = true;

            gameboard.gameWorld[1, 8].IsAlive = true;
            gameboard.gameWorld[1, 9].IsAlive = true;
            gameboard.gameWorld[2, 8].IsAlive = true;
            gameboard.gameWorld[2, 9].IsAlive = true;

            gameboard.gameWorld[2, 1].IsAlive = true;
            gameboard.gameWorld[2, 2].IsAlive = true;
            gameboard.gameWorld[2, 3].IsAlive = true;

            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.WriteLine(gameboard.PutInConsole());
                gameboard.checkNeighbors();
                Thread.Sleep(500);
                gameboard.nextGeneration();
            }


        }
    }
}
