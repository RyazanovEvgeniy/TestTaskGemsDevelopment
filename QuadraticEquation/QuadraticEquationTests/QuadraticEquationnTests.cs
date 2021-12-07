using System;
using Xunit;
using Test;
using System.Collections.Generic;

namespace QuadraticEquationTests
{
    public class QuadraticEquationTests
    {
        [Fact]
        public void QuadraticEquationSolveTest1()
        {
            // Arrange
            QuadraticEquation equation = new QuadraticEquation(1.0, 0.0, 1.0);

            List<double> expectedResult = new List<double>();
            bool expectedBool = false;

            // Act
            bool actualBool = equation.Solve(out List<double> actualResult);

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void SolveQuadraticEquationTest2()
        {
            // Arrange
            QuadraticEquation equation = new QuadraticEquation(1.0, 2.0, 1.0);

            List<double> expectedResult = new List<double> { -1.0 };
            bool expectedBool = true;

            // Act
            bool actualBool = equation.Solve(out List<double> actualResult);

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void SolveQuadraticEquationTest3()
        {
            // Arrange
            QuadraticEquation equation = new QuadraticEquation(1.0, 4.0, 3.0);

            List<double> expectedResult = new List<double> { -1.0, -3.0 };
            bool expectedBool = true;

            // Act
            bool actualBool = equation.Solve(out List<double> actualResult);

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedBool, actualBool);
        }
    }
}