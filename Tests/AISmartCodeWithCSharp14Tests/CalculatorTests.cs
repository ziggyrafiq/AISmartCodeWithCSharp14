using AISmartCodeWithCSharp14.Utilities;

namespace AISmartCodeWithCSharp14Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact] 
    public void Add_ShouldReturnCorrectSum()
    {
        int result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        int result = _calculator.Subtract(10, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        int result = _calculator.Multiply(4, 5);
        Assert.Equal(20, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        double result = _calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }

    
    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        var exception = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        Assert.Equal("Cannot divide by zero.", exception.Message);
    }
}
