using System;
using Xunit;
using QuadraticEquation;

namespace QuadraticEquationTests
{
    public class CalcTests
    {
        [Fact]
        public void SolveQuadraticEquationTest1()
        {
            // Arrange
            double a = 1.0;
            double b = 0.0;
            double c = 1.0;

            double[] expectedResult = { 0.0, 0.0 };
            bool expectedBool = false;

            // Act
            Calc calc = new Calc(); ;
            bool actualBool = calc.SolveQuadraticEquation(a, b, c, out double[] actualResult);
            
            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void SolveQuadraticEquationTest2()
        {
            // Arrange
            double a = 1.0;
            double b = 2.0;
            double c = 1.0;

            double[] expectedResult = { -1.0, -1.0 };
            bool expectedBool = true;

            // Act
            Calc calc = new Calc(); ;
            bool actualBool = calc.SolveQuadraticEquation(a, b, c, out double[] actualResult);

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void SolveQuadraticEquationTest3()
        {
            // Arrange
            double a = 1.0;
            double b = 4.0;
            double c = 3.0;

            double[] expectedResult = { -1.0, -3.0 };
            bool expectedBool = true;

            // Act
            Calc calc = new Calc(); ;
            bool actualBool = calc.SolveQuadraticEquation(a, b, c, out double[] actualResult);

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }
    }
}