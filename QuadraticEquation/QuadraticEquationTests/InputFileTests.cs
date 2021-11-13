using System;
using Xunit;
using QuadraticEquation;

namespace QuadraticEquationTests
{
    public class InputFileTests
    {
        [Fact]
        public void LineToEquationTest1()
        {
            // Arrange
            string line = "2 3 4";

            Equation expected = new Equation(2.0, 3.0, 4.0);

            // Act
            Equation actual = InputFile.LineToEquation(line);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LineToEquationTest2()
        {
            // Arrange
            string line = "2 3";

            Equation expected = null;

            // Act
            Equation actual = InputFile.LineToEquation(line);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LineToEquationTest3()
        {
            // Arrange
            string line = "";

            Equation expected = null;

            // Act
            Equation actual = InputFile.LineToEquation(line);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LineToEquationTest4()
        {
            // Arrange
            string line = "2 4,4 2 55";

            Equation expected = null;

            // Act
            Equation actual = InputFile.LineToEquation(line);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LineToEquationTest5()
        {
            // Arrange
            string line = "2 3.0 4";

            Equation expected = null;

            // Act
            Equation actual = InputFile.LineToEquation(line);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}