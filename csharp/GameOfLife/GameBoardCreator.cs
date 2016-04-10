using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

public class GameboardCreator
{
    public List<string> Creator(Gameboard Gameboard)
    {
        if (Gameboard == null)
        {
            throw new ArgumentNullException("Gameboard cannot be null");
        }

        var outputLine = new List<string>();

        foreach (var row in Gameboard.Rows)
        {
            int outputLength = row.Count;
            var thisRow = Enumerable.Repeat(" ", outputLength).ToString();
            outputLine.Add(thisRow);
    {

    }
        }
    }
}

