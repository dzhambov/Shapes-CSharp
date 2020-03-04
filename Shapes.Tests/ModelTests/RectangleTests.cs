using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.TestTools
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Rectangle_GetArea_AreaOfRectangle()
        {
            Rectangle newRectangle = new Rectangle(4, 2);
            int result = newRectangle.GetArea();
            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void Rectangle_IsSquare_True()
        {
            Rectangle newRectangle = new Rectangle(4, 4);
            bool result = newRectangle.IsSquare();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Rectangle_IsSquare_False()
        {
            Rectangle newRectangle = new Rectangle(4, 5);
            bool result = newRectangle.IsSquare();
            Assert.AreEqual(result, false);
        }

    }
}