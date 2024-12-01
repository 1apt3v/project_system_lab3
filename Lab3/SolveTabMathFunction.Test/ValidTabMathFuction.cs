
using SolveTabMathFunction.Lib;

namespace SolveTabMathFunction.Test;

public class ValidTabMathFuction
{
    [Fact]
    public void TestCalculateTabMathFuction()
    {
        TabMathFuction ds = new TabMathFuction();

        int startStep = 1;
        int stopStep = 5;

        double[][] result = ds.CalculateTabMathFuction(startStep, stopStep);

        double[][] true_value = [[1, 2.5356617876242087],[2, 0.980174458889017], [3, 1.3122703192413065], [4, 2.426184393613433]];

        Assert.Equal(true_value, result);
        
    }
}