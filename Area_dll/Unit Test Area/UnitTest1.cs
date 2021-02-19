using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Test_Area
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaTriangle_3_4_5_return_6()
        {
            double A, B, C, expected = 0;
            A = 3;
            B = 4;
            C = 5;
            expected = 6;

           double actual =  Area.shape.CalcAreaTriangle(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCircle_1_31416()
        {
           double expected = 3.141592653589793;

            double actual = Area.shape.CalcAreaCircle(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BoolTriangleCheck_3_4_5()
        {
            bool expected = true;

            bool actual = Area.shape.CheckTriangleStraight(3, 4, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
