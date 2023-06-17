//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
int[] sum = SumRows(array);
PrintArray(array);
Console.WriteLine();
MinimalSumRows(sum);

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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();    
    }
}

int[] SumRows(int[,] inArray)
{
    int[] sum = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++){
          sum[i] += inArray[i, j];
        }
    }
    return sum;
}        

void MinimalSumRows(int[] sum)
{
  int minSum = sum[0];
    for(int i = 0; i < sum.Length; i++) 
        {
        if(minSum > sum[i])
        minSum = sum[i];
        }
        for(int j = 0; j < sum.Length; j++)
            {
            if(minSum == sum[j])
            Console.WriteLine($"Минимальная сумма строки : {j+1}!");
            } 
}

    