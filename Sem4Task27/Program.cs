// Задача №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int sumDigit(int num)
{
    int res =0;
    while (num > 0)
    {
        res = res + num%10;
        num = num / 10;
    }

    return res;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int res = sumDigit(num);
PrintResult("Сумма чисел = " +res);