using Xunit;
using FluentAssertions;

namespace MarsRoverGuided.Tests
{
    public class RoverShould
    {
        [Fact]
        public void ReturnInitialState()
        {
            //arrange
            var marsRover = new MarsRover("0:0:N");
            //act
            var result = marsRover.Execute("");
            //assert
            result.Should().Be("0:0:N");

        }
    }
}