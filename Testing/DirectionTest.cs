using System.Linq;
using ConwaysGameOfLife;
using NUnit.Framework;

[TestFixture]
public class DirectionTest
{
    [Test]
    public void AllDirections_HasCorrectNumberOfDirections()
    {
        Assert.AreEqual(Direction.AllDirections.Count(), 8);
    }

    [Test]
    public void LeftDirections_AreNegativeOnXAxis()
    {
        Assert.AreEqual(Direction.Left.X, -1);
        Assert.AreEqual(Direction.UpLeft.X, -1);
        Assert.AreEqual(Direction.DownLeft.X, -1);
    }

    [Test]
    public void RightDirections_ArePositiveOnXAxis()
    {
        Assert.AreEqual(Direction.Right.X, 1);
        Assert.AreEqual(Direction.UpRight.X, 1);
        Assert.AreEqual(Direction.DownRight.X, 1);
    }
    
    [Test]
    public void DownDirections_AreNegativeOnYAxis()
    {
        Assert.AreEqual(Direction.Down.Y, -1);
        Assert.AreEqual(Direction.DownLeft.Y, -1);
        Assert.AreEqual(Direction.DownRight.Y, -1);
    }
    
    [Test]
    public void UpDirections_ArePositiveOnYAxis()
    {
        Assert.AreEqual(Direction.Up.Y, 1);
        Assert.AreEqual(Direction.UpLeft.Y, 1);
        Assert.AreEqual(Direction.UpRight.Y, 1);
    }
}
