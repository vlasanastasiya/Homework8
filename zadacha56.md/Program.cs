// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rand = new Random();
int rows = 5;
int colums = 5;
int [,] array = new int[rows, colums];
Fillarray(array);
Printarray(array);
Findsum(array);
void Fillarray(int[,] array)
 {
      Random random = new Random();
      int rows = array.GetLength(0);
      int colums = array.GetLength(1);
      
      for (int i = 0; i < rows; i++)
      {
           for (int j = 0; j < colums; j++)
           {
               array[i, j] = random.Next(0 , 9);
           }
      }
}
void Printarray(int[,] array)
{
      int rows = array.GetLength(0);
      int colums = array.GetLength(1);
      for (int i = 0; i < rows; i++)
      {
           for (int j = 0; j < colums; j++)
           {
               Console.Write(array[i, j] + " ");
           }
           Console.WriteLine();
      }
}

void Findsum(int [,] array)
{
      int sum = 0;
      int indexrow = 0;
      int summin = 0;
       for (int i = 0; i < colums; i++)
   {
        summin += array[0, i];
   }
  Console.WriteLine($"Сумма 1 строки равна {summin}");

      for (int i = 1; i < rows; i++)
      {
           
            for (int j = 0; j < colums; j++)
            {
               sum+=array[i, j];

            }
            Console.WriteLine($"Сумма {i+1} строки равна {sum}");
            
            if (sum < summin)
            {
                  summin = sum;
                  indexrow = i;

            }
      }
      Console.WriteLine($"Минимальная сумма находится в строке {indexrow + 1} и равна {summin}");                 

}