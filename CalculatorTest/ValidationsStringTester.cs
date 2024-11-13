using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Services;

namespace CalculatorTest
{
    public class ValidationsStringTester
    {
        private ValidationsString _validations;

        public ValidationsStringTester() => _validations = new ValidationsString();

        [Fact]
        public void Count3CharactersAndReturn3()
        {
            // Arrange
            string text = "Ola";
            int expectedResult = 3;
            // Act
            int result = _validations.CountCharacters(text);
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}