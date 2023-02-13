/* Задача "со звездочкой": Разобраться с алгоритмом сортировки
методом пузырька. Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
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

void SortArray(int[] array)
{
    int maxValue;

    for(int i = 0; i < array.Length; i++)
    {
        maxValue = array[i];
        for(int k = i + 1; k < array.Length; k++)
        {
            if(array[k] > maxValue)
            {
                array[i] = array[k];
                array[k] = maxValue;
                maxValue = array[i]; 
            }
        }    
    }
}

Console.Clear();
Console.WriteLine("Для сортировки массива, задайте его размер");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, -10, 10);
Console.WriteLine(String.Join(", ", array));
SortArray(array);
Console.WriteLine(String.Join(", ", array));
