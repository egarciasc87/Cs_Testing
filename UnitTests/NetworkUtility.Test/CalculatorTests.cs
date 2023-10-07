using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using FluentAssertions;
using FakeItEasy;
using CalculatorDomain;

namespace NetworkUtility.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_ReturnInt_v1()
        {
            //Arrenge
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(2, 6);

            //Assert
            result.Should().Be(8);
        }

        [Fact]
        public void Sum_ReturnInt_v2()
            => new Calculator()
            .Sum(2, 7)
            .Should()
            .Be(9);

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(1, 6, 7)]
        [InlineData(7, 5, 12)]
        public void Sum_ReturnInt_v3(int num_1,
            int num_2,
            int expected)
        {
            //Arrange

            //Act
            var result = new Calculator().Sum(num_1,
                num_2);

            //Asserve
            result.Should().Be(expected);
        }
    }
}
