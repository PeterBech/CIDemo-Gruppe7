using System;
using Xunit;
using Lommeregner;

namespace CalculatorTests
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 0, 0)]
        public void Add_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 5, -5)]
        public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(0, 5, 0)]
        public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
        {
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(5, 2, 2.5)]
        [InlineData(-10, -2, 5)]
        public void Divide_ReturnsCorrectQuotient(int a, int b, double expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result, 5);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}