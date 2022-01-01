using Xunit;
using FluentAssertions;

namespace MarsRoverGuided.Tests
{
    public class RoverShould
    {
        [Theory]
        [InlineData("0:0:N")]
        [InlineData("1:1:W")]
        public void ReturnInitialState (string initialState)
        {
            var marsRover = new MarsRover(initialState);

            var result = marsRover.Execute("");

            result.Should().Be(initialState);
        }

        [Fact]
        public void MoveForward()
        {
            //Arrange - Given
            var marsRover = new MarsRover("0:0:N");
            //Act - When
            var result = marsRover.Execute("M");
            //Assert - Then
            result.Should().Be("0:1:N");

        }

    }
}