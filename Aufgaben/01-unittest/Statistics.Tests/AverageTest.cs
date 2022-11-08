using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 1, 3 };
            double expected = 2;
            Average average = new Average();
            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 4, 4, 10, 10, 7 };
            double expected = 7;
            Average average = new Average();
            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 }; 
            numbers.Sort();
            double expected = 4;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            List<int> numbers = new List<int> { 400, 6, 5, 2, 8, 11, 10, 2 };
            double expected = 7;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }
    }
}
