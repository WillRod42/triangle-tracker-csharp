using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker;

namespace Tracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void GetTypeOfTriangle_ReturnsTypeOfTriangle_SaysNotATriangle()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("Not a triangle", testTriangleTracker.GetTypeOfTriangle(0, 0, 0));
    }

    [TestMethod]
    public void GetTypeOfTriangle_ReturnsTypeOfTriangle_EquilateralTriangle()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("Equilateral triangle", testTriangleTracker.GetTypeOfTriangle(1, 1, 1));
    }

    [TestMethod]
    public void GetTypeOfTriangle_ReturnsTypeOfTriangle_IsoscelesTriangle()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("Isosceles triangle", testTriangleTracker.GetTypeOfTriangle(1, 1, 2));
    }

    [TestMethod]
    public void GetTypeOfTriangle_ReturnsTypeOfTriangle_ScaleneTriangle()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("Scalene triangle", testTriangleTracker.GetTypeOfTriangle(2, 3, 4));
    }
  }
}