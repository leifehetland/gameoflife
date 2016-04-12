using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Cell()
        {
            X = Int32.MinValue;
            Y = Int32.MinValue;
        }
    }
}
