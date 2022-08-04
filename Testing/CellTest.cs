using ConwaysGameOfLife;
using NUnit.Framework;

namespace CellTest;
[TestFixture]
public class Tests
{
    
    [Test]
    public void UpDateCellTest()
    {
        Cell liveCell = new Cell(true);
        Cell deadCell = new Cell(false);
        Cell upDatingCell = new Cell(true);
        Cell cell1 = upDatingCell.UpdateCell(1);
        Assert.AreNotEqual(liveCell.State, cell1.State);
        Cell cell2 = cell1.UpdateCell(2);
        Assert.AreEqual(deadCell.State, cell2.State);
        Cell cell3 = cell2.UpdateCell(3);
        Assert.AreEqual(liveCell.State, cell3.State);
        Cell cell4 = cell3.UpdateCell(0);
        Assert.AreEqual(cell4.State, deadCell.State);
        Cell cell5 = cell4.UpdateCell(1);
        Assert.AreEqual(deadCell.State, cell5.State);
        Cell cell6 = cell5.UpdateCell(2);
        Assert.AreEqual(cell6.State, deadCell.State);
        Cell cell7 = cell6.UpdateCell(3);
        Assert.AreNotEqual(cell7.State, deadCell.State);
        Cell cell8 = cell7.UpdateCell(4);
        Assert.AreEqual(cell8.State, deadCell.State);
    }
    
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
}