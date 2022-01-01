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
        
        [Fact]
        public void ReturnInitialStateWithAnotherPosition()
        {
            //arrange
            var marsRover = new MarsRover("1:1:W");
            //act
            var result = marsRover.Execute("");
            //assert
            result.Should().Be("1:1:W");
        }
    }
}