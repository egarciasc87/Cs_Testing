using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using FakeItEasy;
using FluentAssertions;
using FlightBooking.Domain;

namespace FlightBooking.Test
{
    public class AirplaneTest
    {
        [Fact]
        public void Airline_CreateAirline_ReturnInt()
        {
            //Arrenge
            Airline airline1;
            Airline airline2;
            
            //Act
            airline1 = new Airline("Peru Air");
            airline2 = new Airline("Viva Peru");
            var result = Airline.Counter;
            
            //Assert
            result.Should().Be(2);
            result.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(4, 4)]
        [InlineData(1, 1)]
        public void Airline_AddPlanes_ReturnInt(int numberPlanes, int expected)
        {
            //Arrenge
            var airline = new Airline("Air Peru");

            //Act
            airline.AddPlanes(numberPlanes);
            var result = airline.GetNumberPlanes();

            //Assert
            result.Should().Be(expected);
        }
    }
}
