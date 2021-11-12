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

            double[] expected = null;

            // Act
            Calc calc = new Calc(); ;
            double[] actual = calc.SolveQuadraticEquation(a, b, c);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolveQuadraticEquationTest2()
        {
            // Arrange
            double a = 1.0;
            double b = 2.0;
            double c = 1.0;

            double[] expected = { -1, -1 };

            // Act
            Calc calc = new Calc(); ;
            double[] actual = calc.SolveQuadraticEquation(a, b, c);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolveQuadraticEquationTest3()
        {
            // Arrange
            double a = 1.0;
            double b = 5.0;
            double c = 4.0;

            double[] expected = { -1.0, -4.0 };

            // Act
            Calc calc = new Calc(); ;
            double[] actual = calc.SolveQuadraticEquation(a, b, c);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}