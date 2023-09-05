// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numA = int.Parse(Console.ReadLine());//Считываем данные с консоли
int numB = int.Parse(Console.ReadLine());
if (numA > numB)          // Сравниваем переменные
{           // Выводим данные в консоль
    Console.WriteLine(numA);
}
else
{
    Console.WriteLine(numB);
}