using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;
using FakeItEasy;
using FlightBooking.Domain;
using Xunit;

namespace FlightBooking.Test
{
    public class PlaneTest
    {
        [Fact]
        public void Plane_CreatePlanes_ReturnInt()
        {
            //Arrenge
            Plane plane1;
            Plane plane2;
            Plane plane3;

            //Act
            plane1 = new Plane("P001", "Model 1", 83);
            plane2 = new Plane("P002", "Model 2", 50);
            plane3 = new Plane("P003", "Model 1", 83);
            var result = Plane.Counter;

            //Assert
            result.Should().Be(3);
            plane1.Id.Should().Be(1);
            plane2.Id.Should().Be(2);
            plane3.Id.Should().Be(3);
            plane1.Plate.Should().Be("P001");
            plane1.Model.Should().Be("Model 1");
        }
    }
}
