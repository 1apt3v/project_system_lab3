using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExmpression.Test;

public class ValidMathFirstExpression
{
    [Fact]
    public void TestCalculateFirstExpression()
    {
        double x = 0.5;
        double y = 0.2;
        
        MathFirstExpression ds = new MathFirstExpression();

        double res = ds.CalculateFirstExpression(x,y);

        double true_value = 0.216;

        Assert.Equal(true_value, res);
    }
}