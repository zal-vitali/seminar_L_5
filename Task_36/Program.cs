/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих на
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minVal, maxVal + 1);
    }

    return result;
}

int GetSumElements1(int[] array)
{
    int sumElements1 = 0;

    for(int i = 0; i < array.Length; i += 2)
    {
        sumElements1 += array[i];
    }

    return sumElements1;
}

Console.Clear();

int[] array = GetArray(11, -10, 10);
Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива: {GetSumElements1(array)}");