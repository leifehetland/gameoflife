using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

public class GameboardCreator
{
    public List<string> Creator(Gameboard gameboard)
    {
        if (gameboard == null)
        {
            throw new ArgumentNullException("Gameboard cannot be null");
        }

        var outputLine = new List<string>();

        for (var y = 0; y < gameboard.Height; y++)
        {
            var buffer = new StringBuilder();

            for (var x = 0; x < gameboard.Width; x++)
            {
                var cell = gameboard.Board[x, y];
                buffer.Append(cell.IsAlive ? "X" : "-");
            }

            outputLine.Add(buffer.ToString());
        }
        return outputLine;
    }
}

