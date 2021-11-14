using System;
using Xunit;
using QuadraticEquation;

namespace QuadraticEquationTests
{
    public class InputFileTests
    {
        [Fact]
        public void ConvertLineToEquationTest1()
        {
            // Arrange
            string line = "2 3 4";
            Equation expectedEquation = new Equation(2.0, 3.0, 4.0);
            bool expectedBool = true;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out Equation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest2()
        {
            // Arrange
            string line = "2 4";
            Equation expectedEquation = new Equation();
            bool expectedBool = false;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out Equation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest3()
        {
            // Arrange
            string line = "2 4 5 47";
            Equation expectedEquation = new Equation();
            bool expectedBool = false;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out Equation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest4()
        {
            // Arrange
            string line = "2,0 4 5,3";
            Equation expectedEquation = new Equation(2.0, 4.0, 5.3);
            bool expectedBool = true;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out Equation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void ConvertLineToEquationTest5()
        {
            // Arrange
            string line = "";
            Equation expectedEquation = new Equation();
            bool expectedBool = false;

            // Act
            bool actualBool = InputFile.ConvertLineToEquation(line, out Equation actualEquation);

            // Assert
            Assert.Equal(expectedEquation, actualEquation);
            Assert.Equal(expectedBool, actualBool);
        }
    }
}