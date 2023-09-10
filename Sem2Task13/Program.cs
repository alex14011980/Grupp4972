// Задача №13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string


// Console.WriteLine("Введите число: ");
// int numbers = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введенное число - " + numbers);
// char[] digitChar = numbers.ToString().ToCharArray();
// Console.WriteLine(numbers < 100 ? "Третьей цифры нет" :
// digitChar[2] + " Третья цифра числа");



Console.WriteLine("Введите число: ");                   // Пользовательский ввод
int number = int.Parse(Console.ReadLine()??"0");         // Назначаем переменную

if(number < 100)                                            // Проверяем на наличие третьей цифры
{
    Console.WriteLine("Третьей цифры нет");
}
if(number < 1000)                                               // Выводим третью цифру. и. т.д. до 10 знаков
{
    number =number %10;
    Console.WriteLine(number + " - Третья цифра числа"); 
}
if(number < 10000) 
{
    number = (number/10)%10;
    Console.WriteLine(number + " - Третья цифра числа"); 
} 
if(number < 100000) 
{
    number = (number/100)%10;
    Console.WriteLine(number + " - Третья цифра числа"); 
}
if(number < 1000000) 
{
    number = (number/1000)%10;
    Console.WriteLine(number + " - Третья цифра числа"); 
}
if(number < 10000000) 
{
    number = (number/10000)%10;
    Console.WriteLine(number + " - Третья цифра числа"); 
}
if(number < 100000000) 
{
    number = (number/100000)%10;
    Console.WriteLine(number + " - Третья цифра числа"); 
}
if(number < 1000000000) 
{
    number = (number/1000000)%10;
    Console.WriteLine(number + " - Третья цифра числа"); 
}



