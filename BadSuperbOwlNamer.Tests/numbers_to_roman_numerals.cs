using System;
using Xunit;

namespace BadSuperbOwlNamer.Tests
{
    public class numbers_to_roman_numerals
    {
        [Fact]
        public void number_1_should_be_I()
        {
            //Arrange
            var superbOwl = new SuperbOwlNamer();
            var input = 1;
            var expectedResult = "I";

            //Act
            var actualResult = superbOwl.romanNumeraler(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_5_should_be_V()
        {
            //Arrange
            var superbOwl = new SuperbOwlNamer();
            var input = 5;
            var expectedResult = "V";

            //Act
            var actualResult = superbOwl.romanNumeraler(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_9_should_be_IX()
        {
            //Arrange
            var superbOwl = new SuperbOwlNamer();
            var input = 9;
            var expectedResult = "IX";

            //Act
            var actualResult = superbOwl.romanNumeraler(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
