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

        [Theory]
        [InlineData("0:1:N", "0:2:N")]
        [InlineData("0:2:N", "0:3:N")]
        [InlineData("1:1:W", "0:1:W")]
        public void MoveForward(string initialState, string finalState)
        {
            //Arrange - Given
            var marsRover = new MarsRover(initialState);
            //Act - When
            var result = marsRover.Execute("M");
            //Assert - Then
            result.Should().Be(finalState);
        }

    }
}