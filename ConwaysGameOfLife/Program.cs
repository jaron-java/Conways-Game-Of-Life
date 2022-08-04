using System.Linq;
namespace ConwaysGameOfLife;

class Program
{
    static void Main()
    {
        Game newGame = new Game(10, 10);
        Console.WriteLine("Conways Game Of Life");
        Console.ReadKey();
        Console.WriteLine("In the beginning, there were only zeroes");
        Console.ReadKey();
        Console.WriteLine("Then James Conway said 'Let there be life!'");
        newGame.PlayGame();
    }
}