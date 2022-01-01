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
            //Arrange - Given
            var marsRover = new MarsRover(initialState);
            //Act - When
            var result = marsRover.Execute("");
            //Assert - Then
            result.Should().Be(initialState);
        }
        
       
    }
}