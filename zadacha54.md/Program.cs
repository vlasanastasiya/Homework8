// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random rand = new Random();
int rows = rand.Next(2, 5);
int colums = rand.Next(2, 5);
int [,] array = new int[rows, colums];
Fillarray(array);
Printarray(array);
Console.WriteLine("вывод массива");
Arrayminus(array);
Printarray(array);

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
      void Arrayminus(int[,] array)
{
       for (int i = 0; i < rows; i++)
      {
           for (int j = 0; j < colums; j++)
           {
              for (int c = 0; c < colums - j - 1; c++)
           {
              if (array[i, c] < array[i, c + 1])
              {
                  int temp = array[i, c];
                  array[i, c] = array[i, c + 1];
                  array[i, c + 1] = temp;

              }

           } 
           }
      }
}
