Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трехзначное ");