using ConwaysGameOfLife;
using NUnit.Framework;

namespace CellTest;

public class Tests
{
    [Test]
    public void LiveTest()
    {
        
        Cell liveCell = new Cell();
        liveCell.State = CellState.Live;
        Cell maybeLiveCell = new Cell(true);
        Assert.AreEqual(liveCell.State, maybeLiveCell.State);
    }

    [Test]
    public void DeadTest()
    {
        Cell deadCell = new Cell();
        deadCell.State = CellState.Dead;
        Cell maybeDeadCell = new Cell(false);
        Assert.AreEqual(deadCell.State, maybeDeadCell.State);
    }

    [Test]
    public void FailingCompareTest()
    {
        Cell liveCell = new Cell(true);
        Cell deadCell = new Cell(false);
        Assert.AreEqual(liveCell.State, deadCell.State);
    }

    [Test]
    public void IsAlive()
    {
        Cell liveCell = new Cell(true);
        Assert.AreEqual(liveCell.IsAlive, true);
    }

    [Test]
    public void IsNotAlive()
    {
        Cell liveCell = new Cell(true);
        Assert.AreEqual(liveCell.IsDead, false);
    }

    [Test]
    public void IsDead()
    {
        Cell deadCell = new Cell(false);
        Assert.AreEqual(deadCell.IsDead, true);
    }

    [Test]
    public void IsNotDead()
    {
        Cell deadCell = new Cell(false);
        Assert.AreEqual(deadCell.IsAlive, false);
    }

    [Test]
    public void failingIsLive()
    {
        Cell liveCell = new Cell(true);
        Assert.AreEqual(liveCell.IsAlive, false);
    }

    [Test]
    public void failingIsDead()
    {
        Cell deadCell = new Cell(false);
        Assert.AreEqual(deadCell.IsDead, false);
    }
}