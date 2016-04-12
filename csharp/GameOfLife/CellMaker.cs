using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class CellMaker : ICellGeneration
    {
        public List<Cell> MakeCells(int numberOfCellsToMake)
        {
            var half = numberOfCellsToMake / 2;

            var list = new List<Cell>();
            list.AddRange(Enumerable.Repeat(new Cell { IsAlive = true }, half));
            list.AddRange(Enumerable.Repeat(new Cell(), half));

            while (list.Count != numberOfCellsToMake)
            {
                list.Add(new Cell());
            }

            return list;
        }
    }
}
