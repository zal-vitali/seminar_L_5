/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
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

int GetQtNumbers2(int[] array)
{
    int result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        result++;
    }

    return result;
}

Console.Clear();
Console.WriteLine("Для подсчета чётных элементов, задайте размер массива");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, 100, 999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Количество чётных элементов в массиве: {GetQtNumbers2(array)}");