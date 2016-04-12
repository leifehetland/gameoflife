using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class StaticListGenerator : ICellGeneration
    {
        private readonly IEnumerable<Cell> _cells;
        public StaticListGenerator(IEnumerable<Cell> cells)
        {
            _cells = cells;
        }

        public List<Cell> MakeCells(int numberOfCellsToMake)
        {
            return _cells.ToList();
        }
    }
}
