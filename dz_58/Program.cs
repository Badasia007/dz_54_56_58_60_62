//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 1, 5);
int[,] array2 = GetArray(rows, columns, 1, 5);
PrintArray(array);
WriteLine();
PrintArray(array2);
WriteLine();
SimbiozArray(array, array2);
PrintArray(SimbiozArray(array, array2));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
  }
  
int[,] SimbiozArray(int[,] inArray, int[,] inArray2)
{
  int[,] product = new int [inArray.GetLength(0), inArray2.GetLength(1)];
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
      {
        for (int c = 0; c < inArray2.GetLength(1); c++)
        
        product[i,j] += inArray[i,c] * inArray2[c,j];
      }
  }
  return product;
}