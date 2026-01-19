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
        public void Generate_WithThree_ReturnListWhitFizz()
        {
            //Arrange & act
            var result = FizzBuzzGenerator.Generate(3);
            
            //Assert
            result.Should().HaveCount(3);
            result[2].Should().Be("Fizz");
        }

        [Fact]
        public void Generate_WithFive_ReturnListWhitBuzz()
        {
            //Arrange & act
            var result = FizzBuzzGenerator.Generate(5);
            
            //Assert
            result.Should().HaveCount(5);
            result[4].Should().Be("Buzz");
        }

        [Fact]
        public void Generate_WithZero_ReturnListEmpty()
        {
            //Arrange & act
            var result = FizzBuzzGenerator.Generate(0);
            
            //Assert
            result.Should().HaveCount(0);
            result.Should().BeEmpty();
            result.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWithOneTwo()
        {
            //Arrange & act
            var result = FizzBuzzGenerator.Generate(2);
            
            //Assert
            result.Should().HaveCount(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
        }
        
        
        
    }
}