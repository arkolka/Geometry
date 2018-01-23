using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Radius can not be negative")]
        public void CircleWithNegativeRadiusTest()
        {
            var circle = new Circle(-4);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            var area = Math.PI * 25 / 2;

            Assert.AreEqual(area, circle.GetArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sides can not be negative")]
        public void TriangleWithNegativeRadiusTest()
        {
            var triangle = new Triangle(10,-1,3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can not be more than or equal to the sum of the other two sides")]
        public void TriangleWithInvalidSidesTest()
        {
            var triangle = new Triangle(10, 250, 3);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea());
        }

        [TestMethod]
        public void GetAreaForArrayOfShapes()
        {
            var shapesArray = new Shape[2];
            shapesArray[0] = new Triangle(3, 4, 5);
            shapesArray[1] = new Circle(5);

            Assert.AreEqual(6, shapesArray[0].GetArea());
            Assert.AreEqual(Math.PI * 25 / 2, shapesArray[1].GetArea());
        }
    }
}
