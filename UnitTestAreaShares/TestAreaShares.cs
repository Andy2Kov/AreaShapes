using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaShapes;

namespace UnitTestAreaShares
{
    [TestClass]
    public class TestAreaShares
    {
        [TestMethod]
        public void TestCalculateArea_Circle_R10()
        {
            double result = 314.159265359;
            string shapeName = "Круг";

            ShapeParams p = Calculate.CalculateArea(10);
            Assert.AreEqual(p.Area, result);
            Assert.AreEqual(p.ShapeName, shapeName);   
        }

        [TestMethod]
        public void TestCalculateArea_RightTriangle()
        {
            double result = 25;
            string shapeName = "Прямоугольный треугольник";

            ShapeParams p = Calculate.CalculateArea(Math.Sqrt(25), Math.Sqrt(100), Math.Sqrt(125));

            Assert.AreEqual(p.Area, result);
            Assert.AreEqual(p.ShapeName, shapeName);
        }

        [TestMethod]
        public void TestCalculateArea_Triangle()
        {
            double result = 32.1377383622;
            string shapeName = "Треугольник";

            ShapeParams p = Calculate.CalculateArea(10, 10, 6.84);
            Assert.AreEqual(p.Area, result);
            Assert.AreEqual(p.ShapeName, shapeName);
        }
    }
}
