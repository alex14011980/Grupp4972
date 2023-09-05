// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());//Считываем данные с консоли
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());
int max = Max(numA, numB, numC);
Console.WriteLine(max);