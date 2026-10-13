
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GithubActionsLab;

namespace Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void AddPositiveNumbersDubas()
    {
        Assert.AreEqual(8.0, Program.Add("5", "3"));
    }

    [TestMethod]
    public void AddNegativeNumbersDubas()
    {
        Assert.AreEqual(-8.0, Program.Add("-5", "-3"));
    }

    [TestMethod]
    public void SubtractPositiveNumbersDubas()
    {
        Assert.AreEqual(2.0, Program.Subtract("5", "3"));
    }

    [TestMethod]
    public void SubtractNegativeNumbersDubas()
    {
        Assert.AreEqual(-2.0, Program.Subtract("-5", "-3"));
    }

    [TestMethod]
    public void MultiplyPositiveNumbersDubas()
    {
        Assert.AreEqual(15.0, Program.Multiply("5", "3"));
    }

    [TestMethod]
    public void MultiplyByZeroDubas()
    {
        Assert.AreEqual(0.0, Program.Multiply("5", "0"));
    }

    [TestMethod]
    public void DividePositiveNumbersDubas()
    {
        Assert.AreEqual(2.0, Program.Divide("6", "3"));
    }

    [TestMethod]
    public void DivideNegativeNumbersDubas()
    {
        Assert.AreEqual(-2.0, Program.Divide("-6", "3"));
    }

    [TestMethod]
    public void PowerPositiveExponentDubas()
    {
        Assert.AreEqual(8.0, Program.Power("2", "3"));
    }

    [TestMethod]
    public void PowerZeroExponentDubas()
    {
        Assert.AreEqual(1.0, Program.Power("5", "0"));
    }
}
