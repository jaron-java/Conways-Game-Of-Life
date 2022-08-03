namespace ConwaysGameOfLife;

public enum Directions : int //helps cast/tie ints to enum
{
    UpLeft = 0,
    Up, //will automatically equal 1, next is 2, etc
    UpRight,
    Left,
    Right,
    DownLeft,
    Down,
    DownRight
}

public class Direction
{
    public static readonly Direction[] _directions = new[]
    {
        new Direction(-1, 1), // Up Left
        new Direction(0, 1), // Up
        new Direction(1, 1), // Up Right
        new Direction(-1, 0), // Left
        new Direction(1, 0), // Right
        new Direction(-1, -1), // Down Left
        new Direction(0, -1), // Down
        new Direction(1, -1), // Down Right
    };

    public static IEnumerable<Direction> AllDirections => _directions;
    //returns an iterable list (IEnumerable) of directions enum

    public int X { get; private set; }
    public int Y { get; private set; }

    private Direction(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Direction GetDirection(Directions dir) => _directions[(int)dir];
    //Takes a Direction enum as parameter, returns hte matching _direction direction;
    //returns a Direction

    public static Direction UpLeft => GetDirection(Directions.UpLeft); //uses the upleft Enum to get matching _direction
    public static Direction Up => GetDirection(Directions.Up);
    public static Direction UpRight => GetDirection(Directions.UpRight);
    public static Direction Left => GetDirection(Directions.Left);
    public static Direction Right => GetDirection(Directions.Right);
    public static Direction DownLeft => GetDirection(Directions.DownLeft);
    public static Direction Down => GetDirection(Directions.Down);
    public static Direction DownRight => GetDirection(Directions.DownRight);
    
}