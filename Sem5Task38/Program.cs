// Задача №38 Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

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
void InsertionSort(int[] array) // Сортировка массива методом вставки
{
    
    for (int i = 1; i < array.Length; i++)
    {
        int temp = array[i];
        int j = i - 1;

        
        while (j >= 0 && array[j] > temp)
        {
            array[j + 1] = array[j];
            array[j] = temp;
            j--;
        }
    }
}
void PrintResult(string msg) //печать результата
{ 
 
    Console.WriteLine(msg);
}

int[] array = GenArray(5, 1, 100); //генерируем массив
PrintArray(array);  //выводим массив
InsertionSort(array); //сортируем массив
PrintArray(array);      // выводи сортированный массив
int diff = array[array.Length-1] - array[0]; // Находим разницу между максимальным и минимальным элементами
PrintResult($"Разница между максимальным и минимальным элементами: {diff}"); //выводим результат
