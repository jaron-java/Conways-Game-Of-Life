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
}