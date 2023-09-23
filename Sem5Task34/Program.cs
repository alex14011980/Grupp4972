// Задача №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123] -> 1

int[] GenArray(int length, int lowBorder, int highBorder) //генерируем массив
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder);
    }
    return arr;
}
void PrintArray(int[] arr)              //выводим массив
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    System.Console.WriteLine();
}
int CountEven(int[]arr)                     //считаем количество четных элементов массива
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(5, 100, 1000);
PrintArray(array);
int count = CountEven(array);
PrintResult($"{count} четных элементов");