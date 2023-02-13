/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным элементов
массива.
[3 7 22 2 78] -> 76
 */

double[] GetArray(int size, int minVal, int maxVal)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        double newRandomDouble = new Random().NextDouble();
        result[i] = Math.Round((maxVal - (maxVal - minVal) * newRandomDouble), 3);
    }

    return result;
}

double CalcDiff(double[] array)
{
    if (array.Length == 0)
    {
        return 0;
    }
    double maxVal = array[0];
    double minVal = array[0];
    double result = 0;

    foreach (double element in array)
    {
        if (element > maxVal)
        {
            maxVal = element;
        }
        else
        {
            if (element < minVal)
            {
                minVal = element;
            }
        }
    }

    result = maxVal - minVal;
    return result;
}

Console.Clear();
double[] array = GetArray(10, -100, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {CalcDiff(array)}");