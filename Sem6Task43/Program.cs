// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)



double[,] coordinate = new double[2, 2];    //создаем массивы
double[] crossPoint = new double[2];

void Inputcoordinate()      //пользовательский ввод координат
{
  for (int i = 0; i < coordinate.GetLength(0); i++)
  {
    Console.Write($"Введите координаты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coordinate.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите координату k: ");
      else Console.Write($"Введите координату b: ");
      coordinate[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] SearchCrossPoint(double[,] coordinate) //нахождение точки пересечения
{
  crossPoint[0] = (coordinate[1,1] - coordinate[0,1]) / (coordinate[0,0] - coordinate[1,0]);
  crossPoint[1] = crossPoint[0] * coordinate[0,0] + coordinate[0,1];
  return crossPoint;
}

void OutputСoordinate(double[,] coordinate)     //вывод результата
{
  if (coordinate[0,0] == coordinate[1,0] && coordinate[0,1] == coordinate[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coordinate[0,0] == coordinate[1,0] && coordinate[0,1] != coordinate[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    SearchCrossPoint(coordinate);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

Inputcoordinate();
OutputСoordinate(coordinate);