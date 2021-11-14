using System;
using Xunit;
using QuadraticEquation;
using System.Collections.Generic;

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

            List<double> expectedResult = new List<double>();
            bool expectedBool = false;

            // Act
            bool actualBool = Calc.SolveQuadraticEquation(a, b, c, out List<double> actualResult);
            
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

            List<double> expectedResult = new List<double>{ -1.0 };
            bool expectedBool = true;

            // Act
            bool actualBool = Calc.SolveQuadraticEquation(a, b, c, out List<double> actualResult);

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

            List<double> expectedResult = new List<double>{ -1.0, -3.0 };
            bool expectedBool = true;

            // Act
            bool actualBool = Calc.SolveQuadraticEquation(a, b, c, out List<double> actualResult);

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }
    }
}