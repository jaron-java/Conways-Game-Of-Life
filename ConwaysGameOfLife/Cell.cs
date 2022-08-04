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
        State = ((number == 0) ? State = CellState.Dead : CellState.Live);
        // State = cellState;
    }

    public Cell(bool Alive)
    {
        State = ((Alive) ? State = CellState.Live : CellState.Dead);
    }

    public bool IsAlive => (State == CellState.Live);
    public bool IsDead => (State == CellState.Dead);

    public Cell UpdateCell(int neighbors)
    {
        Cell newCell = new Cell();
        if (State == CellState.Dead)
        {
            if (neighbors == 3)
                newCell.State = CellState.Live;
            else
                newCell.State = CellState.Dead;
        }
        else
        {
            if (neighbors == 2 || neighbors == 3)
                newCell.State = CellState.Live;
            else
                newCell.State = CellState.Dead;
        }

        return newCell;
    }

    void PrintCell()
    {
        Console.WriteLine((int)State);
    }
}