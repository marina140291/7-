// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
void InputMatrix(int[,] matrix)
{
    for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    {
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++) 
    {
        matrix[i, j] = new Random().Next(-10,11);
        Console.Write($"{matrix[i, j]} \t");
    }   
    Console.WriteLine();
    }
}
void Release(int[,]matrix)
{Console.WriteLine("Введите число: ");
int s = Convert.ToInt32(Console.ReadLine());
for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    {
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++)
    {
        if ( matrix[i, j]==s) 
       
        Console.WriteLine($"Месторасположения: {i} {j} ");
    
    //else if (matrix[i,j] != s)
    // Console.WriteLine("Такого числа нет");
    }
    }
        Console.WriteLine("Такого числа нет");
      }
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Release(matrix);