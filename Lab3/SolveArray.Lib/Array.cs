namespace SolveArray.Lib;

public class ArrayCustom
{
    public double CalculateMinimum(double[] array)
    {
        return array.Min();
    }
    public double CalculateMaximum(double[] array)
    {
        return array.Max();
    }
    public double CalculateAverage(double[] array)
    {
        double resultAvg = array.Average();

        return Double.Round(resultAvg, 2);
    }
    public double CalculateMedian(double[] array)
    {
        var sortedArray = array.OrderBy(x => x).ToArray();

        // Нахождение медианы
        double median;
        int n = array.Length;

        if (n % 2 == 1) // Если количество элементов нечётное
        {
            median = array[n / 2]; // Центральный элемент
        }
        else // Если количество элементов чётное
        {
            median = (array[(n / 2) - 1] + array[n / 2]) / 2.0; // Среднее значение двух центральных элементов
        }

        return median;
    }
    public int CalculateNumberOfEven(double[] array)
    {
        int evenCount = 0;

        // Проход по массиву и проверка чётности элементов
        foreach (double number in array)
        {
            if (number % 2 == 0) // Проверка на чётность
            {
                evenCount++;
            }
        }

        return evenCount;
    }
    public int CalculateNumberOfOdd(double[] array)
    {
        int oddCount = 0;

        // Проход по массиву и проверка на нечётность
        foreach (int number in array)
        {
            if (number % 2 != 0) // Проверка на нечётность
            {
                oddCount++;
            }
        }

        return oddCount;
        
    }
    public int SignsOfDivisibilityByTwo(double[] array)
    {
        int divisibleByTwoCount = 0;

        // Проход по массиву и проверка на делимость на 2
        foreach (int number in array)
        {
            if (number % 2 == 0) // Проверка на делимость на 2 (чётность)
            {
                divisibleByTwoCount++;
            }
        }

        return divisibleByTwoCount;
    }
    public int SignsOfDivisibilityByThree(double[] array)
    {
        int divisibleByThreeCount = 0;

        // Проход по массиву и проверка на делимость на 3
        foreach (int number in array)
        {
            if (number % 3 == 0) // Проверка на делимость на 3
            {
                divisibleByThreeCount++;
            }
        }

        return divisibleByThreeCount;
    }
    public int SignsOfDivisibilityByFive(double[] array)
    {
        int divisibleByFiveCount = 0;

        // Проход по массиву и проверка на делимость на 5
        foreach (int number in array)
        {
            if (number % 5 == 0) // Проверка на делимость на 5
            {
                divisibleByFiveCount++;
            }
        }

        return divisibleByFiveCount;
    }
    public int SignsOfDivisibilityByTen(double[] array)
    {
        int divisibleByTenCount = 0;

        // Проход по массиву и проверка на делимость на 10
        foreach (int number in array)
        {
            if (number % 10 == 0) // Проверка на делимость на 10
            {
                divisibleByTenCount++;
            }
        }

        return divisibleByTenCount;
    }
}
