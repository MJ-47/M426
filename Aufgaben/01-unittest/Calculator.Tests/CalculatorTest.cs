using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Arrange
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }


       [Fact]
        public void TestMultiplicationFourTimesTwoIsEight()
        {
            // Arrange
            int a = 2;
            int b = 4;
            int expected = 8;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }



       [Fact]
        public void TestDevideFourTimesTwoIsTwo()
        {
            // Arrange
            int a = 4;
            int b = 2;
            int expected = 2;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Devide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }



       [Fact]
        public void TestDevideFourTimesZeroIsExeption()
        {
            // Arrange
            int a = 4;
            int b = 0;
            int expected = 2;
            Calculator calculator = new Calculator();

            // Assert
            Assert.Throws<ArgumentException>(() =>
                actual = calculator.Divide(a, b)
           );
        }
    }
}
