using Xunit;
using FlightBooking.Domain;
using FluentAssertions;
using FakeItEasy;

namespace FlightBooking.Test
{
    public class FlightTest
    {
        //https://www.youtube.com/watch?v=m863B7Eb6I4&t=2553s

        [Fact]
        public void Flight_GetSeatsRemaining_ReturnInt()
        {
            //1. GIVEN scenario
            var flight = new Flight(seatCapacity: 3);

            //2. WHEN something happens
            flight.Book("egarcia@gmail.com", 5);

            //SUT (subject under test) --> flight

            //3. THEN the result must be
            //flight.GetSeatsRemaining().Should().Be(2);
            flight.GetSeatsRemaining().Should().BeGreaterThan(0);
        }

        [Fact]
        public void Avoid_OverBooking()
        {
            //Given
            var flight = new Flight(3);

            //When
            var error = flight.Book("egarcia@gmail.com", 4);

            //Then
            error.Should().BeOfType<OverBookingError>();
        }
    }
}