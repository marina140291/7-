//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
void InputMatrix(int[,] matrix)
{
    for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    {
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++) 
    {
        matrix[i, j] = new Random().Next(1,10);
        Console.Write($"{matrix[i, j]} \t");
    }   
    Console.WriteLine();
    }
}
void Release(int[,]matrix)
{
for (int j=0 ;j < matrix.GetLength(1) ; j++)
    {
double s = 0;
for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    
    
               s = (s + matrix[i,j]);

        Console.Write($"{s/matrix.GetLength(0)} \t");}
      
    }
    
      
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine();
Release(matrix);