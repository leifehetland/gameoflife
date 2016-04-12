using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

public class Gameboard
{
    private readonly ICellGeneration _cellMaker;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Cell [,] Board { get; set; }


    public Gameboard(int width, int height, ICellGeneration cellMaker = null )
    {
        _cellMaker = cellMaker ?? new CellMaker();
        Width = width;
        Height = height;
        
        GenerateState();
    }

    private void GenerateState()
    {
        var groupOfCells = new Stack<Cell>(_cellMaker.MakeCells(Width * Height));

        Board = new Cell[Width,Height];

        for (var y = 0; y < Height; y++)
        {
            for (var x = 0; x < Width; x++)
            {
                var cell = groupOfCells.Pop();
                cell.X = x;
                cell.Y = y;
                Board[x, y] = cell;
            }
        }
    }

    public void Generations()
    {
        var nextGen = new Cell[Width, Height];

        for (var y = 0; y < Height; y++)
        {
            for (var x = 0; x < Height; x++)
            {
                var existingCell = Board[x, y]; 
                var newGen = DetermineGen(existingCell);
                nextGen[x,  y] = newGen;
            }
        }
        Board = nextGen;
    }    

    private Cell DetermineGen(Cell cell)
    {
        var neighbors = GetNeighbors(cell);

        if (neighbors.Count(x => x.IsAlive) == 2 
            || neighbors.Count(x => x.IsAlive) == 3)
        {
            return new Cell { IsAlive = true, X = cell.X, Y = cell.Y };
        }

        if (neighbors.Count(x => x.IsAlive) < 2)
        {
            return new Cell { IsAlive = false, X = cell.X, Y = cell.Y };
        }

        if (neighbors.Count(x => x.IsAlive) > 3)
        {
            return new Cell { IsAlive = false, X = cell.X, Y = cell.Y };
        }
        return new Cell { IsAlive = false };

        
    }

    private IEnumerable<Cell> GetNeighbors(Cell cell)
    {
        var coords = new List<Coord>
        {
            new Coord(cell.X - 1, cell.Y-1),
            new Coord(cell.X - 1, cell.Y),
            new Coord(cell.X - 1, cell.Y+1),

            new Coord(cell.X, cell.Y-1),
            new Coord(cell.X, cell.Y+1),

            new Coord(cell.X + 1, cell.Y-1),
            new Coord(cell.X + 1, cell.Y),
            new Coord(cell.X + 1, cell.Y+1),
        };

        var neighbors = new List<Cell>();
        foreach (var getThis in coords)
        {
            try
            {
                neighbors.Add(Board[getThis.X, getThis.Y]);
            }
            catch
            {
                throw new Exception(); 
            }   
        }
        return neighbors;
    }
}

public class Coord
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coord(int x, int y)
    {
        X = x;
        Y = y;
    }
}