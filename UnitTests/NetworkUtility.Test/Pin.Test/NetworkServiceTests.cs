using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Pin;
using NetworkUtility.DNS;
using Xunit;
using FluentAssertions;
using FluentAssertions.Extensions;
using FakeItEasy;


namespace NetworkUtility.Test.Pin.Test
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dns;

        public NetworkServiceTests()
        {
            _dns = A.Fake<IDNS>();
            _pingService = new NetworkService(_dns);
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            //var pingService = new NetworkService();
            A.CallTo(() => _dns.SendDNS()).Returns(true);

            //Act
            var result = _pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("SUCCESS: Ping sent!");
            result.Should().Contain("SUCCESS");
        }

        [Theory]
        [InlineData(1,1, 2)]
        [InlineData(2,2, 4)]
        public void NetworkService_PingTimeOut_ReturnInt(int a, 
            int b, 
            int expected)
        {
            //Arrange
            //var pingService = new NetworkService();

            //Act
            int result = _pingService.PingTimeOut(a, b);

            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

        [Fact]
        public void NetworkService_LastPingdate_ReturnDate()
        {
            //Arrange

            //Act
            var result = _pingService.LastPingdate();

            //Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
            result.Should().Be(4.October(2023));
        }

        [Fact]
        public void NetworkService_GetNetwork_ReturnNetwork()
        {
            //Arrange
            var expected = new Network
            {
                Country = "Peru",
                IP = "127.0.0.0"
            };

            //Act
            var result = _pingService.GetNetwork();

            //Assert
            result.Should().BeOfType<Network>();
            result.Should().BeEquivalentTo(expected);
            result.IP.Should().Be("127.0.0.0");
        }
    }
}
