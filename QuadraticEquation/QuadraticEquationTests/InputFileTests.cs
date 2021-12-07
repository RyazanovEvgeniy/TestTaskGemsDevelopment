using System;
using Xunit;
using Test;

namespace QuadraticEquationTests
{
    public class InputFileTests
    {
        [Fact]
        public void ConvertLineToEquationTest1()
        {
            // Arrange
            string line = "2 3 4";
            QuadraticEquation expectedEquation = new QuadraticEquation(2.0, 3.0, 4.0);
            bool expectedBool = true;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out QuadraticEquation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest2()
        {
            // Arrange
            string line = "2 4";
            QuadraticEquation expectedEquation = new QuadraticEquation();
            bool expectedBool = false;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out QuadraticEquation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest3()
        {
            // Arrange
            string line = "2 4 5 47";
            QuadraticEquation expectedEquation = new QuadraticEquation();
            bool expectedBool = false;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out QuadraticEquation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest4()
        {
            // Arrange
            string line = "2,0 4 5,3";
            QuadraticEquation expectedEquation = new QuadraticEquation(2.0, 4.0, 5.3);
            bool expectedBool = true;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out QuadraticEquation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest5()
        {
            // Arrange
            string line = "";
            QuadraticEquation expectedEquation = new QuadraticEquation();
            bool expectedBool = false;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out QuadraticEquation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }
    }
}