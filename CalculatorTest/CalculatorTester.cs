using Calculator.Services;

namespace CalculatorTest;

public class CalculatorTester
{
    private CalculatorImp _calc;

    public CalculatorTester() => _calc = new CalculatorImp();

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        // Arrange
        int number1 = 5;
        int number2 = 10;
        int expectedResult = 15;
        // Act
        int result = _calc.Add(number1, number2);
        // Assert
        Assert.Equal(expectedResult, result);
    }
        [Fact]
    public void Add10To10AndReturnumber20()
    {
        // Arrange
        int number1 = 10;
        int number2 = 10;
        int expectedResult = 20;
        // Act
        int result = _calc.Add(number1, number2);
        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CheckingIf4IsEvenAndReturningTrue()
    {
        // Arrange
        int number  = 4;
        // Act
        bool result = _calc.IsPair(number);
        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void TestIsPairint(int[] numbers)
    {
        // Act/ Assert
        Assert.All(numbers, number => Assert.True(_calc.IsPair(number)));
    }
}
