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



            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine(gameboard.PutInConsole());
                gameboard.checkNeighbors();
                Thread.Sleep(2000);
                gameboard.nextGeneration();
            }


        }
    }
}
