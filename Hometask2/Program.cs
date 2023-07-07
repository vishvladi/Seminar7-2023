// Задача 2. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
/* что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
0, 0 -> 1
 */
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());

}
int RandomMinMax(int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
    return num;
}
 
int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = RandomMinMax(-10, 10);
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
bool ValidateUserData(int userRows, int userColumns, int[,] array)
{
    if(userRows > array.GetLength(0) || userColumns > array.GetLength(1)) 
    {
        return false;
    }
    return true;
}

void PrintUserNum(int userRows, int userColumns, int[,] array)
{
    if(ValidateUserData(userRows, userColumns, array))
    {
        System.Console.WriteLine($"В заданной ячейке находится число: {array[userRows, userColumns]}");
        return;    
    }
    System.Console.WriteLine("В заданной ячейке нет числа");
}
int userRows = ReadInt("Введите номер строки: ");
int userColumns = ReadInt("Введите столбца: ");
int[,] array = GenerateArray2D(RandomMinMax(1, 10), RandomMinMax(1, 10));
System.Console.WriteLine();
PrintArray2D(array);
System.Console.WriteLine();
PrintUserNum(userRows, userColumns, array);
