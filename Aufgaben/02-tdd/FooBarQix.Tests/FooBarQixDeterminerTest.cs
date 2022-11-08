using Xunit;

namespace FooBarQix.Tests {
  public class FooBarQixDeterminerTest {

    [Theory]
    [InlineData(2, "2")]
    [InlineData(3, "Foo")]
    [InlineData(5, "Bar")]
    [InlineData(7, "Qix")]
    [InlineData(21, "FooQix")]
    [InlineData(35, "BarQix")]
    [InlineData(1232, "Qix")]
    [InlineData(105, "FooBarQix")]

    public void Determine_WhatNumbersAreDivisible(int number, string expected) {


      // Arrange
      FooBarQixDeterminer d1 = new FooBarQixDeterminer();

      // Act


      // Assert
      Assert.Equal(expected, d1.Determine(number));
    }
  }
}