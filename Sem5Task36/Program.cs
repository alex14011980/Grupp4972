// Задача №36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

int[] GenArray(int length, int lowBorder, int highBorder) //генерируем массив
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
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
                                        // Подсчет суммы элементов, стоящих на нечётных позициях в массиве
int SumOfOddElemPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) { sum += array[i]; }
    return sum;
}
                                        // Вывод результата

void PrintResult(string msg)
{ 
 
    Console.WriteLine(msg);
}
                                                    // Генерация массива из случайных чисел и вывод
int[] array = GenArray(4, 0, 10);
PrintArray(array);
// Подсчет суммы элементов, стоящих на нечётных позициях и вывод результата
int sum = SumOfOddElemPos(array);
PrintResult($"Сумма элементов, стоящих на нечётных позициях в массиве: {sum}");
