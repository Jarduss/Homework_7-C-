/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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

CreateArrayint(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите строку элемента = ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец элемента = ");
int y = int.Parse(Console.ReadLine());

if(x>=m || y>=n)
{Console.WriteLine("Такого элемента не существует");}
else
{Console.WriteLine($"Число в позиции элемента ({x},{y}) = "+array[x,y]);}

