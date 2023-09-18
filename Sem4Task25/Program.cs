// Задача №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadData(string msg) // Вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
long MyPow(int numA, int numB) //расчет возведения числа А в степень В
{
    long res = 1;
    while (numB > 0)
    {
        res = res * numA;
        numB = numB - 1;
    } 

    return res;

}

void PrintResult(string msg) //Печатаем результат
{
    Console.WriteLine(msg);
}

int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число В: ");
long res = MyPow(numA, numB);
PrintResult("Степень числа А = "+res);
// вывод сообщения и вызов метода MyPow
