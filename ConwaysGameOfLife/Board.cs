namespace ConwaysGameOfLife;

public class Board
{
    public Cell[,] GameBoard { get; set; }
    private int Height { get; set; }
    private int Width { get; set; }

    public Board(int height, int width)
    {
        Height = height;
        Width = width;
        GameBoard = new Cell[Height, Width];
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                GameBoard[i, j] = new Cell();
            }
        }
    }

    public Board(int height, int width, bool Alive)
    : this(height, width)
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                if (Alive)
                    GameBoard[i, j] = new Cell(true);
                else
                    GameBoard[i, j] = new Cell(false);
            }
        }
    }

    public bool Check(int i, int j)
    {
        return GameBoard[i, j].IsAlive;
    }

    public bool CheckNeighbor(int i, int j, Direction dir)
    {
        int x = dir.X;
        int y = dir.Y;
        try
        {
            if (Check(i + x, j + y))
                return true;
            else
                return false;
        }
        catch (IndexOutOfRangeException e)
        {
            return false;
        }
    }

    public int CheckNeighbors(int i, int j)
    {
        int neighbors = 0;
        foreach (Direction dir in Direction._directions)
        {
            if (CheckNeighbor(i, j, dir))
                neighbors += 1;
        }

        return neighbors;
    }


    public void PrintBoard()
    {
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                Console.Write((int)GameBoard[i,j].State);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }

    public bool IsBoardAlive()
    {
        bool flag = false;
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                if (GameBoard[i, j].IsAlive)
                    flag = true;
            }
        }

        return flag;
    }
    
}