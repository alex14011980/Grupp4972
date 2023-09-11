// Задача №15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// int day = int.Parse(Console.ReadLine()??"0");

// string[] dayOfWeek = new string [7];
// dayOfWeek[0] = "Понедельник";
// dayOfWeek[1] = "Вторник";
// dayOfWeek[2] = "Среда";
// dayOfWeek[3] = "Четверг";
// dayOfWeek[4] = "Пятница";
// dayOfWeek[5] = "Суббота";
// dayOfWeek[6] = "Воскресенье";

// if (day > 5)
// {
//     Console.WriteLine(dayOfWeek[day - 1 ] + " - Выходной день");
// }
// else 
// {
//     Console.WriteLine(dayOfWeek[day - 1 ] + " - Рабочий день");
// }




Console.WriteLine("Введите номер дня недели: ");                        // Пользовательский ввод
var day = int.Parse(Console.ReadLine()??"0");                           // Назначаем переменную                                                                            
Dictionary<int, string> Directory = new Dictionary<int, string>();        //Cоздаем словарь Dictionary  
var dayOfWeeky = new Dictionary<int, string>()

{
    [1] = "Понедельник",
    [2] = "Вторник",
    [3] = "Среда",
    [4] = "Четверг",
    [5] = "Пятница",
    [6] = "Суббота",
    [7] = "Воскресенье"   
 
};

if(day <= 5)                                                                //Проверяем на наличие рабочие дни 
{
    Console.WriteLine(dayOfWeeky[day] + " - Нет");                                             //Выводим сообщение

}
else if(day <=7)                                                               // Проверяем на наличие выходного дня
{
    Console.WriteLine(dayOfWeeky[day] + " - Да");                                                 // Выводим сообщение
}
else
{
    Console.WriteLine("Не является днем недели");                               // проверка на неверный ввод. Выводим сообщение.
}
