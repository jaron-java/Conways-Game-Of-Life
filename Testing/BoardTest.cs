using System;
using ConwaysGameOfLife;
using NUnit.Framework;

namespace BoardTest;

public class Tests
{
    [Test]
    public void CheckTest()
    {
        Board deadBoard = new Board(10, 10, false);
        Board liveBoard = new Board(10, 10, true);
        Assert.AreEqual(deadBoard.Check(2, 4), false);
        Assert.AreEqual(liveBoard.Check(2, 4), true);
    }
    [Test]
    public void ChecKNeighborTest()
    {
        Board deadBoard = new Board(10, 10, false);
        Board liveBoard = new Board(10, 10, true);
        Assert.AreEqual(liveBoard.CheckNeighbor(5, 5, Direction.UpLeft), true);
        Assert.AreEqual(deadBoard.CheckNeighbor(5, 5, Direction.Down), false);
    }

    [Test]
    public void CheckNeighborsTest()
    {
        Board deadBoard = new Board(10, 10, false);
        Board liveBoard = new Board(10, 10, true);
        int deadNeighbors = deadBoard.CheckNeighbors(5, 5);
        int liveNeighbors = liveBoard.CheckNeighbors(5, 5);
        Assert.AreEqual(deadNeighbors, 0);
        Assert.AreEqual(liveNeighbors, 8);
    }
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
    
    [Test]
    public void NotLiveDead() //this is just testing if they have the same memory 
    {
        Board deadBoard = new Board(10, 10,false);
        Board liveBoard = new Board(10, 10, true);
        Assert.AreNotEqual(deadBoard.GameBoard, liveBoard.GameBoard);
    }
}