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
    
}