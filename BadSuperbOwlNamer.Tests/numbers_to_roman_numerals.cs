using System;
using Xunit;

namespace BadSuperbOwlNamer.Tests
{
    public class numbers_to_roman_numerals
    {
         [Theory]
         [InlineData(1,"I")]
         [InlineData(5,"V")]
         [InlineData(9, "IX")]
         [InlineData(12, "XII")]
                 public void number_x_should_be_roman_numeral_y(int input, string expectedResult)
        {
            //Arrange
            var superbOwl = new SuperbOwlNamer();

            //Act
            var actualResult = superbOwl.indexOfDecimalPlaces(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        /*

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

        */

    }
}
