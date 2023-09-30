// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//вводим данные матриц
Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);          //вывод 1 матрицы
Console.WriteLine($"Первая матрица:");
Print2Array(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);             //вывод 2 матрицы
Console.WriteLine($"Вторая матрица:");
Print2Array(secomdMartrix);

int[,] resultMatrix = new int[m,p]; //создаем переменную

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);      // перемножение матриц
Console.WriteLine($"Произведение первой и второй матриц:"); 
Print2Array(resultMatrix);
// перемножение матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input) //ввод чисел массива от 1 до ........
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)          //создание массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void Print2Array (int[,] array)              // вывод  массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}