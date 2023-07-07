/*  Задача 3. Задайте двумерный массив из целых чисел. 
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */
 int ReadInt(string message)
 {
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
 }
 int[,] GenerateArray2D(int rows, int columns, int min, int max)
 {
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i,j] = rnd.Next(min, max + 1);
        } 
    }
    return numbers;
 }
void PrintArray2D(int[,] numbers)
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

void PrintAverage(double[] array )
{
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            System.Console.Write($"{array[i]}\t");
        }
        else
        {
            System.Console.Write($"{array[i]}\t");
        }
    }
}
int[] SumofColumns(int[,] array)
{
    int size = array.GetLength(1);
    int[] columnSum = new int[size];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           sum = sum + array[j,i]; 
        }
        columnSum[i] = sum;
    }
    return columnSum;
}
double[] AverageArray (int[] array, int[,] nums)
{
    double[] columnsAverage = new double[array.Length];
    double num1 = (double) nums.GetLength(0);
    for (int i = 0; i < array.Length; i ++)
    {
        double num2 = (double) array[i];
        columnsAverage[i] = Math.Round((num2 / num1), 2);
    }
    return columnsAverage;
}
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = GenerateArray2D(rows, columns, -10, 10);
PrintArray2D(array);
System.Console.WriteLine();
int [] sumArray = SumofColumns(array);
double[] averageValues = AverageArray(sumArray, array);
 PrintAverage(averageValues);
