// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

// int f = int.Parse(Console.ReadLine()??"0");
// int s = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine((s%f==0)?true:s%f);


Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num2%num1==0?"Второе число кратно первому":"Остаток от деления: " + (num2%num1));