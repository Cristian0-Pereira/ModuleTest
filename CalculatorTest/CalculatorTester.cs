using Calculator.Services;

namespace CalculatorTest;

public class CalculatorTester
{
    private CalculatorImp _calc;

    public CalculatorTester()
    {
        _calc = new CalculatorImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        // Arrange
        int n1 = 5;
        int n2 = 10;
        int resultadoEsperado = 15;

        // Act
        int resultado = _calc.Add(n1, n2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}

// Implementando validações de string