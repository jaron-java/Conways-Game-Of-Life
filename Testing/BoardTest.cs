using ConwaysGameOfLife;
using NUnit.Framework;

namespace BoardTest;

public class Tests
{
    [Test]
    public void TestHeight()
    {
        Board newBoard = new Board(10, 1);
        Assert.AreEqual(newBoard.GameBoard.GetLength(0), 10);
    }

    [Test]
    public void TestWidth()
    {
        Board newBoard = new Board(1, 10);
        Assert.AreEqual(newBoard.GameBoard.GetLength(1), 10);
    }

    [Test]
    public void TestTotal()
    {
        Board newBoard = new Board(10, 10);
        Assert.AreEqual(newBoard.GameBoard.Length, 100);
    }

    [Test]
    public void FailLiveDead()
    {
        Board deadBoard = new Board(10, 10,false);
        Board liveBoard = new Board(10, 10, true);
        Assert.AreEqual(deadBoard.GameBoard, liveBoard.GameBoard);
    }

    [Test]
    public void FailSize()
    {
        Board smallBoard = new Board(2, 2);
        Board largeBoard = new Board(20, 20);
        Assert.AreEqual(smallBoard, largeBoard);
    }

    [Test]
    public void FailBoard()
    {
        Board board = new Board(10, 10);
        Board deadBoard = new Board(10, 10, false);
        Assert.AreEqual(board, deadBoard);
    }
}