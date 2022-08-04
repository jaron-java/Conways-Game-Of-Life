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

    public bool CompareBoards()
    {
        bool flag = true;
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                if (CurrentBoard.GameBoard[i, j] != ExtraBoard.GameBoard[i, j])
                    flag = false;
            }
        }
        return flag;
    }

    public void PlayGame()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine($"======{Iterations}========");
            CurrentBoard.PrintBoard();
            Thread.Sleep(3000);
            Iterations++;
            Console.Clear();
            flag = CurrentBoard.IsBoardAlive();
            UpdateBoard();
        }
    }
}