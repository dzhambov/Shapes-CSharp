using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.TestTools
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetCircumference_CircumferenceOfCirlcle()
        {
            Circle newCircle = new Circle(6);
            double result = newCircle.GetCircumference();
            Assert.AreEqual(result,18.84);
        }

        [TestMethod]
        public void Circle_GetArea_AreaOfCircle()
        {
            Circle newCircle = new Circle(6);
            double result = newCircle.GetArea();
            Assert.AreEqual(result,113.04);
        }
    }
}