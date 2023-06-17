//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

using System;
using static System.Console;
Clear();
Write($"Введите размер матрицы: ");
int rows_columns = int.Parse(ReadLine());
int[,] array = SpiralArray(rows_columns);
PrintArray(array);

int[,] SpiralArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int row1 = size - 1;
    int column1 = size - 1;
    int row2 = 0;
    int column2 = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        result[i, j] = count;
        //идем вправо
        if (left && top)
        {
            if (j == column1)
            {
                row2++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //идем вниз
        if (!left && top)
        {
            if (i == row1)
            {
                column1--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //идем влево
        if (!left && !top)
        {
            if (j == column2)
            {
                row1--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //Идем вверх
        if (left && !top)
        {
            if (i == row2)
            {
                column2++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
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