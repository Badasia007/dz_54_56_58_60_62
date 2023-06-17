//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
Write("Введите глубину массива: ");
int dept = int.Parse(ReadLine());
int[,,] array = GetArray(rows, columns, dept , 10, 99);

PrintArray(array);
WriteLine();

int[,,] GetArray(int m, int n, int y, int min, int max)
{
    int[,,] result = new int[m, n, y];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          for (int c = 0; c < y; c++)
        {
            result[i, j, c] = new Random().Next(min, max + 1);
          }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
          for (int c = 0; c < inArray.GetLength(2); c++)
            {
                Write($"{inArray[i, j, c]}({i},{j},{c}) ");
            }
        WriteLine();
        }
    }
  }    