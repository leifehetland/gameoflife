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
            var board = new Gameboard(20, 40);
            var creator = new GameboardCreator();

            for (int i = 0; i <= 100; i++)
            {
                board.Generations();
                var output = creator.Creator(board);

                Console.Clear();
                foreach (var line in output)
                {
                    Console.WriteLine(line);
                }
                Thread.Sleep(2000);
            }             
        }
    }
}
