namespace ConwaysGameOfLife;

public enum CellState : int
{
    Dead = 0,
    Live = 1
}

public class Cell
{
    public CellState State { get; set; }
    private static Random rnd = new Random();
    
    public Cell()
    {
        int number = rnd.Next(2);
        var cellState = ((number == 0) ? State = CellState.Dead : CellState.Live);
        State = cellState;
    }

    public Cell(bool Alive)
    {
        var cellState = ((Alive) ? State = CellState.Live : CellState.Dead);
    }

    public bool IsAlive => (State == CellState.Live);
    public bool IsDead => (State == CellState.Dead);

    void PrintCell()
    {
        Console.WriteLine((int)State);
    }
    
    
}