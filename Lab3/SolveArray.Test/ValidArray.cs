using SolveArray.Lib;

namespace SolveArray.Test;

public class ValidArray
{
    [Fact]
    public void TestCalculateMinimum()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = [1.0, 10.4, 3.4, 3.2, 8.4]; 

        double result = ds.CalculateMinimum(testArray);

        double true_value = 1.0;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateMaximum()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = [1.0, 10.4, 3.4, 3.2, 8.4]; 

        double result = ds.CalculateMaximum(testArray);

        double true_value = 10.4;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateAverage()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = [1.0, 10.4, 3.4, 3.2, 8.4]; 

        double result = ds.CalculateAverage(testArray);

        double true_value = 5.28;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateMedian()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = [1.0, 10.4, 3.4, 3.2, 8.4]; 

        double result = ds.CalculateMedian(testArray);

        double true_value = 3.4;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateNumberOfEven()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 2.0, 4.0, 8.0, 1.0, 3.0 }; 

        int result = ds.CalculateNumberOfEven(testArray);

        int true_value = 3;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestCalculateNumberOfOdd()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 2.0, 4.0, 8.0, 1.0, 3.0 }; 

        int result = ds.CalculateNumberOfOdd(testArray);

        int true_value = 2;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByTwo()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 2.0, 4.0, 8.0, 1.0, 3.0 }; 

        int result = ds.SignsOfDivisibilityByTwo(testArray);

        int true_value = 3;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByThree ()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 2.0, 4.0, 9.0, 1.0, 3.0 }; 

        int result = ds.SignsOfDivisibilityByThree(testArray);

        int true_value = 2;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByFive()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 20.0, 4.0, 9.0, 10.0, 3.0 }; 

        int result = ds.SignsOfDivisibilityByFive(testArray);

        int true_value = 2;

        Assert.Equal(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByTen()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 20.0, 4.0, 9.0, 10.0, 3.0 }; 

        int result = ds.SignsOfDivisibilityByTen(testArray);

        int true_value = 2;

        Assert.Equal(true_value, result);
    }
}