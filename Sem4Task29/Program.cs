// Задача №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string msg) //Вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


void PrintArray(int[] arr)  // Печатаем результат
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int[] GenArr(int len) //Создаем массив со случайными числами. Указываем диапазон чисел массива 
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

int num = ReadData("Введите число: ");
int[] res = GenArr(num);
PrintArray(res);
// вывод сообщения и вызов метода GenArr