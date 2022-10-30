﻿/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[5, 5];

void CreateArrayint(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(1,5) ;
    }
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}

double result = 0;

CreateArrayint(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца = ");
   for(int j = 0; j < array.GetLength(0); j++)
    {
        result = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
        result = result + array[i,j];
        }
        Console.Write(result/m +" | ");
    }