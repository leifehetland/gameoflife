using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

    public class Gameboard
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public IList<List<Cell>> Rows { get; set; }

        public Gameboard(int width, int height)
        {
            Width = width;
            Height = height;
        }

    }

