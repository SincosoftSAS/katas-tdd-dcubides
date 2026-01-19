using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }
        
        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }

        [Fact]
        public void Generate_WhitThree_ReturnListWhitFizz()
        {
            //Arrange & act
            var result = FizzBuzzGenerator.Generate(3);
            
            //Assert
            result.Should().HaveCount(3);
            result[2].Should().Be("Fizz");
        }

        [Fact]
        public void Generate_WhitFive_ReturnListWhitBuzz()
        {
            //Arrange & act
            var result = FizzBuzzGenerator.Generate(5);
            
            //Assert
            result.Should().HaveCount(5);
            result[4].Should().Be("Buzz");
        }
    }
}