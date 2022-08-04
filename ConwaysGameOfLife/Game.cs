namespace ConwaysGameOfLife;

public class Game
{
    public Board CurrentBoard { get; set; }
    public Board ExtraBoard { get; set; }
    public int Iterations { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public Game(int height, int width)
    {
        Height = height;
        Width = width;
        Iterations = 0;
        CurrentBoard = new Board(Height, Width);
        ExtraBoard = new Board(Height, Width);
    }

    public void UpdateBoard()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                int neighbors = CurrentBoard.CheckNeighbors(i, j);
                Cell newCell = CurrentBoard.GameBoard[i, j].UpdateCell(neighbors);
                ExtraBoard.GameBoard[i, j] = newCell;
            }
        }

        CurrentBoard = ExtraBoard;
    }
    
}