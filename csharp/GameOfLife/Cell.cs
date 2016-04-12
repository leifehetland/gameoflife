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
        public int neighbors { get; set; }

        public Cell()
        {
            IsAlive = false;
            neighbors = 0;
        }
    }
}
