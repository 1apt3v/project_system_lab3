using SolveCalculate.Lib;

namespace SolveCalculate.Test;

public class ValidCalculate
{
    [Fact]
    public void TestCalculateSumma()
    {
        Calculate calc = new Calculate();
        int num1 = 4;
        int num2 = 9;

        int result = calc.CalculateSumma(num1, num2);

        int true_value = 13;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateDifference()
    {
        Calculate calc = new Calculate();

        int num1 = 4;
        int num2 = 9;

        int result = calc.CalculateDifference(num1, num2);

        int true_value = -5;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateMultiplication()
    {
        Calculate calc = new Calculate();

        int num1 = 4;
        int num2 = 9;

        int result = calc.CalculateMultiplication(num1, num2);

        int true_value = 36;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateQuotient()
    {
        Calculate calc = new Calculate();

        double num1 = 10;
        double num2 = 4;

        double result = calc.CalculateQuotient(num1, num2);

        double true_value = 2.5;

        Assert.Equal(true_value, result);
    }
}