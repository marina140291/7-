﻿// задайте двумерный массив размером i*j, заполненный случайными вещественными числами 
void InputMatrix(double[,] matrix)
{
    for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    {
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++) 
    {
        matrix[i, j] =  new Random().NextDouble() *20;
        Console.Write($"{matrix[i, j]} \t");
    }   
    Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
Console.WriteLine(" матрица: ");
InputMatrix(matrix);

