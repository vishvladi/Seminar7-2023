// Задача 1. Задайте двумерный массив размером m×n
//, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());

}
double RandomRealNumbers()
{
    Random rnd = new Random();
    double doubleNum = rnd.NextDouble();
    double intNum = rnd.Next(-10, 10);
    double realNumber = Math.Round(doubleNum + intNum, 1);
    return realNumber;
}
double[,] GenerateArray2D(int rows, int columns)
{
    double[,] numbers = new double[rows, columns];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = RandomRealNumbers();
        }
    }
    return numbers;
}

void PrintArray2D(double[,] numbers)
{
  for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i,j]}\t");
        }
        System.Console.WriteLine();
    }  
}
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов : ");
double[,] array = GenerateArray2D(rows, columns);
PrintArray2D(array);