// Задача №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine()!); //пользовательский ввод
PrintArray(numbers); //выводим массив
int quan = 0;
for (int i = 0; i < numbers.Length; i++) // ищем числа в массиве больше нуля
{
    if (numbers[i] > 0)
    {
        quan++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {quan}"); //выводим результат


int[] StringToNum(string input)  // вводим числа
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];  //создаем массив из введенных чисел
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)  //выводим массив
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}