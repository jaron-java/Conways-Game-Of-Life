using System;
using ConwaysGameOfLife;
using NUnit.Framework;

namespace BoardTest;

public class Tests
{
    [Test]
    public void BoardIsDead()
    {
        Board deadBoard = new Board(10, 10, false);
        Assert.AreEqual(deadBoard.IsBoardAlive(), false);
    }

    [Test]
    public void BoardIsAlive()
    {
        Board liveBoard = new Board(10, 10, true);
        Assert.AreEqual(liveBoard.IsBoardAlive(), true);
    }

    // [Test]
    // public void IsBoardDead()
    // {
    //     Board deadBoard = new Board(10, 10, false);
    //     Assert.AreEqual(Array.Exists<Cell>(deadBoard, element => element == (CellState.Live)), false);
    // }
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
    public void NotLiveDead() //this is just testing if they have the same memory 
    {
        Board deadBoard = new Board(10, 10,false);
        Board liveBoard = new Board(10, 10, true);
        Assert.AreNotEqual(deadBoard.GameBoard, liveBoard.GameBoard);
    }

    [Test]
    public void NotSize()
    {
        Board smallBoard = new Board(2, 2);
        Board largeBoard = new Board(20, 20);
        Assert.AreNotEqual(smallBoard, largeBoard);
    }

    [Test]
    public void NotBoard()
    {
        Board board = new Board(10, 10);
        Board deadBoard = new Board(10, 10, false);
        Assert.AreNotEqual(board, deadBoard);
    }
}