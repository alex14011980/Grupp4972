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
if (number < 100)                                           //Проверяем наличие третьей цифры
{
    Console.WriteLine(" Третьей цифры нет");
}
else
{
    if(number < 1000)                                               // Выводим третью цифру. и. т.д. до 10 знаков
    {
        number = number %10;
    
    }
    else if(number < 10000) 
    {
        number = (number/10)%10;
    
    } 
    else if(number < 100000) 
    {
        number = (number/100)%10;
    
    }
    else if(number < 1000000) 
    {
        number = (number/1000)%10;
     
    }
    else if(number < 10000000)
    {
        number = (number/10000)%10;
     
    }
    else if(number < 100000000) 
    {
        number = (number/100000)%10;
     
    }
    else if (number < 1000000000) 
    {
     number = (number/1000000)%10;
    }
    Console.WriteLine(number + "- Третья цифра числа");
}
// ВАРИАНТ 2 
// решение задачи без использования массива

// Приглашение в консоли ввести число
Console.WriteLine("Введите положительное число");

// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int num = int.Parse(Console.ReadLine() ?? "0");

// вычисляем разрядность введенного числа c помощью десятичного логарифма
double digit = Math.Log10(num);
// Конвертирую double -> int и отбрасываю дробную часть
digit = (int)digit;

// проверяем введенное число,  оно должно быть 3х значное или больше
if (digit > 1)
{
    // устанавливаем счетчик
    int count = 1;
    // объявляем переменную
    int res = num;
    while (count < digit - 1)
    {
        // отбрасываем число до 3 знаков
        res = res/10;
        count ++;
    }
    // Выводим последнюю цифру числа
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}

else
{
    // Выводим результат если введено двузначное или однозначное число
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}